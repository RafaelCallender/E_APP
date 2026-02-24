
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_SET_MODEL
{
    internal class Nba_Set_Model03
    {
        public object conference { get; set; }=string.Empty;
        public object division { get; set; } = string.Empty;
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string nickname { get; set; } = string.Empty;
        public string code { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string logo { get; set; } = string.Empty;
        public bool allStar { get; set; }
        public bool nbaFranchise { get; set; }
        public string get { get; set; } = string.Empty;
        public List<object> parameters { get; set; }= new List<object>();
        public List<object> errors { get; set; }= new List<object>();
        public int results { get; set; }
        public string conference1 { get; set; }=string.Empty;
        public string division1 { get; set; } = string.Empty;
        public string conference2 { get; set; } = string.Empty;
        public string division2 { get; set; } = string.Empty;
        public string conferenc3 { get; set; } = string.Empty;
        public string division3 {get; set; }=string.Empty;  
        public string conference4 { get; set; }=string.Empty;       
        public string division4 { get; set; }=string.Empty;     
    }
}
