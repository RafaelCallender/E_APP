

namespace E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL
{
    internal class Sql_Nba_Get_Model04
    {
        public int TeamID { get; set; }
        public string Keys { get; set; }= string.Empty;
        public bool Active { get; set; }
        public string City { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int LeagueID { get; set; }
        public int StadiumID { get; set; }
        public string Conference { get; set; } = string.Empty;
        public string Division { get; set; } = string.Empty;
        public string PrimaryColor { get; set; } = string.Empty;
        public string SecondaryColor { get; set; } = string.Empty;
        public string TertiaryColor { get; set; } = string.Empty;
        public string QuaternaryColor { get; set; } = string.Empty;
        public string WikipediaLogoUrl { get; set; } = string.Empty;
        public string WikipediaWordMarkUrl { get; set; } = string.Empty;
        public int GlobalTeamID { get; set; }
        public int NbaDotComTeamID { get; set; }
        public string HeadCoach { get; set; } = string.Empty;
    }
}
