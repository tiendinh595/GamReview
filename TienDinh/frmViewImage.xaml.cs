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
using System.Windows.Shapes;

namespace TienDinh
{
    /// <summary>
    /// Interaction logic for frmViewImage.xaml
    /// </summary>
    public partial class frmViewImage : Window
    {
        public frmViewImage()
        {
            InitializeComponent();
            viewform.Background = new ImageBrush(CGlobal.imgSrc);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Close();
        }
    }
}
