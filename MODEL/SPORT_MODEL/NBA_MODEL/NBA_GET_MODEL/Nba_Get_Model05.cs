

namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model05
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Conference
        {
            public string name { get; set; } = string.Empty;
            public int rank { get; set; }
            public int win { get; set; }
            public int loss { get; set; }
        }

        public class Division
        {
            public string name { get; set; } = string.Empty;
            public int rank { get; set; }
            public int win { get; set; }
            public int loss { get; set; }
            public string gamesBehind { get; set; } = string.Empty;
        }

        public class Loss
        {
            public int home { get; set; }
            public int away { get; set; }
            public int total { get; set; }
            public string percentage { get; set; } = string.Empty;
            public int lastTen { get; set; }
        }

        public class Parameters
        {
            public string league { get; set; } = string.Empty;
            public string season { get; set; } = string.Empty;
        }

        public class Response
        {
            public string league { get; set; }=string.Empty;
            public int season { get; set; }
            public Team team { get; set; } = new Team();
            public Conference conference { get; set; } = new Conference();
            public Division division { get; set; } = new Division();
            public Win win { get; set; } = new Win();
            public Loss loss { get; set; }= new Loss(); 
            public string gamesBehind { get; set; } = string.Empty;
            public int streak { get; set; }
            public bool winStreak { get; set; }
            public object tieBreakerPoints { get; set; } = new object();
        }

        public class Root
        {
            public string get { get; set; }=string.Empty;       
            public Parameters parameters { get; set; }= new Parameters();
            public List<object> errors { get; set; } = new List<object>();
            public int results { get; set; }
            public List<Response> response { get; set; }= new List<Response>();
        }

        public class Team
        {
            public int id { get; set; }
            public string name { get; set; }= string.Empty;
            public string nickname { get; set; } = string.Empty;
            public string code { get; set; } = string.Empty;
            public string logo { get; set; } = string.Empty;
        }

        public class Win
        {
            public int home { get; set; }
            public int away { get; set; }
            public int total { get; set; }
            public string percentage { get; set; } = string.Empty;
            public int lastTen { get; set; }
        }


    }
}
