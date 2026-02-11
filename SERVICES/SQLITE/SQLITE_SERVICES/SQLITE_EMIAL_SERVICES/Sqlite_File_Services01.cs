using E_APP.MODEL.SQL_MODEL.SQLITE_MODEL.SQLITE_EMAIL_MODEL;
using E_APP.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_EMAIL_SERVICES;



namespace E_APP.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_EMIAL_SERVICES
{
    internal class Sqlite_File_Services01
    {
        private static string[] data01 = new string[100];
        public async Task<string> insert_email(string input01, string input02, string input03,
                                               string input04, string input05)
        {

            if (Sqlite_Email_Manager01.data01.Insert(
               new Sqlite_Email_Model01
               {
                   full_name = input01,
                   email = input03,
                   email_creation_date = input04,
                   phone_number = input05

               }) > 0)
            {
                return "Data Inserted Successfully";
            }
            else
            {
                return "Data Insertion Failed";
            }
        }
        public string find_email_using_name(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.full_name == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.email}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public string find_email_using_phonenumber(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.phone_number == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.email}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public string find_full_name_using_phonenumber(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.phone_number == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.full_name}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public string find_full_name_using_email(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.full_name}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public string find_full_name_using_full_name(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.full_name == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.full_name}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public string find_phonenumber_using_phonenumber(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.full_name == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.full_name}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
        public string find_email_using_email(string input)
        {

            var sqlcomm = Sqlite_Email_Manager01.data01.Table<Sqlite_Email_Model01>()
                .Where(i => i.email == input).FirstOrDefault();
            if (sqlcomm != null)
            {
                data01[0] = $"{sqlcomm.email}\n";
                return data01[0];
            }
            else
            {
                return "Data Not Found";
            }
        }
    }
}
