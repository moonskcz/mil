using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class UICaretaker
    {

        public object Button1;
        public object Button2;
        public object Button3;
        public object Button4;

        public object LabelText;


        public UICaretaker ()
        {

        }

        public UICaretaker (object but1, object but2, object but3, object but4, object labelText)
        {
            Button1 = but1;
            Button2 = but2;
            Button3 = but3;
            Button4 = but4;

            LabelText = labelText;

        }

        public void UpdateQButtons (Question Q)
        {
            //Button1.Content = Q.Q[0];
        }

    }
}
