using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    class MainLogic
    {
        public FileWorker FL = new FileWorker();

        public UICaretaker UIC;

        public Question Q;

        public int Level = 0;

        public Random Rnd = new Random();

        public MainLogic (MainLogic ML)
        {
            FL = ML.FL;
            UIC = ML.UIC;
            Q = ML.Q;
            Level = ML.Level;
        }

        public MainLogic (UICaretaker uIC)
        {
            UIC = uIC;
        }

        public Question MakeQuestions ()
        {

            List<List<Question>> questions = FL.LoadQ();

            //Q = questions[0][rnd.Next(0, 2)];
            Q = questions[(Level / 5)][Rnd.Next(0, 2)];

            return Q;

        }

        public bool EvaluateQuestion(object sender)
        {
           
            if (sender.ToString() == Q.A[Q.C])
            {
                Level++;

                if (Level == 15)
                {
                    End();
                    return false;
                }

                return true;
            } else
            {
                End();
                return false;
            }

            
        }

        public void End ()
        {
            //todo
        }
        /*
        public void LoadQuestions (string path)
        {

            List<List<List<string>>> qaLevels = new List<List<List<string>>>();

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string json = JsonConvert.SerializeObject(this, settings);

            System.IO.File.WriteAllText(@"C:\cs\bagilionn\WpfApp1\WpfApp1\bin\Debug\data.json", json);

            string newJson = System.IO.File.ReadAllText(@"C:\cs\bagilionn\WpfApp1\WpfApp1\bin\Debug\data.json");

            object tmp = JsonConvert.DeserializeObject(newJson, settings);

        }
        */

    }
}
