#nullable disable
namespace ExpenseTracker
{
    partial class frmMain
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
            menu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            expenseToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolbar = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSave = new ToolStripButton();
            pnlFilter = new Panel();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkDateRange = new CheckBox();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            dgv = new DataGridView();
            pnlSummary = new Panel();
            lblSummary = new Label();
            lblBudget = new Label();
            nudBudget = new NumericUpDown();
            lblRemaining = new Label();
            status = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblCount = new ToolStripStatusLabel();
            lblClock = new ToolStripStatusLabel();
            tmrClock = new System.Windows.Forms.Timer(components);
            menu.SuspendLayout();
            toolbar.SuspendLayout();
            pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).BeginInit();
            status.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, expenseToolStripMenuItem, helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(884, 24);
            menu.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(155, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += New_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(155, 22);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += Open_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(155, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += Save_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(152, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(155, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += Exit_Click;
            // 
            // expenseToolStripMenuItem
            // 
            expenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            expenseToolStripMenuItem.Name = "expenseToolStripMenuItem";
            expenseToolStripMenuItem.Size = new Size(62, 20);
            expenseToolStripMenuItem.Text = "&Expense";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(107, 22);
            addToolStripMenuItem.Text = "&Add";
            addToolStripMenuItem.Click += Add_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += Edit_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += Delete_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += About_Click;
            // 
            // toolbar
            // 
            toolbar.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbDelete, toolStripSeparator2, tsbSave });
            toolbar.Location = new Point(0, 24);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(884, 25);
            toolbar.TabIndex = 3;
            // 
            // tsbAdd
            // 
            tsbAdd.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(33, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += Add_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(31, 22);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += Edit_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(44, 22);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += Delete_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(35, 22);
            tsbSave.Text = "Save";
            tsbSave.Click += Save_Click;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.LightSteelBlue;
            pnlFilter.Controls.Add(lblCategory);
            pnlFilter.Controls.Add(cboCategory);
            pnlFilter.Controls.Add(lblSearch);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(chkDateRange);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(0, 49);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(884, 75);
            pnlFilter.TabIndex = 2;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(10, 14);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.Items.AddRange(new object[] { "All", "Food", "Transportation", "Bills", "School", "Entertainment", "Others" });
            cboCategory.Location = new Point(75, 10);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(150, 23);
            cboCategory.TabIndex = 1;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(250, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(305, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // chkDateRange
            // 
            chkDateRange.AutoSize = true;
            chkDateRange.Location = new Point(10, 44);
            chkDateRange.Name = "chkDateRange";
            chkDateRange.Size = new Size(83, 19);
            chkDateRange.TabIndex = 4;
            chkDateRange.Text = "Date range";
            chkDateRange.UseVisualStyleBackColor = true;
            chkDateRange.CheckedChanged += chkDateRange_CheckedChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Enabled = false;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(110, 42);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(110, 23);
            dtpFrom.TabIndex = 5;
            dtpFrom.ValueChanged += dtpFilter_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(228, 46);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(17, 15);
            lblTo.TabIndex = 6;
            lblTo.Text = "to";
            // 
            // dtpTo
            // 
            dtpTo.Enabled = false;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(250, 42);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(110, 23);
            dtpTo.TabIndex = 7;
            dtpTo.ValueChanged += dtpFilter_ValueChanged;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 124);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(884, 340);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.LightYellow;
            pnlSummary.Controls.Add(lblSummary);
            pnlSummary.Controls.Add(lblBudget);
            pnlSummary.Controls.Add(nudBudget);
            pnlSummary.Controls.Add(lblRemaining);
            pnlSummary.Dock = DockStyle.Bottom;
            pnlSummary.Location = new Point(0, 464);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(884, 75);
            pnlSummary.TabIndex = 1;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(10, 10);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(0, 15);
            lblSummary.TabIndex = 0;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(10, 44);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(93, 15);
            lblBudget.TabIndex = 1;
            lblBudget.Text = "Monthly budget:";
            // 
            // nudBudget
            // 
            nudBudget.DecimalPlaces = 2;
            nudBudget.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudBudget.Location = new Point(110, 40);
            nudBudget.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudBudget.Name = "nudBudget";
            nudBudget.Size = new Size(110, 23);
            nudBudget.TabIndex = 2;
            nudBudget.ThousandsSeparator = true;
            nudBudget.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            nudBudget.ValueChanged += nudBudget_ValueChanged;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemaining.Location = new Point(240, 44);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(0, 15);
            lblRemaining.TabIndex = 3;
            // 
            // status
            // 
            status.Items.AddRange(new ToolStripItem[] { lblStatus, lblCount, lblClock });
            status.Location = new Point(0, 539);
            status.Name = "status";
            status.Size = new Size(884, 22);
            status.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(782, 17);
            lblStatus.Spring = true;
            lblStatus.Text = "Ready.";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(60, 17);
            lblCount.Text = "0 records";
            // 
            // lblClock
            // 
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(27, 17);
            lblClock.Text = "";
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(884, 561);
            Controls.Add(dgv);
            Controls.Add(pnlSummary);
            Controls.Add(pnlFilter);
            Controls.Add(toolbar);
            Controls.Add(menu);
            Controls.Add(status);
            MainMenuStrip = menu;
            MinimumSize = new Size(750, 450);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense Tracker";
            FormClosing += frmMain_FormClosing;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBudget).EndInit();
            status.ResumeLayout(false);
            status.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem expenseToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolbar;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbSave;
        private Panel pnlFilter;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblSearch;
        private TextBox txtSearch;
        private CheckBox chkDateRange;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private DataGridView dgv;
        private Panel pnlSummary;
        private Label lblSummary;
        private Label lblBudget;
        private NumericUpDown nudBudget;
        private Label lblRemaining;
        private StatusStrip status;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblCount;
        private ToolStripStatusLabel lblClock;
        private System.Windows.Forms.Timer tmrClock;
    }
}
