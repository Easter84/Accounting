namespace Accounting.Views
{
    partial class AddDebtorView
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
            billNameTextBox = new TextBox();
            amountDueTextBox = new TextBox();
            billNameLabel = new Label();
            amountDueLabel = new Label();
            exitButton = new Button();
            clearButton = new Button();
            submitButton = new Button();
            dueDateTimePicker = new DateTimePicker();
            dueDateLabel = new Label();
            SuspendLayout();
            // 
            // billNameTextBox
            // 
            billNameTextBox.Location = new Point(104, 12);
            billNameTextBox.Name = "billNameTextBox";
            billNameTextBox.Size = new Size(206, 23);
            billNameTextBox.TabIndex = 0;
            // 
            // amountDueTextBox
            // 
            amountDueTextBox.Location = new Point(104, 41);
            amountDueTextBox.Name = "amountDueTextBox";
            amountDueTextBox.Size = new Size(206, 23);
            amountDueTextBox.TabIndex = 1;
            // 
            // billNameLabel
            // 
            billNameLabel.AutoSize = true;
            billNameLabel.Location = new Point(12, 20);
            billNameLabel.Name = "billNameLabel";
            billNameLabel.Size = new Size(42, 15);
            billNameLabel.TabIndex = 2;
            billNameLabel.Text = "Name:";
            // 
            // amountDueLabel
            // 
            amountDueLabel.AutoSize = true;
            amountDueLabel.Location = new Point(12, 49);
            amountDueLabel.Name = "amountDueLabel";
            amountDueLabel.Size = new Size(78, 15);
            amountDueLabel.TabIndex = 3;
            amountDueLabel.Text = "Amount Due:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(235, 99);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 4;
            exitButton.Text = "Close";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(154, 99);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(73, 99);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 6;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // dueDateTimePicker
            // 
            dueDateTimePicker.Location = new Point(104, 70);
            dueDateTimePicker.Name = "dueDateTimePicker";
            dueDateTimePicker.Size = new Size(206, 23);
            dueDateTimePicker.TabIndex = 7;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(16, 76);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(58, 15);
            dueDateLabel.TabIndex = 8;
            dueDateLabel.Text = "Date Due:";
            // 
            // AddDebtorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 136);
            Controls.Add(dueDateLabel);
            Controls.Add(dueDateTimePicker);
            Controls.Add(submitButton);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(amountDueLabel);
            Controls.Add(billNameLabel);
            Controls.Add(amountDueTextBox);
            Controls.Add(billNameTextBox);
            Name = "AddDebtorView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Bill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox billNameTextBox;
        private TextBox amountDueTextBox;
        private Label billNameLabel;
        private Label amountDueLabel;
        private Button exitButton;
        private Button clearButton;
        private Button submitButton;
        private DateTimePicker dueDateTimePicker;
        private Label dueDateLabel;
    }
}