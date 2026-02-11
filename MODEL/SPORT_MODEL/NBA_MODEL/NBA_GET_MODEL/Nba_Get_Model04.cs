

namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model04
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Leagues
        {
            public Standard standard { get; set; } = new Standard();
            public Vegas vegas { get; set; } = new Vegas();
            public Utah utah { get; set; } = new Utah();
            public Sacramento sacramento { get; set; }= new Sacramento();
        }

        public class Parameters
        {
            public string search { get; set; } = string.Empty;
            public string conference { get; set; } = string.Empty;
            public string division { get; set; } = string.Empty;
            public string code { get; set; }=string.Empty;
            public string id { get; set; } = string.Empty;  
        }

        public class Response
        {
            public int id { get; set; }
            public string name { get; set; } = string.Empty;
            public string nickname { get; set; } = string.Empty;
            public string code { get; set; } = string.Empty;
            public string city { get; set; } = string.Empty;
            public string logo { get; set; } = string.Empty;
            public bool allStar { get; set; }
            public bool nbaFranchise { get; set; }
            public Leagues leagues { get; set; } = new Leagues();
        }

        public class Root
        {
            public string get { get; set; } = string.Empty;
            public Parameters parameters { get; set; } = new Parameters();
            public List<object> errors { get; set; }= new List<object>();
            public int results { get; set; }
            public List<Response> response { get; set; } = new List<Response>();
        }

        public class Sacramento
        {
            public string conference { get; set; }=string.Empty;    
            public string division { get; set; } = string.Empty;
        }

        public class Standard
        {
            public string conference { get; set; } = string.Empty;
            public string division { get; set; } = string.Empty;
        }

        public class Utah
        {
            public string conference { get; set; } = string.Empty;
            public string division { get; set; } = string.Empty;
        }

        public class Vegas
        {
            public string conference { get; set; } = string.Empty;
            public string division { get; set; } = string.Empty;
        }


    }
}
