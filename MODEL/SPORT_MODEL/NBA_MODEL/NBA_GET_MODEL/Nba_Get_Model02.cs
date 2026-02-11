
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model02
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Arena
        {
            public string name { get; set; }= string.Empty;
            public string city { get; set; } = string.Empty;
            public string state { get; set; } = string.Empty;
            public string country { get; set; } = string.Empty;
        }

        public class Date
        {
            public DateTime? start { get; set; }
            public DateTime? end { get; set; }
            public string duration { get; set; } = string.Empty;
        }

        public class Home
        {
            public int id { get; set; }
            public string name { get; set; }= string.Empty;
            public string nickname { get; set; }= string.Empty;
            public string code { get; set; } = string.Empty;
            public string logo { get; set; } = string.Empty;
            public int? win { get; set; }
            public int? loss { get; set; }
            public Series series { get; set; }= new Series();   
            public List<string> linescore { get; set; } = new List<string>();
            public int? points { get; set; }
        }

        public class Parameters
        {
            public string team { get; set; }= string.Empty;
            public string date { get; set; } = string.Empty;
            public string h2h { get; set; } = string.Empty;
            public string live { get; set; } = string.Empty;
            public string season { get; set; } = string.Empty;
            public string id { get; set; } = string.Empty;
        }   

        public class Periods
        {
            public int current { get; set; }
            public int total { get; set; }
            public bool? endOfPeriod { get; set; }
        }

        public class Response
        {
            public int id { get; set; }
            public string league { get; set; } = string.Empty;
            public int season { get; set; }
            public Date date { get; set; }= new Date();
            public int stage { get; set; }
            public Status status { get; set; } = new Status();
            public Periods periods { get; set; } = new Periods();
            public Arena arena { get; set; } = new Arena();
            public Teams teams { get; set; } = new Teams();
            public Scores scores { get; set; } = new Scores();
            public List<string> officials { get; set; } = new List<string>();
            public int? timesTied { get; set; }
            public int? leadChanges { get; set; }
            public object nugget { get; set; } = new object();
        }

        public class Root
        {
            public string get { get; set; }=string.Empty;
            public Parameters parameters { get; set; } = new Parameters();
            public List<object> errors { get; set; } = new List<object>();
            public int results { get; set; }
            public List<Response> response { get; set; } = new List<Response>();
        }

        public class Scores
        {
            public Visitors visitors { get; set; } = new Visitors();
            public Home home { get; set; } = new Home();
        }

        public class Series
        {
            public int? win { get; set; }
            public int? loss { get; set; }
        }

        public class Status
        {   
            public object clock { get; set; }=string.Empty; 
            public bool? halftime { get; set; }
            public int @short { get; set; }
            public string @long { get; set; } = string.Empty;
        }

        public class Teams
        {
            public Visitors visitors { get; set; }= new Visitors();
            public Home home { get; set; }= new Home();
        }

        public class Visitors
        {
            public int id { get; set; }
            public string name { get; set; }= string.Empty;
            public string nickname { get; set; } = string.Empty;
            public string code { get; set; }= string.Empty; 
            public string logo { get; set; } = string.Empty;
            public int? win { get; set; }
            public int? loss { get; set; }
            public Series series { get; set; } = new Series();
            public List<string> linescore { get; set; }= new List<string>();
            public int? points { get; set; }
        }


    }
}
