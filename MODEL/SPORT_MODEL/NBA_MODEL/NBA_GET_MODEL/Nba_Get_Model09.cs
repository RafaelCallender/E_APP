
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model09
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Birth
        {
            public string date { get; set; }= string.Empty;
            public string country { get; set; } = string.Empty;
        }

        public class Height
        {
            public string feets { get; set; } = string.Empty;
            public string inches { get; set; } = string.Empty;
            public string meters { get; set; } = string.Empty;
        }

        public class Leagues
        {
            public Standard standard { get; set; }= new Standard();
            public Vegas vegas { get; set; }= new Vegas();
            public Sacramento sacramento { get; set; } = new Sacramento();
        }

        public class Nba
        {
            public int start { get; set; }
            public int pro { get; set; }
        }

        public class Parameters
        {
            public string search { get; set; }= string.Empty;
        }

        public class Response
        {
                public int id { get; set; }
                public string firstname { get; set; }=string.Empty;
            public string lastname { get; set; } = string.Empty;
            public Birth birth { get; set; }= new Birth();  
            public Nba nba { get; set; }= new Nba();
            public Height height { get; set; } = new Height();
            public Weight weight { get; set; } = new Weight();
            public string college { get; set; } = string.Empty;
            public string affiliation { get; set; } = string.Empty;
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
            public object jersey { get; set; }= string.Empty;   
            public bool active { get; set; } 
            public string pos { get; set; } = string.Empty;
        }

        public class Standard
        {
            public int jersey { get; set; }
            public bool active { get; set; }
            public string pos { get; set; } = string.Empty;
        }

        public class Vegas
        {
            public object jersey { get; set; }= string.Empty;   
            public bool active { get; set; }
            public string pos { get; set; } = string.Empty;
        }

        public class Weight
        {
            public string pounds { get; set; }= string.Empty;
            public string kilograms { get; set; }= string.Empty;
        }


    }
}
