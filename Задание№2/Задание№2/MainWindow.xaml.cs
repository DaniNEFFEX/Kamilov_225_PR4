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

namespace Задание_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(Number1.Text, out int x))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (x < 20 || x > 69)
            {
                MessageBox.Show("От 20 до 69!");
            }
            switch (x / 10)
            {
                case 2:
                    Answer.Text += "двадцать ";
                    break;
                case 3:
                    Answer.Text += "тридцать ";
                    break;
                case 4:
                    Answer.Text += "сорок ";
                    break;
                case 5:
                    Answer.Text += "пятдесят ";
                    break;
                case 6:
                    Answer.Text += "шестьдесят ";
                    break;
            }
            switch (x % 10)
            {
                case 1:
                    Answer.Text += "один ";
                    break;
                case 2:
                    Answer.Text += "два ";
                    break;
                case 3:
                    Answer.Text += "три ";
                    break;
                case 4:
                    Answer.Text += "четыре ";
                    break;
                case 5:
                    Answer.Text += "пять ";
                    break;
                case 6:
                    Answer.Text += "шесть ";
                    break;
                case 7:
                    Answer.Text += "семь ";
                    break;
                case 8:
                    Answer.Text += "восемь ";
                    break;
                case 9:
                    Answer.Text += "девять ";
                    break;
            }
            switch (x % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Answer.Text += "лет.\n ";
                    break;
                case 1:
                    Answer.Text += "год.\n ";
                    break;
                case 2:
                case 3:
                case 4:
                    Answer.Text += "года.\n ";
                    break;
            }
        }
    }
}

