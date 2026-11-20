#nullable disable
namespace ExpenseTracker
{
    partial class frmExpense
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblDesc = new Label();
            txtDescription = new TextBox();
            lblCat = new Label();
            cboCategory = new ComboBox();
            lblAmount = new Label();
            nudAmount = new NumericUpDown();
            grpPayment = new GroupBox();
            rdoCash = new RadioButton();
            rdoGCash = new RadioButton();
            rdoCard = new RadioButton();
            chkRecurring = new CheckBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            errProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudAmount).BeginInit();
            grpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).BeginInit();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 23);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(110, 20);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(120, 23);
            dtpDate.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(20, 58);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(70, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(110, 55);
            txtDescription.MaxLength = 50;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 23);
            txtDescription.TabIndex = 3;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(20, 93);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(58, 15);
            lblCat.TabIndex = 4;
            lblCat.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.AddRange(new object[] { "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboCategory.Location = new Point(110, 90);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(150, 23);
            cboCategory.TabIndex = 5;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 128);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 6;
            lblAmount.Text = "Amount:";
            // 
            // nudAmount
            // 
            nudAmount.DecimalPlaces = 2;
            nudAmount.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudAmount.Location = new Point(110, 125);
            nudAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudAmount.Name = "nudAmount";
            nudAmount.Size = new Size(120, 23);
            nudAmount.TabIndex = 7;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(rdoCash);
            grpPayment.Controls.Add(rdoGCash);
            grpPayment.Controls.Add(rdoCard);
            grpPayment.Location = new Point(20, 160);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(360, 55);
            grpPayment.TabIndex = 8;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment";
            // 
            // rdoCash
            // 
            rdoCash.AutoSize = true;
            rdoCash.Checked = true;
            rdoCash.Location = new Point(15, 22);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(51, 19);
            rdoCash.TabIndex = 0;
            rdoCash.TabStop = true;
            rdoCash.Text = "Cash";
            rdoCash.UseVisualStyleBackColor = true;
            // 
            // rdoGCash
            // 
            rdoGCash.AutoSize = true;
            rdoGCash.Location = new Point(120, 22);
            rdoGCash.Name = "rdoGCash";
            rdoGCash.Size = new Size(57, 19);
            rdoGCash.TabIndex = 1;
            rdoGCash.Text = "GCash";
            rdoGCash.UseVisualStyleBackColor = true;
            // 
            // rdoCard
            // 
            rdoCard.AutoSize = true;
            rdoCard.Location = new Point(230, 22);
            rdoCard.Name = "rdoCard";
            rdoCard.Size = new Size(51, 19);
            rdoCard.TabIndex = 2;
            rdoCard.Text = "Card";
            rdoCard.UseVisualStyleBackColor = true;
            // 
            // chkRecurring
            // 
            chkRecurring.AutoSize = true;
            chkRecurring.Location = new Point(20, 228);
            chkRecurring.Name = "chkRecurring";
            chkRecurring.Size = new Size(121, 19);
            chkRecurring.TabIndex = 9;
            chkRecurring.Text = "Recurring monthly";
            chkRecurring.UseVisualStyleBackColor = true;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(20, 263);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(41, 15);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(110, 260);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(250, 80);
            txtNotes.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(285, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errProvider
            // 
            errProvider.ContainerControl = this;
            // 
            // frmExpense
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(400, 420);
            Controls.Add(lblDate);
            Controls.Add(dtpDate);
            Controls.Add(lblDesc);
            Controls.Add(txtDescription);
            Controls.Add(lblCat);
            Controls.Add(cboCategory);
            Controls.Add(lblAmount);
            Controls.Add(nudAmount);
            Controls.Add(grpPayment);
            Controls.Add(chkRecurring);
            Controls.Add(lblNotes);
            Controls.Add(txtNotes);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExpense";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)nudAmount).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblDesc;
        private TextBox txtDescription;
        private Label lblCat;
        private ComboBox cboCategory;
        private Label lblAmount;
        private NumericUpDown nudAmount;
        private GroupBox grpPayment;
        private RadioButton rdoCash;
        private RadioButton rdoGCash;
        private RadioButton rdoCard;
        private CheckBox chkRecurring;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errProvider;
    }
}
