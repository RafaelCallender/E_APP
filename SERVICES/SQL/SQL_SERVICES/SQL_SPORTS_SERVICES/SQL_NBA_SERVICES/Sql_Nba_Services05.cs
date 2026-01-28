
using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SPORTS_SERVICES.SQL_NBA_SERVICES
{
    internal class Sql_Nba_Services05
    {
        private static string[] data01 = new string[100];
        private List<int> RefereeID = new List<int>();
        private List<string> Name = new List<string>();
        private List<int> Number = new List<int>();
        private List<string> Position = new List<string>();
        private List<string> College = new List<string>();
        public static List<Sql_Nba_Get_Model05> collectiondata01 = new List<Sql_Nba_Get_Model05>();
        public string find_Referee_by_id(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[44].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[44].Parameters.Clear();
            Sql_Manager01.cmd[44].Parameters.AddWithValue("@RefereeID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[44].ExecuteReader())
            {
                if (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"].ToString()));
                    Name.Add(reader["Name"].ToString());
                    Number.Add(int.Parse(reader["Number"].ToString()));
                    Position.Add(reader["Position"].ToString());
                    College.Add(reader["College"].ToString());

                    data01[0] =
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";

                    var collection_set = new Sql_Nba_Get_Model05
                    {
                        RefereeID = int.Parse(reader["RefereeID"].ToString()),
                        Name = reader["Name"].ToString(),
                        Number = int.Parse(reader["Number"].ToString()),
                        Position = reader["Position"].ToString(),
                        College = reader["College"].ToString(),
                    };
                }
                else
                {
                    data01[0] = "failed";
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string find_Referee_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[45].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[45].Parameters.Clear();
            Sql_Manager01.cmd[45].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[45].ExecuteReader())
            {
                if (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"].ToString()));
                    Name.Add(reader["Name"].ToString());
                    Number.Add(int.Parse(reader["Number"].ToString()));
                    Position.Add(reader["Position"].ToString());
                    College.Add(reader["College"].ToString());

                    data01[0] =
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";

                    var collection_set = new Sql_Nba_Get_Model05
                    {
                        RefereeID = int.Parse(reader["RefereeID"].ToString()),
                        Name = reader["Name"].ToString(),
                        Number = int.Parse(reader["Number"].ToString()),
                        Position = reader["Position"].ToString(),
                        College = reader["College"].ToString(),
                    };
                }
                else
                {
                    data01[0] = "failed";
                }
                return data01[0];
            }
        }
        public string insert_Referee(string input00, string input01, string input02, string input03, string input04)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[51].Parameters.Clear();
            Sql_Manager01.cmd[51].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@RefereeID", input00);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@Name", input01);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@Number", input02);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@Position", input03);
            Sql_Manager01.cmd[51].Parameters.AddWithValue("@College", input04);
            object result = Sql_Manager01.cmd[51].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = "success";
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_all_Referee()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[44].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[44].ExecuteReader())
            {
                while (reader.Read())
                {
                    RefereeID.Add(int.Parse(reader["RefereeID"].ToString()));
                    Name.Add(reader["Name"].ToString());
                    Number.Add(int.Parse(reader["Number"].ToString()));
                    Position.Add(reader["Position"].ToString());
                    College.Add(reader["College"].ToString());

                    data01[0] +=
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["RefereeID"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Number"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["College"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model05
                    {

                        RefereeID = int.Parse(reader["TeamID"].ToString()),
                        Name = reader["TeamID"].ToString(),
                        Number = int.Parse(reader["TeamID"].ToString()),
                        Position = reader["TeamID"].ToString(),
                        College = reader["TeamID"].ToString(),

                    };

                    collectiondata01.Add(collection_set);

                }
            }


            data01[1] +=
           
                      $"{string.Join(" ", RefereeID)}\n" +
                      $"{string.Join(" ", Name)}\n" +
                      $"{string.Join(" ", Number)}\n" +
                      $"{string.Join(" ", Position)}\n" +
                      $"{string.Join(" ", College)}\n";


            return data01[1];
        }






    }
}
