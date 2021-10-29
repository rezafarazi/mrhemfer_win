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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            List<string> uu = new List<string>();
            uu.Add("ﭘﻴﺸﮕﻔﺘﺎر");
            uu.Add("بخش اول");
            uu.Add("بخش دوم");
            uu.Add("بخش سوم");
            uu.Add("بخش چهارم");
            uu.Add("بخش پنجم");
            uu.Add("بخش ششم");
            uu.Add("بخش هفتم");
            uu.Add("خروج");
            int x = -420;
            for (int a = 0; a < uu.Count; a++)
            {
                Button btns = new Button();
                btns.Content = uu[a].ToString();
                btns.Width = 250;
                btns.Height = 50;
                btns.Margin = new Thickness(0, x, 0, 0);
                x += 110;
                qfc.Children.Add(btns);
                btns.Click += new RoutedEventHandler(ty);
                btns.Background = new ImageBrush(new BitmapImage(new Uri(System.Windows.Forms.Application.StartupPath+@"\img\tot.png")));
                btns.BorderBrush = Brushes.Transparent;
            }
        }
        string ggg = "";
        public void ty(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Content.ToString())
            {
                case "ﭘﻴﺸﮕﻔﺘﺎر":
                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\p.txt");
                    break;
                case "بخش اول":

                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\1.txt");
                    break;
                case "بخش دوم":
                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\2.txt");
                    break;
                case "بخش سوم":
                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\3.txt");
                    break;
                case "بخش چهارم":
                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\4.txt");
                    break;
                case "بخش پنجم":

                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\5.txt");
                    break;
                case "بخش ششم":

                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\6.txt");
                    break;
                case "بخش هفتم":

                    ggg = System.IO.File.ReadAllText(System.Windows.Forms.Application.StartupPath + "\\matns\\7.txt");
                    break;
                default:
                    this.Close();
                    break;
            }
            mats mu = new mats();
            mu.qfr.Text=ggg;
            mu.Closing += new System.ComponentModel.CancelEventHandler(oi);
            
            this.Hide();
            mu.Show();
        }

        public void oi(object sender, EventArgs e)
        {
            try
            {
                this.Show();
            }
            catch
            {
            }
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void TextBox_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
