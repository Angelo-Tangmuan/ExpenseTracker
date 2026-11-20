using System.Text.Json;

namespace ExpenseTracker
{
    public partial class frmMain : Form
    {
        private List<Expense> expenses = new List<Expense>();
        private string currentFile = "";   
        private bool unsaved = false;      

        public frmMain()
        {
            InitializeComponent();  


            dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            cboCategory.SelectedIndex = 0;                      
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");

            RefreshAll();
            UpdateTitle();
        }


        private void cboCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            RefreshAll();
        }

        private void txtSearch_TextChanged(object? sender, EventArgs e)
        {
            RefreshAll();
        }

        private void chkDateRange_CheckedChanged(object? sender, EventArgs e)
        {
            dtpFrom.Enabled = chkDateRange.Checked;
            dtpTo.Enabled = chkDateRange.Checked;
            RefreshAll();
        }


        private void dtpFilter_ValueChanged(object? sender, EventArgs e)
        {
            RefreshAll();
        }

        private void nudBudget_ValueChanged(object? sender, EventArgs e)
        {
            UpdateRemaining();
        }


        private void dgv_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Edit_Click(sender, e);
        }

        private void tmrClock_Tick(object? sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private List<Expense> GetFiltered()
        {
            IEnumerable<Expense> result = expenses;

            if (cboCategory.Text != "All")
                result = result.Where(x => x.Category == cboCategory.Text);

            string keyword = txtSearch.Text.Trim().ToLower();
            if (keyword != "")
                result = result.Where(x => x.Description.ToLower().Contains(keyword));

            if (chkDateRange.Checked)
                result = result.Where(x => x.Date.Date >= dtpFrom.Value.Date &&
                                           x.Date.Date <= dtpTo.Value.Date);

            return result.OrderByDescending(x => x.Date).ToList();
        }

        private void RefreshAll()
        {
            List<Expense> shown = GetFiltered();
            dgv.DataSource = shown;

            if (dgv.Columns.Count > 0)
            {
                dgv.Columns["Id"]!.Visible = false;
                dgv.Columns["Notes"]!.Visible = false;
                dgv.Columns["Date"]!.DefaultCellStyle.Format = "MM/dd/yyyy";
                dgv.Columns["Amount"]!.DefaultCellStyle.Format = "N2";
                dgv.Columns["Amount"]!.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            decimal total = shown.Sum(x => x.Amount);
            lblSummary.Text = $"Shown: {shown.Count}   Total: PHP {total:N2}";
            lblCount.Text = $"{expenses.Count} records";
            UpdateRemaining();
        }

        private void UpdateRemaining()
        {
            decimal spent = expenses
                .Where(x => x.Date.Year == DateTime.Today.Year && x.Date.Month == DateTime.Today.Month)
                .Sum(x => x.Amount);
            decimal remaining = nudBudget.Value - spent;

            lblRemaining.Text = $"Remaining this month: PHP {remaining:N2}";
            lblRemaining.ForeColor = remaining < 0 ? Color.Red : Color.Green;
        }

        private void UpdateTitle()
        {
            string name = currentFile == "" ? "Untitled" : Path.GetFileName(currentFile);
            Text = "Expense Tracker - " + name + (unsaved ? "*" : "");
        }

        private void MarkChanged()
        {
            unsaved = true;
            UpdateTitle();
        }


        private void Add_Click(object? sender, EventArgs e)
        {
            using (frmExpense form = new frmExpense())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    Expense newExpense = form.GetExpense();
                    newExpense.Id = NextId();
                    expenses.Add(newExpense);
                    MarkChanged();
                    RefreshAll();
                    lblStatus.Text = "Expense added.";
                }
            }
        }

        private void Edit_Click(object? sender, EventArgs e)
        {
            Expense? selected = dgv.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to edit.");
                return;
            }

            using (frmExpense form = new frmExpense(selected))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MarkChanged();
                    RefreshAll();
                    lblStatus.Text = "Expense updated.";
                }
            }
        }

        private void Delete_Click(object? sender, EventArgs e)
        {
            Expense? selected = dgv.CurrentRow?.DataBoundItem as Expense;
            if (selected == null)
            {
                MessageBox.Show("Select an expense to delete.");
                return;
            }

            DialogResult answer = MessageBox.Show($"Delete \"{selected.Description}\"?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                expenses.Remove(selected);
                MarkChanged();
                RefreshAll();
                lblStatus.Text = "Expense deleted.";
            }
        }

        private int NextId()
        {
            return expenses.Count == 0 ? 1 : expenses.Max(x => x.Id) + 1;
        }

        private bool CanContinue()
        {
            if (!unsaved) return true;

            DialogResult answer = MessageBox.Show("You have unsaved changes. Save first?",
                "Unsaved Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (answer == DialogResult.Cancel) return false;  
            if (answer == DialogResult.Yes) return SaveFile(); 
            return true;                                        
        }

        private void New_Click(object? sender, EventArgs e)
        {
            if (!CanContinue()) return;

            expenses.Clear();
            currentFile = "";
            unsaved = false;
            RefreshAll();
            UpdateTitle();
            lblStatus.Text = "New file.";
        }

        private void Open_Click(object? sender, EventArgs e)
        {
            if (!CanContinue()) return;

            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                string json = File.ReadAllText(dialog.FileName);
                List<Expense>? loaded = JsonSerializer.Deserialize<List<Expense>>(json);
                expenses = loaded ?? new List<Expense>();
                currentFile = dialog.FileName;
                unsaved = false;
                RefreshAll();
                UpdateTitle();
                lblStatus.Text = "File opened.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object? sender, EventArgs e)
        {
            SaveFile();
        }


        private bool SaveFile()
        {
            string path = currentFile;

            if (path == "")
            {
                using SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                dialog.FileName = "expenses.json";
                if (dialog.ShowDialog() != DialogResult.OK) return false;
                path = dialog.FileName;
            }

            try
            {
                string json = JsonSerializer.Serialize(expenses,
                    new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);

                currentFile = path;
                unsaved = false;
                UpdateTitle();
                lblStatus.Text = "File saved.";
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save the file.\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Exit_Click(object? sender, EventArgs e)
        {
            Close();   
        }

        private void frmMain_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!CanContinue()) e.Cancel = true;  
        }

        private void About_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Personal Expense Tracker\nVersion 1.0\nDeveloper: Angelo Tangmuan",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}