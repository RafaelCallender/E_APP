using SQLite;
namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL
{
    [Table("UserTable01")]
    internal class Sqlite_User_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string username { get; set; } = string.Empty;
        public string firstname { get; set; } = string.Empty;

        public string lastname { get; set; } = string.Empty;

        public string birthdate { get; set; } = string.Empty;

        public string email { get; set; } = string.Empty;

        public string phonenumber { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;

        public string longitude { get; set; } = string.Empty;

        public string latitude { get; set; } = string.Empty;

        public string creation_date { get; set; } = string.Empty;


    }
}
