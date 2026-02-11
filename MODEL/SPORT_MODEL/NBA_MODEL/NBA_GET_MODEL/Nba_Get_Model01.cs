

namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL
{
    internal class Nba_Get_Model01
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public string get { get; set; }= string.Empty;
            public List<string> parameters { get; set; }= new List<string>();   
            public List<string> errors { get; set; }= new List<string>();
            public int results { get; set; }
            public List<string> response { get; set; } = new List<string>();
        }


    }
}
