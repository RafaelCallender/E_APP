using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using Microsoft.Data.SqlClient;
using System.Data;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;

namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SPORTS_SERVICES.SQL_NBA_SERVICES
{
    internal class Sql_Nba_Services07
    {
        private static string[] data01 = new string[100];
        private List<int> Season = new List<int>();
        private List<int> StartYear = new List<int>();
        private List<int> EndYear = new List<int>();
        private List<string> Description = new List<string>();
        private List<DateTime> RegularSeasonStartDate = new List<DateTime>();
        private List<DateTime> PostSeasonStartDat = new List<DateTime>();
        private List<string> SeasonType01 = new List<string>();
        private List<string> ApiSeason = new List<string>();
        public static List<Sql_Nba_Get_Model07> collectiondata01 = new List<Sql_Nba_Get_Model07>();
        public string find_Season(string input01)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[53].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[53].Parameters.Clear();
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@Season", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[53].ExecuteReader())
            {
                if (reader.Read())
                {

                    Season.Add(int.Parse(reader["Season"].ToString()));
                    StartYear.Add(int.Parse(reader["StartYear"].ToString()));
                    EndYear.Add(int.Parse(reader["EndYear"].ToString()));
                    Description.Add(reader["Description"].ToString());
                    RegularSeasonStartDate.Add(DateTime.Parse(reader["RegularSeasonStartDate"].ToString()));
                    PostSeasonStartDat.Add(DateTime.Parse(reader["PostSeasonStartDate"].ToString()));
                    SeasonType01.Add(reader["SeasonType01"].ToString());
                    ApiSeason.Add(reader["ApiSeason"].ToString());
                    data01[0] =
                   $"{reader["SeasonID"].ToString()}\n" +
                   $"{reader["Season"].ToString()}\n" +
                   $"{reader["StartYear"].ToString()}\n" +
                   $"{reader["EndYear"].ToString()}\n" +
                   $"{reader["Description"].ToString()}\n" +
                   $"{reader["RegularSeasonStartDate"].ToString()}\n" +
                   $"{reader["PostSeasonStartDate"].ToString()}\n" +
                   $"{reader["SeasonType01"].ToString()}\n" +
                   $"{reader["ApiSeason"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model07
                    {
                        Season = (int.Parse(reader["Season"].ToString())),
                        StartYear = (int.Parse(reader["StartYear"].ToString())),
                        EndYear = (int.Parse(reader["EndYear"].ToString())),
                        Description = (reader["Description"].ToString()),
                        RegularSeasonStartDate = (DateTime.Parse(reader["RegularSeasonStartDate"].ToString())),
                        PostSeasonStartDat = (DateTime.Parse(reader["PostSeasonStartDate"].ToString())),
                        SeasonType01 = (reader["SeasonType01"].ToString()),
                        ApiSeason = (reader["ApiSeason"].ToString()),
                    };
                    collectiondata01.Add(collection_set);
                }
                else
                {
                    data01[0] = "failed";
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string insert_season(string input00, string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08)
        {
            input00 = input00 ?? "";
            input01 = input01 ?? "";
            input02 = input02 ?? "";
            input03 = input03 ?? "";
            input04 = input04 ?? "";
            input05 = input05 ?? "";
            input06 = input06 ?? "";
            input07 = input07 ?? "";
            input08 = input08 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[53].Parameters.Clear();
            Sql_Manager01.cmd[53].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@SeasonID", input00);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@Season", input01);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@StartYear", input02);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@EndYear", input03);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@Description", input04);
            Sql_Manager01.cmd[54].Parameters.AddWithValue("@RegularSeasonStartDate", input05);
            Sql_Manager01.cmd[54].Parameters.AddWithValue("@PostSeasonStartDate", input06);
            Sql_Manager01.cmd[54].Parameters.AddWithValue("@SeasonType01", input07);
            Sql_Manager01.cmd[53].Parameters.AddWithValue("@ApiSeason", input08);
            object result = Sql_Manager01.cmd[53].ExecuteScalar();

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
        public string view_season()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[54].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[54].ExecuteReader())
            {
                while (reader.Read())
                {
                    Season.Add(int.Parse(reader["Season"].ToString()));
                    StartYear.Add(int.Parse(reader["StartYear"].ToString()));
                    EndYear.Add(int.Parse(reader["EndYear"].ToString()));
                    Description.Add(reader["Description"].ToString());
                    RegularSeasonStartDate.Add(DateTime.Parse(reader["RegularSeasonStartDate"].ToString()));
                    PostSeasonStartDat.Add(DateTime.Parse(reader["PostSeasonStartDate"].ToString()));
                    SeasonType01.Add(reader["SeasonType01"].ToString());
                    ApiSeason.Add(reader["ApiSeason"].ToString());
                    data01[0] +=
                   $"{reader["SeasonID"].ToString()}\n" +
                   $"{reader["Season"].ToString()}\n" +
                   $"{reader["StartYear"].ToString()}\n" +
                   $"{reader["EndYear"].ToString()}\n" +
                   $"{reader["Description"].ToString()}\n" +
                   $"{reader["RegularSeasonStartDate"].ToString()}\n" +
                   $"{reader["PostSeasonStartDate"].ToString()}\n" +
                   $"{reader["SeasonType01"].ToString()}\n" +
                   $"{reader["ApiSeason"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model07
                    {
                        Season = int.Parse(reader["Season"].ToString()),
                        StartYear = int.Parse(reader["StartYear"].ToString()),
                        EndYear = int.Parse(reader["EndYear"].ToString()),
                        Description = reader["Description"].ToString(),
                        RegularSeasonStartDate = DateTime.Parse(reader["RegularSeasonStartDate"].ToString()),
                        PostSeasonStartDat = DateTime.Parse(reader["PostSeasonStartDate"].ToString()),
                        SeasonType01 = reader["SeasonType01"].ToString(),
                        ApiSeason = reader["ApiSeason"].ToString(),
                    };
                    collectiondata01.Add(collection_set);
                }
                return data01[0];
            }
        }
    }
}

