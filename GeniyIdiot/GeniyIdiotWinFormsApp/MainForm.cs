using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private Game game;

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();

            var user = new User(welcomeForm.userNameTextBox.Text);
            game = new Game(user);

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;

            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                game.AcceptAnswer(userAnswer);

                if (game.End())
                {
                    var message = game.CalculateDiagnose();

                    MessageBox.Show(message);
                }
                else
                {
                    userAnswerTextBox.Clear();
                    ShowNextQuestion();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void showQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showQuestionsForm = new ShowQuestionsForm();
            showQuestionsForm.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addNewQuestionForm = new AddNewQuestionForm();
            addNewQuestionForm.ShowDialog();
        }
    }
}