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

namespace Задание_3
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
            if (!Double.TryParse(Number2.Text, out double X))
            { MessageBox.Show("Поле только для чисел"); }
            double R, D, L, S;
            switch (N)
            {
                case 1:
                    R = X;
                    D = 2 * R;
                    L = 2 * 3.14 * R;
                    S = 3.14 * Math.Pow(R, 2);
                    Answer.Text += "D + L + S";
                    break;
                case 2:
                    R = X / 2;
                    D = X;
                    L = 2 * 3.14 * R;
                    S = 3.14 * Math.Pow(R, 2);
                    Answer.Text += "R + L + S";
                    break;
                case 3:
                    R = X / (2 * 3.14);
                    D = 2 * R;
                    L = X;
                    S = 3.14 * Math.Pow(R, 2);
                    Answer.Text += "R + D + S";
                    break;
                case 4:
                    R = Math.Sqrt(X / 3.14);
                    D = 2 * R;
                    L = 2 * 3.14 * R;
                    S = X;
                    Answer.Text += "R + D + L";
                    break;

            }
        }
    }
}
