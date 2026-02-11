using SQLite;

namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_MOVIES_MODEL.SQLITE_MOVIES_GET_MODEL
{
    [Table("MOVIES")]
    internal class Sqlite_Movies_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string file_location { get; set; } = string.Empty;
        public string file_name { get; set; } = string.Empty;
    }
}
