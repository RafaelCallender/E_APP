

namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model05
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Conference
        {
            public string name { get; set; }
            public int rank { get; set; }
            public int win { get; set; }
            public int loss { get; set; }
        }

        public class Division
        {
            public string name { get; set; }
            public int rank { get; set; }
            public int win { get; set; }
            public int loss { get; set; }
            public string gamesBehind { get; set; }
        }

        public class Loss
        {
            public int home { get; set; }
            public int away { get; set; }
            public int total { get; set; }
            public string percentage { get; set; }
            public int lastTen { get; set; }
        }

        public class Parameters
        {
            public string league { get; set; }
            public string season { get; set; }
        }

        public class Response
        {
            public string league { get; set; }
            public int season { get; set; }
            public Team team { get; set; }
            public Conference conference { get; set; }
            public Division division { get; set; }
            public Win win { get; set; }
            public Loss loss { get; set; }
            public string gamesBehind { get; set; }
            public int streak { get; set; }
            public bool winStreak { get; set; }
            public object tieBreakerPoints { get; set; }
        }

        public class Root
        {
            public string get { get; set; }
            public Parameters parameters { get; set; }
            public List<object> errors { get; set; }
            public int results { get; set; }
            public List<Response> response { get; set; }
        }

        public class Team
        {
            public int id { get; set; }
            public string name { get; set; }
            public string nickname { get; set; }
            public string code { get; set; }
            public string logo { get; set; }
        }

        public class Win
        {
            public int home { get; set; }
            public int away { get; set; }
            public int total { get; set; }
            public string percentage { get; set; }
            public int lastTen { get; set; }
        }


    }
}
