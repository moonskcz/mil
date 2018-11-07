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
    /// Interakční logika pro Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private UICaretaker UIC;

        private MainLogic MC;

        private Frame frame;
        public Page2()
        {
            UIC = new UICaretaker(but1, but2, but3, but4, label1);

            InitializeComponent();

            MC = new MainLogic(UIC);

        }

        public Page2(Frame frame) : this()
        {
            this.frame = frame;
        }

        public void UpdateButtons()
        {

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {

        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page3(frame));
        }*/
    }
}
