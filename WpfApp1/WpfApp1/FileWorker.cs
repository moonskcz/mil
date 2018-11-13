using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FileWorker
    {
        private string path = "";

        public FileWorker ()
        {

        }

        public FileWorker (string inpPath)
        {
            path = inpPath;
        }

        public List<List<Question>> LoadQ ()
        {
            string newJson = System.IO.File.ReadAllText(@"C:\cs\bagilionn\WpfApp1\WpfApp1\bin\Debug\data.json");

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            List<List<Question>> tmp = JsonConvert.DeserializeObject <List<List<Question>>> (newJson);

            return tmp;
        }

        public string LoadGame ()
        {
            return "dead";
        }

        public void SaveGame ()
        {

            List<List<Question>> qTier = new List<List<Question>>();

            List<Question> questions = new List<Question>();

            Question tmp = new Question();
            tmp.Q = "qqqqqq";
            List<string> ttmp = new List<string>();
            ttmp.Add("aaa");
            ttmp.Add("slwfwk hwkfh kjhef AAAA2");
            ttmp.Add("aa2");
            ttmp.Add("aa3");

            Random rnd = new Random();
            tmp.C = rnd.Next(0, 4);
            tmp.A = ttmp;

            questions.Add(tmp);
            questions.Add(tmp);
            questions.Add(tmp);

            qTier.Add(questions);
            qTier.Add(questions);
            qTier.Add(questions);

            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string json = JsonConvert.SerializeObject(qTier);

            System.IO.File.WriteAllText(@"C:\cs\bagilionn\WpfApp1\WpfApp1\bin\Debug\data.json", json);

        }

    }
}
