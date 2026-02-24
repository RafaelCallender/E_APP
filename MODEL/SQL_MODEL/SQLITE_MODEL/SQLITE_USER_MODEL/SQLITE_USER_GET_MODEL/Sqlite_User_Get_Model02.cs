using SQLite;


namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL
{
    [Table("UserTable02")]
    internal class Sqlite_User_Get_Model02
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string username { get; set; }= string.Empty;
        public string text_file { get; set; } = string.Empty;
        public string text_file_creation_date { get; set; } = string.Empty;
    }
}
