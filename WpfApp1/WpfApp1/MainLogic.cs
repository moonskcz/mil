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

        public List<string> MakeQuestions ()
        {
            Random rnd = new Random();

            List<List<Question>> questions = FL.LoadQ();

            Q = questions[((Level / 5) + 1)][rnd.Next(0, 2)];

            return new List<string>();

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
