using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TienDinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageSource defaultSrc;
        public MainWindow()
        {
            InitializeComponent();
            CGlobal.imgSrc = defaultSrc =  ((ImageBrush)mainWindow.Background).ImageSource;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Application.Current.Shutdown();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ButtonState == MouseButtonState.Pressed)
                DragMove();
        }

        private void imgControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Image imgControlSelect = (Image)sender;
            if (imgControlSelect.Tag.ToString() == "winMinimize")
            {
                WindowState = System.Windows.WindowState.Minimized;
            }
            else if (imgControlSelect.Tag.ToString() == "winMaximize")
            { 
                if(WindowState == System.Windows.WindowState.Maximized)
                    WindowState = System.Windows.WindowState.Normal;
                else
                    WindowState = System.Windows.WindowState.Maximized;
            }
            else if (imgControlSelect.Tag.ToString() == "winClose")
            {
                Application.Current.Shutdown();
            }
        }

        Image imgSelected = new Image();
        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgSelected.Opacity = 1;
            imgSelected = (Image)sender;
            imgSelected.Opacity = 0.5;
            CGlobal.imgSrc = imgSelected.Source;
        }

        private void imgView_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            frmViewImage frm = new frmViewImage();
            frm.ShowDialog();
        }

        private void imgSetBG_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgBG.ImageSource =  CGlobal.imgSrc;
        }

        private void imgRestore_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            imgBG.ImageSource = defaultSrc;
        }
    }
}
