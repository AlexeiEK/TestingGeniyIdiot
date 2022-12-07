using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddNewQuestionForm : Form
    {
        public AddNewQuestionForm()
        {
            InitializeComponent();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(newQuestionAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }

            var newQuestion = new Question(newQuestionTextTextBox.Text, userAnswer);
            QuestionsStorage.Add(newQuestion);

            Close();
        }

        private void newQuestionTextTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
