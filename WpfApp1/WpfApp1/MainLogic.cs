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

        public UICaretaker UIC = new UICaretaker();

        public Question q;

        public List<string> DoThemFuckingQuestions ()
        {
            return new List<string>();
        }

        /*
        public void LoadQuestions (string path)
        {

            List<List<List<string>>> qaLevels = List<List<List<string>>>();

            List<List<string>> qa = new List<List<string>>();

            List<>
            qa.Add


            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string json = JsonConvert.SerializeObject(this, settings);

            System.IO.File.WriteAllText(@"C:\cs\bagilionn\WpfApp1\WpfApp1\bin\Debug\data.json", json);

            string newJson = System.IO.File.ReadAllText(@"C:\cs\bagilionn\WpfApp1\WpfApp1\bin\Debug\data.json");

            object tmp = JsonConvert.DeserializeObject(newJson, settings);

        }
        */

    }
}
