namespace ExpenseTracker
{

    public partial class frmExpense : Form
    {
        private readonly Expense expense;   


        public frmExpense() : this(null)
        {
        }


        public frmExpense(Expense? existing)
        {
            InitializeComponent();   

            dtpDate.MaxDate = DateTime.Today;   
            cboCategory.SelectedIndex = 0;

            if (existing == null)
            {
                expense = new Expense();
                Text = "Add Expense";
            }
            else
            {
                expense = existing;
                Text = "Edit Expense";

                dtpDate.Value = existing.Date > DateTime.Today ? DateTime.Today : existing.Date;
                txtDescription.Text = existing.Description;
                cboCategory.SelectedItem = existing.Category;
                nudAmount.Value = existing.Amount;
                rdoCash.Checked = existing.PaymentMethod == "Cash";
                rdoGCash.Checked = existing.PaymentMethod == "GCash";
                rdoCard.Checked = existing.PaymentMethod == "Card";
                chkRecurring.Checked = existing.IsRecurring;
                txtNotes.Text = existing.Notes;
            }
        }


        public Expense GetExpense()
        {
            return expense;
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            errProvider.Clear();
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errProvider.SetError(txtDescription, "Description is required.");
                isValid = false;
            }
            if (nudAmount.Value <= 0)
            {
                errProvider.SetError(nudAmount, "Amount must be greater than 0.");
                isValid = false;
            }
            if (!isValid) return;   

            expense.Date = dtpDate.Value.Date;
            expense.Description = txtDescription.Text.Trim();
            expense.Category = cboCategory.Text;
            expense.Amount = nudAmount.Value;
            if (rdoCash.Checked) expense.PaymentMethod = "Cash";
            else if (rdoGCash.Checked) expense.PaymentMethod = "GCash";
            else expense.PaymentMethod = "Card";
            expense.IsRecurring = chkRecurring.Checked;
            expense.Notes = txtNotes.Text.Trim();

            DialogResult = DialogResult.OK;
        }
    }
}
