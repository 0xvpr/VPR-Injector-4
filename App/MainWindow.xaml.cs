using System;
using System.Windows;
using System.Windows.Input;
using System.Diagnostics;
using System.Runtime.InteropServices;
using FormWindowState = System.Windows.Forms.FormWindowState;

namespace Testing
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

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (e.GetPosition(this).X < 200 || e.GetPosition(this).Y < 75)
            {
                DragMove();
            }
        }

        private void ShutdownApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MinimizeApp(object sender, RoutedEventArgs e)
        {
            WindowState = (WindowState)FormWindowState.Minimized;
        }
    }
}
