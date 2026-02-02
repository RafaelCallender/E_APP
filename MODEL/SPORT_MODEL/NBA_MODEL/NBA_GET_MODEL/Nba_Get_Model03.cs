
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model03
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Africa
        {
            public object conference { get; set; }
            public object division { get; set; }
        }

        public class Leagues
        {
            public Standard standard { get; set; }
            public Vegas vegas { get; set; }
            public Utah utah { get; set; }
            public Sacramento sacramento { get; set; }
            public Africa africa { get; set; }
        }

        public class Response
        {
            public int id { get; set; }
            public string name { get; set; }
            public string nickname { get; set; }
            public string code { get; set; }
            public string city { get; set; }
            public string logo { get; set; }
            public bool allStar { get; set; }
            public bool nbaFranchise { get; set; }
            public Leagues leagues { get; set; }
        }

        public class Root
        {
            public string get { get; set; }
            public List<object> parameters { get; set; }
            public List<object> errors { get; set; }
            public int results { get; set; }
            public List<Response> response { get; set; }
        }

        public class Sacramento
        {
            public string conference { get; set; }
            public string division { get; set; }
        }

        public class Standard
        {
            public string conference { get; set; }
            public string division { get; set; }
        }

        public class Utah
        {
            public string conference { get; set; }
            public string division { get; set; }
        }

        public class Vegas
        {
            public string conference { get; set; }
            public string division { get; set; }
        }


    }
}
