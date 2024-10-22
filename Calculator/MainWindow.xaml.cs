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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonAdd.Click += ButtonAdd_Click;
            ButtonMinus.Click += ButtonMinus_Click;
            ButtonSub.Click += ButtonSub_Click;
            ButtonDiv.Click += ButtonDiv_Click;
            ButtonClear.Click += ButtonClear_Click;
        }
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBoxNum1.Text = "";
            TextBoxNum2.Text = "";
            TextBoxTotal.Text = "";
            TextBoxNum1.Focus();
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            int tot = num1 / num2;

            TextBoxTotal.Text = tot.ToString();
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            int tot = num1 * num2;

            TextBoxTotal.Text = tot.ToString();
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            int tot = num1 - num2;

            TextBoxTotal.Text = tot.ToString();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            int num1 = int.Parse(TextBoxNum1.Text);
            int num2 = int.Parse(TextBoxNum2.Text);

            int tot = num1 + num2;

            TextBoxTotal.Text = tot.ToString();

        }
    }
}