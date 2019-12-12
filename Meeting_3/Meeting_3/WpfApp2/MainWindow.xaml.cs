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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button bt = null;
        Random rd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
           
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void bt1_MouseEnter(object sender, MouseEventArgs e)
        {
            
            int maxX = (int)(canvas.ActualWidth - bt1.ActualWidth);
            int maxY = (int)(canvas.ActualHeight - bt1.ActualHeight);
                        
            Canvas.SetTop(bt1,rd.Next(maxY));
            Canvas.SetLeft(bt1,rd.Next(maxX));
          


        }
    }
}
