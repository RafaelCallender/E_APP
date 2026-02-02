

namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model01
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public string get { get; set; }
            public List<string> parameters { get; set; }
            public List<string> errors { get; set; }
            public int results { get; set; }
            public List<string> response { get; set; }
        }


    }
}
