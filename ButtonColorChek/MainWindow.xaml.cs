using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
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

        private void TextBox_MouseRightButtonDown1(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                button1.Width = 0;
                button1.Height = 0;
                Title += " ->  1  <- ";
            }
        }
        private void TextBox_MouseRightButtonDown2(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                button2.Width = 0;
                button2.Height = 0;
                Title += " ->  2  <- ";
            }
        }

        private void TextBox_MouseRightButtonDown3(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                button3.Width = 0;
                button3.Height = 0;
                Title += " ->  3  <- ";
            }
        }

        private void TextBox_MouseRightButtonDown4(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                button4.Width = 0;
                button4.Height = 0;
                Title += " ->  4  <- ";
            }
        }

        private void TextBox_MouseRightButtonDown5(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                button5.Width = 0;
                button5.Height = 0;
                Title += " ->  5  <- ";
            }
        }
        private void TextBox_MouseRightButtonDown6(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                button6.Width = 0;
                button6.Height = 0;
                Title += " ->  6  <- ";
            }
        }



        Random r = new Random();
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button1.Background = brush;
            MessageBox.Show($"Rəng tonun codu-> {brush.ToString()}");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button2.Background = brush;
            MessageBox.Show($"Rəng tonun codu-> {brush.ToString()}");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button3.Background = brush;
            MessageBox.Show($"Rəng tonun codu-> {brush.ToString()}");
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button4.Background = brush;
            MessageBox.Show($"Rəng tonun codu-> {brush.ToString()}");
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button5.Background = brush;
            MessageBox.Show($"Rəng tonun codu-> {brush.ToString()}");
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            button6.Background = brush;
            MessageBox.Show($"Rəng tonun codu-> {brush.ToString()}");
        }
    }
}




