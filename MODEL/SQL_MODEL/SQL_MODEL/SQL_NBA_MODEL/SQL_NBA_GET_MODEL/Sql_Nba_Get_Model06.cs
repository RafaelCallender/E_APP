

namespace E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL
{
    internal class Sql_Nba_Get_Model06
    {
        public int StadiumID { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public int? Capacity { get; set; }
        public double GeoLat { get; set; }
        public double GeoLong { get; set; }
    }
}