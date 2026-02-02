using SQLite;


namespace E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_EMAIL_MODEL
{
    [Table("Email_Table01")]
    internal class Sqlite_Email_Model01
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string full_name { get; set; }
        public string email { get; set; }
        public string email_creation_date { get; set; }
        public string phone_number { get; set; }
    }
}
