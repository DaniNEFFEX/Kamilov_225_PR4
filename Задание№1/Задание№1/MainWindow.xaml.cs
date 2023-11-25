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

namespace Задание_1
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
            if (!Double.TryParse(Number1.Text, out double N))
            { MessageBox.Show("Поле только для чисел"); }
            if (!Double.TryParse(Number2.Text, out double L))
            { MessageBox.Show("Поле только для чисел"); }
            if (N < 1 || N > 5)
            {
                MessageBox.Show("Введите другое число (1-5)");
            }
            switch (N)
            {
                case 1:
                    Answer.Text += "Длина отрезка " + L / 10 + " метров";
                    break;
                case 2:
                    Answer.Text += "Длина отрезка " + L * 1000 + " метров";
                    break;
                case 3:
                    Answer.Text += "Длина отрезка " + L * 1 + " метров";
                    break;
                case 4:
                    Answer.Text += "Длина отрезка " + L / 1000 + " метров";
                    break;
                case 5:
                    Answer.Text += "Длина отрезка " + L / 100 + " метров";
                    break;
            }
        }
    }
}
