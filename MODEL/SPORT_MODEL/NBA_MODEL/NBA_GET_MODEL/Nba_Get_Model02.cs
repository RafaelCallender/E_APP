
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model02
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Arena
        {
            public string name { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
        }

        public class Date
        {
            public DateTime? start { get; set; }
            public DateTime? end { get; set; }
            public string duration { get; set; }
        }

        public class Home
        {
            public int id { get; set; }
            public string name { get; set; }
            public string nickname { get; set; }
            public string code { get; set; }
            public string logo { get; set; }
            public int? win { get; set; }
            public int? loss { get; set; }
            public Series series { get; set; }
            public List<string> linescore { get; set; }
            public int? points { get; set; }
        }

        public class Parameters
        {
            public string team { get; set; }
            public string date { get; set; }
            public string h2h { get; set; }
            public string live { get; set; }
            public string season { get; set; }
            public string id { get; set; }
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
            public string league { get; set; }
            public int season { get; set; }
            public Date date { get; set; }
            public int stage { get; set; }
            public Status status { get; set; }
            public Periods periods { get; set; }
            public Arena arena { get; set; }
            public Teams teams { get; set; }
            public Scores scores { get; set; }
            public List<string> officials { get; set; }
            public int? timesTied { get; set; }
            public int? leadChanges { get; set; }
            public object nugget { get; set; }
        }

        public class Root
        {
            public string get { get; set; }
            public Parameters parameters { get; set; }
            public List<object> errors { get; set; }
            public int results { get; set; }
            public List<Response> response { get; set; }
        }

        public class Scores
        {
            public Visitors visitors { get; set; }
            public Home home { get; set; }
        }

        public class Series
        {
            public int? win { get; set; }
            public int? loss { get; set; }
        }

        public class Status
        {   
            public object clock { get; set; }
            public bool? halftime { get; set; }
            public int @short { get; set; }
            public string @long { get; set; }
        }

        public class Teams
        {
            public Visitors visitors { get; set; }
            public Home home { get; set; }
        }

        public class Visitors
        {
            public int id { get; set; }
            public string name { get; set; }
            public string nickname { get; set; }
            public string code { get; set; }
            public string logo { get; set; }
            public int? win { get; set; }
            public int? loss { get; set; }
            public Series series { get; set; }
            public List<string> linescore { get; set; }
            public int? points { get; set; }
        }


    }
}
