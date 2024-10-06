namespace Accounting.Views
{
    partial class AddIncomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            incomeNameLabel = new Label();
            incAmntLabel = new Label();
            IncNameTextBox = new TextBox();
            IncAmntTextBox = new TextBox();
            closeButton = new Button();
            clearButton = new Button();
            submitButton = new Button();
            payDateCalendar = new MonthCalendar();
            SuspendLayout();
            // 
            // incomeNameLabel
            // 
            incomeNameLabel.AutoSize = true;
            incomeNameLabel.Location = new Point(7, 17);
            incomeNameLabel.Name = "incomeNameLabel";
            incomeNameLabel.Size = new Size(62, 15);
            incomeNameLabel.TabIndex = 0;
            incomeNameLabel.Text = "Company:";
            // 
            // incAmntLabel
            // 
            incAmntLabel.AutoSize = true;
            incAmntLabel.Location = new Point(7, 43);
            incAmntLabel.Name = "incAmntLabel";
            incAmntLabel.Size = new Size(54, 15);
            incAmntLabel.TabIndex = 1;
            incAmntLabel.Text = "Amount:";
            // 
            // IncNameTextBox
            // 
            IncNameTextBox.Location = new Point(75, 9);
            IncNameTextBox.Name = "IncNameTextBox";
            IncNameTextBox.Size = new Size(183, 23);
            IncNameTextBox.TabIndex = 2;
            // 
            // IncAmntTextBox
            // 
            IncAmntTextBox.Location = new Point(75, 40);
            IncAmntTextBox.Name = "IncAmntTextBox";
            IncAmntTextBox.Size = new Size(183, 23);
            IncAmntTextBox.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(412, 183);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(331, 183);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(250, 183);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // payDateCalendar
            // 
            payDateCalendar.Location = new Point(270, 9);
            payDateCalendar.Name = "payDateCalendar";
            payDateCalendar.TabIndex = 7;
            // 
            // AddIncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 214);
            Controls.Add(payDateCalendar);
            Controls.Add(submitButton);
            Controls.Add(clearButton);
            Controls.Add(closeButton);
            Controls.Add(IncAmntTextBox);
            Controls.Add(IncNameTextBox);
            Controls.Add(incAmntLabel);
            Controls.Add(incomeNameLabel);
            Name = "AddIncomeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddIncomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label incomeNameLabel;
        private Label incAmntLabel;
        private TextBox IncNameTextBox;
        private TextBox IncAmntTextBox;
        private Button closeButton;
        private Button clearButton;
        private Button submitButton;
        private MonthCalendar payDateCalendar;
    }
}