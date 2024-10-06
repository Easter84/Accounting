namespace Accounting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            buttonsPanel = new Panel();
            addIncome = new Button();
            addBillButton = new Button();
            viewTabControl = new TabControl();
            billPage = new TabPage();
            debtorsDataGrid = new DataGridView();
            incomePage = new TabPage();
            incomeDataGrid = new DataGridView();
            ledgerPage = new TabPage();
            balanceDataGrid = new DataGridView();
            buttonsPanel.SuspendLayout();
            viewTabControl.SuspendLayout();
            billPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)debtorsDataGrid).BeginInit();
            incomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)incomeDataGrid).BeginInit();
            ledgerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)balanceDataGrid).BeginInit();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonsPanel.Controls.Add(addIncome);
            buttonsPanel.Controls.Add(addBillButton);
            buttonsPanel.Location = new Point(5, 12);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(156, 487);
            buttonsPanel.TabIndex = 0;
            // 
            // addIncome
            // 
            addIncome.Location = new Point(3, 32);
            addIncome.Name = "addIncome";
            addIncome.Size = new Size(150, 23);
            addIncome.TabIndex = 1;
            addIncome.Text = "Add Income";
            addIncome.UseVisualStyleBackColor = true;
            addIncome.Click += addIncome_Click;
            // 
            // addBillButton
            // 
            addBillButton.Location = new Point(3, 3);
            addBillButton.Name = "addBillButton";
            addBillButton.Size = new Size(150, 23);
            addBillButton.TabIndex = 0;
            addBillButton.Text = "Add Bill";
            addBillButton.UseVisualStyleBackColor = true;
            addBillButton.Click += AddBill_Click;
            // 
            // viewTabControl
            // 
            viewTabControl.Controls.Add(billPage);
            viewTabControl.Controls.Add(incomePage);
            viewTabControl.Controls.Add(ledgerPage);
            viewTabControl.Location = new Point(167, 12);
            viewTabControl.Name = "viewTabControl";
            viewTabControl.SelectedIndex = 0;
            viewTabControl.Size = new Size(808, 487);
            viewTabControl.TabIndex = 1;
            viewTabControl.Click += viewTabControl_Click;
            // 
            // billPage
            // 
            billPage.Controls.Add(debtorsDataGrid);
            billPage.Location = new Point(4, 24);
            billPage.Name = "billPage";
            billPage.Padding = new Padding(3);
            billPage.Size = new Size(800, 459);
            billPage.TabIndex = 0;
            billPage.Text = "Bills";
            billPage.UseVisualStyleBackColor = true;
            // 
            // debtorsDataGrid
            // 
            debtorsDataGrid.AllowUserToAddRows = false;
            debtorsDataGrid.AllowUserToDeleteRows = false;
            debtorsDataGrid.AllowUserToResizeColumns = false;
            debtorsDataGrid.AllowUserToResizeRows = false;
            debtorsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            debtorsDataGrid.Location = new Point(6, 6);
            debtorsDataGrid.MultiSelect = false;
            debtorsDataGrid.Name = "debtorsDataGrid";
            debtorsDataGrid.ReadOnly = true;
            debtorsDataGrid.Size = new Size(788, 447);
            debtorsDataGrid.TabIndex = 0;
            debtorsDataGrid.CellClick += debtorsDataGrid_CellClick;
            // 
            // incomePage
            // 
            incomePage.Controls.Add(incomeDataGrid);
            incomePage.Location = new Point(4, 24);
            incomePage.Name = "incomePage";
            incomePage.Padding = new Padding(3);
            incomePage.Size = new Size(800, 459);
            incomePage.TabIndex = 1;
            incomePage.Text = "Incomes";
            incomePage.UseVisualStyleBackColor = true;
            // 
            // incomeDataGrid
            // 
            incomeDataGrid.AllowUserToAddRows = false;
            incomeDataGrid.AllowUserToDeleteRows = false;
            incomeDataGrid.AllowUserToResizeColumns = false;
            incomeDataGrid.AllowUserToResizeRows = false;
            incomeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incomeDataGrid.Location = new Point(6, 6);
            incomeDataGrid.MultiSelect = false;
            incomeDataGrid.Name = "incomeDataGrid";
            incomeDataGrid.ReadOnly = true;
            incomeDataGrid.Size = new Size(788, 447);
            incomeDataGrid.TabIndex = 0;
            // 
            // ledgerPage
            // 
            ledgerPage.Controls.Add(balanceDataGrid);
            ledgerPage.Location = new Point(4, 24);
            ledgerPage.Name = "ledgerPage";
            ledgerPage.Padding = new Padding(3);
            ledgerPage.Size = new Size(800, 459);
            ledgerPage.TabIndex = 2;
            ledgerPage.Text = "Ledger";
            ledgerPage.UseVisualStyleBackColor = true;
            // 
            // balanceDataGrid
            // 
            balanceDataGrid.AllowUserToAddRows = false;
            balanceDataGrid.AllowUserToDeleteRows = false;
            balanceDataGrid.AllowUserToResizeColumns = false;
            balanceDataGrid.AllowUserToResizeRows = false;
            balanceDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            balanceDataGrid.Location = new Point(6, 6);
            balanceDataGrid.MultiSelect = false;
            balanceDataGrid.Name = "balanceDataGrid";
            balanceDataGrid.ReadOnly = true;
            balanceDataGrid.Size = new Size(788, 447);
            balanceDataGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(978, 502);
            Controls.Add(viewTabControl);
            Controls.Add(buttonsPanel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Accounts";
            buttonsPanel.ResumeLayout(false);
            viewTabControl.ResumeLayout(false);
            billPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)debtorsDataGrid).EndInit();
            incomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)incomeDataGrid).EndInit();
            ledgerPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)balanceDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel buttonsPanel;
        private Button addBillButton;
        private Button addIncome;
        private TabControl viewTabControl;
        private TabPage billPage;
        private TabPage incomePage;
        private DataGridView debtorsDataGrid;
        private TabPage ledgerPage;
        private DataGridView incomeDataGrid;
        private DataGridView balanceDataGrid;
    }
}
