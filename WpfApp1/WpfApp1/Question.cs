﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Question
    {

        public string Q;
        public List<string> A = new List<string>();

        public Question ()
        {

        }

        public Question (string q, List<string> a)
        {
            Q = q;
            A = a;
        }

    }
}
