using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void evaluateButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(inputTextBox.Text, out int input1);

            if (!numberGenerated)
            {


                Random rnd = new Random();
                rnd.Next(1, 100);
                numberGenerated = true;
            }
            else
            {


                if (input1 == rnd.Next(1, 100))
                {
                    output1TextBox.Text = "Congrats u guessed the number";
                }
                else if (input1 > rnd.Next(1, 100))
                {
                    output1TextBox.Text = "Guess lower";
                }
                else
                {
                    output1TextBox.Text = "Guess higher";
                }

            }
            



        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void endButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}