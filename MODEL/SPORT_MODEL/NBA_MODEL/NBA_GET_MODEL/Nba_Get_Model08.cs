
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model08
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Game
        {
            public int id { get; set; }
        }

        public class Parameters
        {
            public string team { get; set; }    
            public string season { get; set; }
            public string id { get; set; }
        }

        public class Player
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
        }

        public class Response
        {
            public Player player { get; set; }
            public Team team { get; set; }
            public Game game { get; set; }
            public int points { get; set; }
            public string pos { get; set; }
            public string min { get; set; }
            public int fgm { get; set; }
            public int fga { get; set; }
            public string fgp { get; set; }
            public int ftm { get; set; }
            public int fta { get; set; }
            public string ftp { get; set; }
            public int tpm { get; set; }
            public int tpa { get; set; }
            public string tpp { get; set; }
            public int offReb { get; set; }
            public int defReb { get; set; }
            public int totReb { get; set; }
            public int assists { get; set; }
            public int pFouls { get; set; }
            public int steals { get; set; }
            public int turnovers { get; set; }
            public int blocks { get; set; }
            public string plusMinus { get; set; }
            public object comment { get; set; }
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


    }
}
