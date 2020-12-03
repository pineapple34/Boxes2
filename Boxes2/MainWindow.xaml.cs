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

namespace Boxes2
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
            switch (fontColor.SelectedIndex)
            {
                case 0:
                    output.Foreground = new SolidColorBrush(Colors.Red);
                    break;
                case 1:
                    output.Foreground = new SolidColorBrush(Colors.Green);
                    break;
                case 2:
                    output.Foreground = new SolidColorBrush(Colors.Blue);
                    break;
            }

            output.Content = day.Text + " " + month.Text + " " + year.Text + " года";
        }
    }
}
