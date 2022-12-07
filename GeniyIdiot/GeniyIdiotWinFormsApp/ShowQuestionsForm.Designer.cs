namespace GeniyIdiotWinFormsApp
{
    partial class ShowQuestionsForm
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
            this.questionsDataGridView = new System.Windows.Forms.DataGridView();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.restoreQuestionsButton = new System.Windows.Forms.Button();
            this.questionTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsDataGridView
            // 
            this.questionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionTextColumn,
            this.questionAnswerColumn});
            this.questionsDataGridView.Location = new System.Drawing.Point(8, 29);
            this.questionsDataGridView.MultiSelect = false;
            this.questionsDataGridView.Name = "questionsDataGridView";
            this.questionsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.questionsDataGridView.RowTemplate.Height = 25;
            this.questionsDataGridView.Size = new System.Drawing.Size(661, 221);
            this.questionsDataGridView.TabIndex = 0;
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Location = new System.Drawing.Point(303, 0);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(180, 23);
            this.removeQuestionButton.TabIndex = 1;
            this.removeQuestionButton.Text = "Удалить данный вопрос";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // restoreQuestionsButton
            // 
            this.restoreQuestionsButton.Location = new System.Drawing.Point(489, 0);
            this.restoreQuestionsButton.Name = "restoreQuestionsButton";
            this.restoreQuestionsButton.Size = new System.Drawing.Size(180, 23);
            this.restoreQuestionsButton.TabIndex = 2;
            this.restoreQuestionsButton.Text = "Восстановить вопросы";
            this.restoreQuestionsButton.UseVisualStyleBackColor = true;
            this.restoreQuestionsButton.Click += new System.EventHandler(this.restoreQuestionsButton_Click);
            // 
            // questionTextColumn
            // 
            this.questionTextColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.questionTextColumn.HeaderText = "Текст вопроса";
            this.questionTextColumn.Name = "questionTextColumn";
            this.questionTextColumn.Width = 123;
            // 
            // questionAnswerColumn
            // 
            this.questionAnswerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.questionAnswerColumn.HeaderText = "Ответ";
            this.questionAnswerColumn.Name = "questionAnswerColumn";
            this.questionAnswerColumn.Width = 70;
            // 
            // ShowQuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 255);
            this.Controls.Add(this.restoreQuestionsButton);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.questionsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "ShowQuestionsForm";
            this.Text = "Вопросы викторины";
            this.Load += new System.EventHandler(this.ShowQuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView questionsDataGridView;
        private Button removeQuestionButton;
        private Button restoreQuestionsButton;
        private DataGridViewTextBoxColumn questionTextColumn;
        private DataGridViewTextBoxColumn questionAnswerColumn;
    }
}