using System;
using System.Collections.Generic;
using System.Linq;
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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number1 = 0;
        int number2 = 0;
        string operations = "";



        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 1;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 2;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 3;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 0;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 7;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 8;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 9;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 6;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 5;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = (number1 * 10) + 4;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                numberDisplay.Text = number2.ToString();

            }

        }

        private void ButtonAdding_Click(object sender, RoutedEventArgs e)
        {
            operations = "+";
            numberDisplay.Text = "0";
        }

        private void ButtonSubtracting_Click(object sender, RoutedEventArgs e)
        {
            operations = "-";
            numberDisplay.Text = "0";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            operations = "*";
            numberDisplay.Text = "0";
        }

        private void ButtonDividing_Click(object sender, RoutedEventArgs e)
        {
            operations = "/";
            numberDisplay.Text = "0";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "+")
            {
                numberDisplay.Text = (number1 + number2).ToString();
            }
            else if (operations == "-")
            {
                numberDisplay.Text = (number1 - number2).ToString();
            }
            else if (operations == "*")
            {
                numberDisplay.Text = (number1 * number2).ToString();
            }
            else if (operations == "/")
            {
                numberDisplay.Text = (number1 / number2).ToString();
            }
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
           if (operations == "")
            {
                number1 = 0;
                numberDisplay.Text = "0";

            }
           else
            {
                number2 = 0;
                numberDisplay.Text = "0";

            }
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operations = "";
            numberDisplay.Text = "0";
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = number1 / 10;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 / 10;
                numberDisplay.Text = number2.ToString();

            }
        }

        private void ButtonNegativePositive_Click(object sender, RoutedEventArgs e)
        {
            if (operations == "")
            {
                number1 = number1 * -1;
                numberDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * -1;
                numberDisplay.Text = number2.ToString();

            }
        }
    }
}
