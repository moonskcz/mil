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

        private Question Q;

        private int C;

        private Frame frame;
        public Page2()
        {
            UIC = new UICaretaker(but1, but2, but3, but4, label1);

            InitializeComponent();

            MC = new MainLogic(UIC);

            Q = MC.MakeQuestions();

            UpdateButtons();

        }

        public Page2(Frame frame) : this()
        {
            this.frame = frame;
        }

        public void UpdateButtons()
        {
            but1.Content = Q.A[0];
            but2.Content = Q.A[1];
            but3.Content = Q.A[2];
            but4.Content = Q.A[3];
            label1.Content = Q.Q;
            label2.Content = MC.Level;
            C = Q.C;
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            Button content = sender as Button;
            
            if (MC.EvaluateQuestion(content.Content))
            {
                Q = MC.MakeQuestions();
                UpdateButtons();
            } else
            {
                frame.Navigate(new Page3(frame));
            }
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Page3(frame));
        }*/
    }
}
