using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class ShowQuestionsForm : Form
    {
        public ShowQuestionsForm()
        {
            InitializeComponent();
        }

        private void ShowQuestionsForm_Load(object sender, EventArgs e)
        {
            var allQuestions = QuestionsStorage.GetQuestions();
            foreach (var question in allQuestions)
            {
                questionsDataGridView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            var rowsCount = questionsDataGridView.Rows.Count;
            if (rowsCount == 2)
            {
                MessageBox.Show("Нельзя удалить все вопросы!");
                return;
            }

            var rows = questionsDataGridView.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Вы не выбрали строку!");
                return;
            }
            var questionText = rows[0].Cells[0].Value.ToString();
            if (questionText != null)
            {
                QuestionsStorage.Remove(questionText);
            }
            Application.Restart();
        }

        private void restoreQuestionsButton_Click(object sender, EventArgs e)
        {
            QuestionsStorage.RestoreQuestions();
            Application.Restart();
        }
    }
}
