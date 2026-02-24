
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model06
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Parameters
        {
            public string id { get; set; } = string.Empty;
        }

        public class Response
        {
            public Team team { get; set; }= new Team();
            public List<Statistic> statistics { get; set; }= new List<Statistic>();
        }

        public class Root
        {
            public string get { get; set; }= string.Empty;
            public Parameters parameters { get; set; } = new Parameters();
            public List<object> errors { get; set; } = new List<object>();
            public int results { get; set; }
            public List<Response> response { get; set; } = new List<Response>();
        }

        public class Statistic
        {
            public int fastBreakPoints { get; set; }
            public int pointsInPaint { get; set; }
            public int biggestLead { get; set; }
            public int secondChancePoints { get; set; }
            public int pointsOffTurnovers { get; set; }
            public int longestRun { get; set; }
            public int points { get; set; }
            public int fgm { get; set; }
            public int fga { get; set; }
            public string fgp { get; set; }=string.Empty;
            public int ftm { get; set; }
            public int fta { get; set; }
            public string ftp { get; set; } = string.Empty;
            public int tpm { get; set; }
            public int tpa { get; set; }
            public string tpp { get; set; } = string.Empty;
            public int offReb { get; set; }
            public int defReb { get; set; }
            public int totReb { get; set; }
            public int assists { get; set; }
            public int pFouls { get; set; }
            public int steals { get; set; }
            public int turnovers { get; set; }
            public int blocks { get; set; }
            public string plusMinus { get; set; } = string.Empty;
            public string min { get; set; } = string.Empty;
        }

        public class Team
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public string nickname { get; set; } = string.Empty;
            public string code { get; set; } = string.Empty;
            public string logo { get; set; } = string.Empty;
        }


    }
}
