﻿namespace GeniyIdiotWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Для продолжения, обязательно введите Ваше имя!");
            }
            else
            {
                Close();
            }
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;

            if (!Char.IsLetter(input) && input == 32)
            {
                e.Handled = true;
            }
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
