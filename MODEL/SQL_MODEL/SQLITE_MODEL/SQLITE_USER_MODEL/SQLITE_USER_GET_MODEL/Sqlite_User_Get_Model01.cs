using SQLite;
namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_USER_MODEL.SQLITE_USER_GET_MODEL
{
    [Table("UserTable01")]
    internal class Sqlite_User_Get_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }

        public string lastname { get; set; }

        public string birthdate { get; set; }

        public string email { get; set; }

        public string phonenumber { get; set; }

        public string password { get; set; }

        public string longitude { get; set; }

        public string latitude { get; set; }

        public string creation_date { get; set; }


    }
}
