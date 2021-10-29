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
using System.Windows.Shapes;

namespace mrhefer
{
    /// <summary>
    /// Interaction logic for mats.xaml
    /// </summary>
    public partial class mats : Window
    {
        public mats()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider st = (Slider)sender;
            qfr.FontSize = st.Value+20;
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
        int font = 16;
        private void Window_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                font += 5;
            }
            if (e.Key == Key.Down)
            {
                font -= (font>5)?5:0;
            }
            if (e.Key == Key.Back)
            {
                Close();
            }
            qfr.FontSize = font;
        }
    }
}
