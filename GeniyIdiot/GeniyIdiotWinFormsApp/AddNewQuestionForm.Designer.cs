namespace GeniyIdiotWinFormsApp
{
    partial class AddNewQuestionForm
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
            this.newQuestionTextLabel = new System.Windows.Forms.Label();
            this.newQuestionAnswerLabel = new System.Windows.Forms.Label();
            this.newQuestionTextTextBox = new System.Windows.Forms.TextBox();
            this.newQuestionAnswerTextBox = new System.Windows.Forms.TextBox();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newQuestionTextLabel
            // 
            this.newQuestionTextLabel.AutoSize = true;
            this.newQuestionTextLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newQuestionTextLabel.Location = new System.Drawing.Point(12, 20);
            this.newQuestionTextLabel.Name = "newQuestionTextLabel";
            this.newQuestionTextLabel.Size = new System.Drawing.Size(175, 21);
            this.newQuestionTextLabel.TabIndex = 0;
            this.newQuestionTextLabel.Text = "Текст нового вопроса";
            // 
            // newQuestionAnswerLabel
            // 
            this.newQuestionAnswerLabel.AutoSize = true;
            this.newQuestionAnswerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newQuestionAnswerLabel.Location = new System.Drawing.Point(12, 57);
            this.newQuestionAnswerLabel.Name = "newQuestionAnswerLabel";
            this.newQuestionAnswerLabel.Size = new System.Drawing.Size(196, 21);
            this.newQuestionAnswerLabel.TabIndex = 1;
            this.newQuestionAnswerLabel.Text = "Ответ на данный вопрос";
            // 
            // newQuestionTextTextBox
            // 
            this.newQuestionTextTextBox.Location = new System.Drawing.Point(248, 18);
            this.newQuestionTextTextBox.Name = "newQuestionTextTextBox";
            this.newQuestionTextTextBox.Size = new System.Drawing.Size(347, 23);
            this.newQuestionTextTextBox.TabIndex = 2;
            this.newQuestionTextTextBox.TextChanged += new System.EventHandler(this.newQuestionTextTextBox_TextChanged);
            // 
            // newQuestionAnswerTextBox
            // 
            this.newQuestionAnswerTextBox.Location = new System.Drawing.Point(248, 55);
            this.newQuestionAnswerTextBox.Name = "newQuestionAnswerTextBox";
            this.newQuestionAnswerTextBox.Size = new System.Drawing.Size(100, 23);
            this.newQuestionAnswerTextBox.TabIndex = 3;
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNewQuestionButton.Location = new System.Drawing.Point(12, 87);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(192, 34);
            this.addNewQuestionButton.TabIndex = 4;
            this.addNewQuestionButton.Text = "Добавить";
            this.addNewQuestionButton.UseVisualStyleBackColor = true;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addNewQuestionButton_Click);
            // 
            // AddNewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 133);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.newQuestionAnswerTextBox);
            this.Controls.Add(this.newQuestionTextTextBox);
            this.Controls.Add(this.newQuestionAnswerLabel);
            this.Controls.Add(this.newQuestionTextLabel);
            this.Name = "AddNewQuestionForm";
            this.Text = "Добавить этот вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label newQuestionTextLabel;
        private Label newQuestionAnswerLabel;
        private TextBox newQuestionTextTextBox;
        private TextBox newQuestionAnswerTextBox;
        private Button addNewQuestionButton;
    }
}