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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DockPanel docPanel;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            docPanel = new DockPanel();
            docPanel.LastChildFill = true;

            Thickness th = new Thickness(0);

            Button bt1 = new Button() { Content = "1", BorderThickness=th,   Foreground=Brushes.White,   Background= Brushes.Black };
            Button bt2 = new Button() { Content = "2", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt3 = new Button() { Content = "3", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt4 = new Button() { Content = "4", BorderThickness = th, Background = Brushes.White };
            Button bt5 = new Button() { Content = "5", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt6 = new Button() { Content = "6", BorderThickness = th, Background = Brushes.White };
            Button bt7 = new Button() { Content = "7", BorderThickness = th, Background = Brushes.White };
            Button bt8 = new Button() { Content = "8", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt9 = new Button() { Content = "9", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };

            Button bt10 = new Button() {Content = "10", BorderThickness = th, Background = Brushes.White };
            Button bt11 = new Button() {Content = "11", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt12 = new Button() {Content = "12", BorderThickness = th, Background = Brushes.White };
            Button bt13 = new Button() {Content = "13", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt14 = new Button() {Content = "14", BorderThickness = th, Background = Brushes.White };
            Button bt15 = new Button() {Content = "15", BorderThickness = th, Foreground = Brushes.White,  Background = Brushes.Black };
            Button bt16 = new Button() {Content = "16", BorderThickness = th, Background = Brushes.White };
            Button bt17 = new Button() {Content = "17", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt18 = new Button() {Content = "18", BorderThickness = th, Background = Brushes.White };
            Button bt19 = new Button() {Content = "19", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt20 = new Button() { Content = "20", BorderThickness = th, Background = Brushes.White };
            Button bt21 = new Button() { Content = "21", BorderThickness = th, Foreground = Brushes.White, Background = Brushes.Black };
            Button bt22 = new Button() { BorderThickness = th, Background = Brushes.White };


            docPanel.Children.Add(bt1);
            docPanel.Children.Add(bt2);
            docPanel.Children.Add(bt3);
            docPanel.Children.Add(bt4);
            docPanel.Children.Add(bt5);
            docPanel.Children.Add(bt6);
            docPanel.Children.Add(bt7);
            docPanel.Children.Add(bt8);
            docPanel.Children.Add(bt9);
            docPanel.Children.Add(bt10);
            docPanel.Children.Add(bt11);
            docPanel.Children.Add(bt12);
            docPanel.Children.Add(bt13);
            docPanel.Children.Add(bt14);
            docPanel.Children.Add(bt15);
            docPanel.Children.Add(bt16);
            docPanel.Children.Add(bt17);
            docPanel.Children.Add(bt18);
            docPanel.Children.Add(bt19);
            docPanel.Children.Add(bt20);
            docPanel.Children.Add(bt21);
            docPanel.Children.Add(bt22);

            DockPanel.SetDock(bt1,Dock.Left);
            DockPanel.SetDock(bt2,Dock.Bottom);
            DockPanel.SetDock(bt3,Dock.Right);
            DockPanel.SetDock(bt4,Dock.Left);
            DockPanel.SetDock(bt5,Dock.Top);
            DockPanel.SetDock(bt6,Dock.Bottom);
            DockPanel.SetDock(bt7,Dock.Right);
            DockPanel.SetDock(bt8,Dock.Left);
            DockPanel.SetDock(bt9,Dock.Bottom);
            DockPanel.SetDock(bt10,Dock.Top);
            DockPanel.SetDock(bt11,Dock.Right);
            DockPanel.SetDock(bt12,Dock.Left);
            DockPanel.SetDock(bt13,Dock.Top);
            DockPanel.SetDock(bt14,Dock.Bottom);
            DockPanel.SetDock(bt15,Dock.Left);
            DockPanel.SetDock(bt16,Dock.Right);
            DockPanel.SetDock(bt17,Dock.Bottom);
            DockPanel.SetDock(bt18,Dock.Top);
            DockPanel.SetDock(bt19,Dock.Right);
            DockPanel.SetDock(bt20,Dock.Left);
            DockPanel.SetDock(bt21,Dock.Top);
           // DockPanel.SetDock(bt20,Dock.Top);




            this.Content = docPanel;


        }

       
    }
}
