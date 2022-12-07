using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsStorage.GetUsersResults();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.RightAnswersCount, result.Diagnose);
            }
        }

        private void resultsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
