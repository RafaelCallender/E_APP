using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SPORTS_SERVICES.SQL_NBA_SERVICES
{
    internal class Sql_Nba_Services04
    {
        private static string[] data01 = new string[100];
        private List<int> TeamID = new List<int>();
        private List<string> Keys = new List<string>();
        private List<bool> Active = new List<bool>();
        private List<string> City = new List<string>();
        private List<string> Name = new List<string>();
        private List<int> LeagueID = new List<int>();
        private List<int> StadiumID = new List<int>();
        private List<string> Conference = new List<string>();
        private List<string> Division = new List<string>();
        private List<string> PrimaryColor = new List<string>();
        private List<string> SecondaryColor = new List<string>();
        private List<string> TertiaryColor = new List<string>();
        private List<string> QuaternaryColor = new List<string>();
        private List<string> WikipediaLogoUrl = new List<string>();
        private List<string> WikipediaWordMarkUrl = new List<string>();
        private List<int> GlobalTeamID = new List<int>();
        private List<int> NbaDotComTeamID = new List<int>();
        private List<string> HeadCoach = new List<string>();
        public static List<Sql_Nba_Get_Model04> collectiondata01 = new List<Sql_Nba_Get_Model04>();



        public string insert_team_all(string input00, string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17)
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
            input09 = input09 ?? "";
            input10 = input10 ?? "";
            input11 = input11 ?? "";
            input12 = input12 ?? "";
            input13 = input13 ?? "";
            input14 = input14 ?? "";
            input15 = input15 ?? "";
            input16 = input16 ?? "";
            input17 = input17 ?? "";
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[56].Parameters.Clear();
            Sql_Manager01.cmd[56].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@TeamID", input00);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Keys", input01);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Active", input02);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@City", input03);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Name", input04);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@LeagueID", input05);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@StadiumID", input06);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Conference", input07);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@Division", input08);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@PrimaryColor", input09);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@SecondaryColor", input10);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@TertiaryColor", input11);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@QuaternaryColor", input12);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@WikipediaLogoUrl", input13);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@WikipediaWordMarkUrl", input14);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@GlobalTeamID", input15);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@NbaDotComTeamID", input16);
            Sql_Manager01.cmd[56].Parameters.AddWithValue("@HeadCoach", input17);
            object result = Sql_Manager01.cmd[56].ExecuteScalar();

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


        public string find_team_by_id(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[34].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[34].Parameters.Clear();
            Sql_Manager01.cmd[34].Parameters.AddWithValue("@TeamID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[34].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model04
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Keys = reader["Keys"].ToString(),
                        Active = bool.Parse(reader["Active"].ToString()),
                        City = reader["City"].ToString(),
                        Name = reader["Name"].ToString(),
                        LeagueID = int.Parse(reader["LeagueID"].ToString()),
                        StadiumID = int.Parse(reader["StadiumID"].ToString()),
                        Conference = reader["Conference"].ToString(),
                        Division = reader["Division"].ToString(),
                        PrimaryColor = reader["PrimaryColor"].ToString(),
                        SecondaryColor = reader["SecondaryColor"].ToString(),
                        TertiaryColor = reader["TertiaryColor"].ToString(),
                        QuaternaryColor = reader["QuaternaryColor"].ToString(),
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"].ToString(),
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"].ToString(),
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"].ToString()),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"].ToString()),
                        HeadCoach = reader["HeadCoach"].ToString(),

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
        public string find_team_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[33].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[33].Parameters.Clear();
            Sql_Manager01.cmd[33].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[33].ExecuteReader())
            {
                if (reader.Read())
                {
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["@Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model04
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Keys = reader["Keys"].ToString(),
                        Active = bool.Parse(reader["Active"].ToString()),
                        City = reader["City"].ToString(),
                        Name = reader["Name"].ToString(),
                        LeagueID = int.Parse(reader["LeagueID"].ToString()),
                        StadiumID = int.Parse(reader["StadiumID"].ToString()),
                        Conference = reader["Conference"].ToString(),
                        Division = reader["Division"].ToString(),
                        PrimaryColor = reader["PrimaryColor"].ToString(),
                        SecondaryColor = reader["SecondaryColor"].ToString(),
                        TertiaryColor = reader["TertiaryColor"].ToString(),
                        QuaternaryColor = reader["QuaternaryColor"].ToString(),
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"].ToString(),
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"].ToString(),
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"].ToString()),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"].ToString()),
                        HeadCoach = reader["HeadCoach"].ToString(),

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
        public string view_team_names()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[55].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[55].ExecuteReader())
            {
                while (reader.Read())
                {


                    TeamID.Add(int.Parse(reader["TeamID"].ToString()));
                    Keys.Add(reader["Keys"].ToString());
                    Active.Add(bool.Parse(reader["Active"].ToString()));
                    City.Add(reader["City"].ToString());
                    Name.Add(reader["Name"].ToString());
                    LeagueID.Add(int.Parse(reader["LeagueID"].ToString()));
                    StadiumID.Add(int.Parse(reader["StadiumID"].ToString()));
                    Conference.Add(reader["Conference"].ToString());
                    Division.Add(reader["Division"].ToString());
                    PrimaryColor.Add(reader["PrimaryColor"].ToString());
                    SecondaryColor.Add(reader["SecondaryColor"].ToString());
                    TertiaryColor.Add(reader["TertiaryColor"].ToString());
                    QuaternaryColor.Add(reader["QuaternaryColor"].ToString());
                    WikipediaLogoUrl.Add(reader["WikipediaLogoUrl"].ToString());
                    WikipediaWordMarkUrl.Add(reader["WikipediaWordMarkUrl"].ToString());
                    GlobalTeamID.Add(int.Parse(reader["GlobalTeamID"].ToString()));
                    NbaDotComTeamID.Add(int.Parse(reader["NbaDotComTeamID"].ToString()));
                    HeadCoach.Add(reader["HeadCoach"].ToString());

                    data01[0] +=
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["LeagueID"].ToString()}\n" +
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["PrimaryColor"].ToString()}\n" +
                   $"{reader["SecondaryColor"].ToString()}\n" +
                   $"{reader["TertiaryColor"].ToString()}\n" +
                   $"{reader["QuaternaryColor"].ToString()}\n" +
                   $"{reader["WikipediaLogoUrl"].ToString()}\n" +
                   $"{reader["WikipediaWordMarkUrl"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["NbaDotComTeamID"].ToString()}\n" +
                   $"{reader["HeadCoach"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model04
                    {
                        TeamID = int.Parse(reader["TeamID"].ToString()),
                        Keys = reader["Keys"].ToString(),
                        Active = bool.Parse(reader["Active"].ToString()),
                        City = reader["City"].ToString(),
                        Name = reader["Name"].ToString(),
                        LeagueID = int.Parse(reader["LeagueID"].ToString()),
                        StadiumID = int.Parse(reader["StadiumID"].ToString()),
                        Conference = reader["Conference"].ToString(),
                        Division = reader["Division"].ToString(),
                        PrimaryColor = reader["PrimaryColor"].ToString(),
                        SecondaryColor = reader["SecondaryColor"].ToString(),
                        TertiaryColor = reader["TertiaryColor"].ToString(),
                        QuaternaryColor = reader["QuaternaryColor"].ToString(),
                        WikipediaLogoUrl = reader["WikipediaLogoUrl"].ToString(),
                        WikipediaWordMarkUrl = reader["WikipediaWordMarkUrl"].ToString(),
                        GlobalTeamID = int.Parse(reader["GlobalTeamID"].ToString()),
                        NbaDotComTeamID = int.Parse(reader["NbaDotComTeamID"].ToString()),
                        HeadCoach = reader["HeadCoach"].ToString(),

                    };

                    collectiondata01.Add(collection_set);

                }
            }


            data01[1] +=

           $"{string.Join(" ", TeamID)}\n" +
           $"{string.Join(" ", Keys)}\n" +
           $"{string.Join(" ", Active)}\n" +
           $"{string.Join(" ", City)}\n" +
           $"{string.Join(" ", Name)}\n" +
           $"{string.Join(" ", LeagueID)}\n" +
           $"{string.Join(" ", StadiumID)}\n" +
           $"{string.Join(" ", Conference)}\n" +
           $"{string.Join(" ", Division)}\n" +
           $"{string.Join(" ", PrimaryColor)}\n" +
           $"{string.Join(" ", SecondaryColor)}\n" +
           $"{string.Join(" ", TertiaryColor)}\n" +
           $"{string.Join(" ", QuaternaryColor)}\n" +
           $"{string.Join(" ", WikipediaLogoUrl)}\n" +
           $"{string.Join(" ", WikipediaWordMarkUrl)}\n" +
           $"{string.Join(" ", GlobalTeamID)}\n" +
           $"{string.Join(" ", NbaDotComTeamID)}\n" +
           $"{string.Join(" ", HeadCoach)}\n";

            return data01[1];
        }


    }
}
