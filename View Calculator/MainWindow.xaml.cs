using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppassignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        enum OPERERATION_TYPE {ADD, SUBTRACT, MULTIPLY, DIVIDE}
        private OPERERATION_TYPE currentOPtype = OPERERATION_TYPE.ADD;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_button_Click(object sender, RoutedEventArgs e)
        {
            currentOPtype = OPERERATION_TYPE.ADD;
            operation_textbox.Text = currentOPtype.ToString();
            
        }

        private void subtract_button_Click(object sender, RoutedEventArgs e)
        {
            currentOPtype = OPERERATION_TYPE.SUBTRACT;
            operation_textbox.Text = currentOPtype.ToString();
           
        }

        private void multiply_button_Click(object sender, RoutedEventArgs e)
        {
            
            currentOPtype = OPERERATION_TYPE.MULTIPLY;
            operation_textbox.Text = currentOPtype.ToString();
            
            
        }

        private void divide_button_Click(object sender, RoutedEventArgs e)
        {
            
            currentOPtype = OPERERATION_TYPE.DIVIDE;
            operation_textbox.Text = currentOPtype.ToString();
            
            
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void equal_button_Click(object sender, RoutedEventArgs e)
        {
            float firstnum = 0;
            float secondnum = 0;
            float result = 0;

            try
            {
                firstnum = float.Parse(firstnum_textbox.Text);
                secondnum = float.Parse(secondnum_textbox.Text);
                if (currentOPtype == OPERERATION_TYPE.ADD)
                {
                    result = firstnum + secondnum;
                }
                else if(currentOPtype == OPERERATION_TYPE.SUBTRACT)
                {
                    result = firstnum - secondnum;
                }
                else if (currentOPtype == OPERERATION_TYPE.MULTIPLY)
                { 
                    result = firstnum * secondnum;
                }
                else
                {
                    result = firstnum/secondnum;
                }
            }
            catch (System.FormatException)
            {
                error_textbox.Foreground = Brushes.Red;
                error_textbox.Content = "system.formatexception occurred";
            }
            catch (System.AccessViolationException)
            {
                error_textbox.Foreground = Brushes.Red;
                error_textbox.Content = "system.accessviolation occurred";
            }
            catch (System.OverflowException)
            {
                error_textbox.Foreground = Brushes.Red;
                error_textbox.Content = "system.overflowexception occurred";
            }
            Console.WriteLine("Result =" + result.ToString());
            result_textbox.Text = result.ToString();
        }
    }
}
