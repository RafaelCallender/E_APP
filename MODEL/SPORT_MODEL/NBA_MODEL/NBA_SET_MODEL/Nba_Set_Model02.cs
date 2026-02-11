
namespace E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_SET_MODEL
{
    internal class Nba_Set_Model02
    {
        public string get { get; set; } = string.Empty;
        public string date { get; set; } = string.Empty;
        public List<object> errors { get; set; }= new List<object>();
        public int results { get; set; }
        public int id { get; set; }
        public string league { get; set; } = string.Empty;
        public int season { get; set; }
        public DateTime start { get; set; }           
        public DateTime end { get; set; }            
        public string duration { get; set; } =string.Empty;
        public object clock { get; set; } =string.Empty;
        public bool halftime { get; set; }            
        public int @short { get; set; }           
        public string @long { get; set; }  = string.Empty;
        public int current { get; set; }     
        public int total { get; set; }     
        public bool endOfPeriod { get; set; }  
        public string name { get; set; }   =string.Empty;
        public string city { get; set; } = string.Empty;
        public string state { get; set; }  = string.Empty;
        public string country { get; set; }  = string.Empty;
        public int id1 { get; set; }                   
        public string name1 { get; set; } = string.Empty;             
        public string nickname1 { get; set; } = string.Empty;
        public string code1 { get; set; } = string.Empty;
        public string logo1 { get; set; } = string.Empty;
        public int win1 { get; set; }
        public int loss1 { get; set; }
        public int series_win1 { get; set; }          
        public int series_loss1 { get; set; }         
        public List<string> linescore1 { get; set; } = new List<string>();
        public int points1 { get; set; }   
        public int id2 { get; set; }               
        public string name2 { get; set; } = string.Empty;
        public string nickname2 { get; set; } = string.Empty;
        public string code2 { get; set; } = string.Empty;
        public string logo2 { get; set; } = string.Empty;
        public int win2 { get; set; }
        public int loss2 { get; set; }
        public int series_win2 { get; set; }         
        public int series_loss2 { get; set; }           
        public List<string> linescore2 { get; set; }= new List<string>();
        public int points2 { get; set; }            
        public List<string> officials { get; set; }= new List<string>();
        public int timesTied { get; set; }
        public int leadChanges { get; set; }
        public object nugget { get; set; }=string.Empty;    
    }
}
