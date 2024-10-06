namespace Accounting.Views
{
    partial class PayBill
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
            compNameLabel = new Label();
            comNameTxtBx = new TextBox();
            dueDateLabel = new Label();
            dueDateTxtBx = new TextBox();
            amountDueLabel = new Label();
            amountDueTxtBx = new TextBox();
            payButton = new Button();
            cancelButton = new Button();
            resetButton = new Button();
            SuspendLayout();
            // 
            // compNameLabel
            // 
            compNameLabel.AutoSize = true;
            compNameLabel.Location = new Point(12, 9);
            compNameLabel.Name = "compNameLabel";
            compNameLabel.Size = new Size(62, 15);
            compNameLabel.TabIndex = 0;
            compNameLabel.Text = "Company:";
            // 
            // comNameTxtBx
            // 
            comNameTxtBx.Location = new Point(96, 6);
            comNameTxtBx.Name = "comNameTxtBx";
            comNameTxtBx.ReadOnly = true;
            comNameTxtBx.Size = new Size(186, 23);
            comNameTxtBx.TabIndex = 1;
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.Location = new Point(12, 43);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new Size(58, 15);
            dueDateLabel.TabIndex = 2;
            dueDateLabel.Text = "Due Date:";
            // 
            // dueDateTxtBx
            // 
            dueDateTxtBx.Location = new Point(96, 40);
            dueDateTxtBx.Name = "dueDateTxtBx";
            dueDateTxtBx.ReadOnly = true;
            dueDateTxtBx.Size = new Size(186, 23);
            dueDateTxtBx.TabIndex = 3;
            // 
            // amountDueLabel
            // 
            amountDueLabel.AutoSize = true;
            amountDueLabel.Location = new Point(12, 77);
            amountDueLabel.Name = "amountDueLabel";
            amountDueLabel.Size = new Size(78, 15);
            amountDueLabel.TabIndex = 4;
            amountDueLabel.Text = "Amount Due:";
            // 
            // amountDueTxtBx
            // 
            amountDueTxtBx.Location = new Point(96, 74);
            amountDueTxtBx.Name = "amountDueTxtBx";
            amountDueTxtBx.ReadOnly = true;
            amountDueTxtBx.Size = new Size(186, 23);
            amountDueTxtBx.TabIndex = 5;
            // 
            // payButton
            // 
            payButton.Location = new Point(207, 103);
            payButton.Name = "payButton";
            payButton.Size = new Size(75, 23);
            payButton.TabIndex = 6;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(126, 103);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(45, 103);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 8;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // PayBill
            // 
            AcceptButton = payButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 153);
            Controls.Add(resetButton);
            Controls.Add(cancelButton);
            Controls.Add(payButton);
            Controls.Add(amountDueTxtBx);
            Controls.Add(amountDueLabel);
            Controls.Add(dueDateTxtBx);
            Controls.Add(dueDateLabel);
            Controls.Add(comNameTxtBx);
            Controls.Add(compNameLabel);
            Name = "PayBill";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PayBill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label compNameLabel;
        private TextBox comNameTxtBx;
        private Label dueDateLabel;
        private TextBox dueDateTxtBx;
        private Label amountDueLabel;
        private TextBox amountDueTxtBx;
        private Button payButton;
        private Button cancelButton;
        private Button resetButton;
    }
}