using SQLite;


namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL
{
    [Table("UserTable03")]
    internal class Sqlite_User_Get_Model03
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string username { get; set; }
        public string audio_file { get; set; }
        public string audio_creation_date { get; set; }
    }
}
