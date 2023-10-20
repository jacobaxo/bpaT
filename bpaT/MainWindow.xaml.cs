using System.Windows;
using System.Windows.Controls;

namespace WpfQuizApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int score = 0;

            if (Q1Option1.IsChecked == true)
            {
                score++;
            }
            if (Q2Option3.IsChecked == true)
            {
                score++;
            }
            if (Q3Option1.IsChecked == true)
            {
                score++;
            }

            MessageBox.Show("Your score: " + score + "/3");
        }
    }
}