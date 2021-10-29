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
using System.Windows.Threading;

namespace mrhefer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer a;
        int b = 0;
        public MainWindow()
        {
            InitializeComponent();
            a = new DispatcherTimer();
            a.Tick += new EventHandler(turk);
            a.Interval = TimeSpan.FromSeconds(1);
            a.Start();
        }
        public void turk(object sender, EventArgs e)
        {
            b++;
            if (b == 5)
            {
                Menu i = new Menu();
                i.Closing += new System.ComponentModel.CancelEventHandler(close);
                i.Show();
                
                this.Hide();
                a.Stop();
            }
        }
        public void close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
