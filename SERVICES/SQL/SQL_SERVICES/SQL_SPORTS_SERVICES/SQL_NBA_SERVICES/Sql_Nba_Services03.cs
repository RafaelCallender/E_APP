using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;
using Microsoft.Data.SqlClient;
using System.Data;

namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SPORTS_SERVICES.SQL_NBA_SERVICES
{
    internal class Sql_Nba_Services03
    {
        private static string[] data01 = new string[100];
        private List<int> Season = new List<int>();
        private List<int> SeasonType = new List<int>();
        private List<string?> Key = new List<string?>();
        private List<int> Wins = new List<int>();
        private List<int> Losses = new List<int>();
        private List<double> Percentage = new List<double>();
        private List<int> ConferenceWins = new List<int>();
        private List<int> ConferenceLosses = new List<int>();
        private List<int> DivisionWins = new List<int>();
        private List<int> DivisionLosses = new List<int>();
        private List<int> HomeWins = new List<int>();
        private List<int> HomeLosses = new List<int>();
        private List<int> AwayWins = new List<int>();
        private List<int> AwayLosses = new List<int>();
        private List<int> LastTenWins = new List<int>();
        private List<int> LastTenLosses = new List<int>();
        private List<double> PointsPerGameFor = new List<double>();
        private List<double> PointsPerGameAgainst = new List<double>();
        private List<int> Streak = new List<int>();
        private List<double> GamesBack = new List<double>();
        private List<string> StreakDescription = new List<string>();
        private List<int> ConferenceRank = new List<int>();
        private List<int> DivisionRank = new List<int>();
        private List<string> TeamID = new List<string>();
        private List<string> City = new List<string>();
        private List<string> Name = new List<string>();
        private List<string> Conference = new List<string>();
        private List<string> Division = new List<string>();
        private List<int> GlobalTeamID = new List<int>();
        public static List<Sql_Nba_Get_Model03> collectiondata01 = new List<Sql_Nba_Get_Model03>();
      
        public string insert_team_standings(string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17,
                                            string input18, string input19, string input20, string input21, string input22,
                                            string input23, string input24, string input25, string input26, string input27,
                                            string input28, string input29)
        {



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
            input18 = input18 ?? "";
            input19 = input19 ?? "";
            input20 = input20 ?? "";
            input21 = input21 ?? "";
            input22 = input22 ?? "";
            input23 = input23 ?? "";
            input24 = input24 ?? "";
            input25 = input25 ?? "";
            input26 = input26 ?? "";
            input27 = input27 ?? "";
            input28 = input28 ?? "";
            input29 = input29 ?? "";

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[35].Parameters.Clear();
            Sql_Manager01.cmd[35].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Season", input01);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@SeasonType", input02);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@TeamID", input03);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Key", input04);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@City", input05);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Name", input06);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Conference", input07);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Division", input08);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Wins", input09);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Losses", input10);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Percentage", input11);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@ConferenceWins", input12);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@ConferenceLosses", input13);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@DivisionWins", input14);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@DivisionLosses", input15);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@HomeWins", input16);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@HomeLosses", input17);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@AwayWins", input18);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@AwayLosses", input19);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@LastTenWins", input20);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@LastTenLosses", input21);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@PointsPerGameFor", input22);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@PointsPerGameAgainst", input23);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@Streak", input24);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@GamesBack", input25);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@StreakDescription", input26);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@GlobalTeamID", input27);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@ConferenceRank", input28);
            Sql_Manager01.cmd[35].Parameters.AddWithValue("@DivisionRank", input29);

            object result = Sql_Manager01.cmd[35].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = "sucess";
            }
            else
            {

                data01[0] = "Unknown result from database";
            }

            Sql_Manager01.conn[5].Close();
            return data01[0]; ;
        }



        public string find_team_standings_by_teamid(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[36].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[36].Parameters.Clear();
            Sql_Manager01.cmd[36].Parameters.AddWithValue("@TeamID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[36].ExecuteReader())
            {
                if (reader.Read())
                {
                    TeamID.Add(reader["TeamID"]?.ToString() ?? string.Empty);
                    Season.Add(int.Parse(reader["Season"]?.ToString() ?? string.Empty));
                    SeasonType.Add(int.Parse(reader["SeasonType"]?.ToString() ?? string.Empty));
                    Key.Add(reader["Keys"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Conference.Add(reader["@Conference"]?.ToString() ?? string.Empty);
                    Division.Add(reader["@Division"]?.ToString() ?? string.Empty);
                    Wins.Add(int.Parse(reader["@Wins"]?.ToString() ?? string.Empty));
                    Losses.Add(int.Parse(reader["@Losses"]?.ToString() ?? string.Empty));
                    Percentage.Add(double.Parse(reader["@Percentage"]?.ToString() ?? string.Empty));
                    ConferenceWins.Add(int.Parse(reader["@ConferenceWins"]?.ToString() ?? string.Empty));
                    ConferenceLosses.Add(int.Parse(reader["@ConferenceLosses"]?.ToString() ?? string.Empty));
                    DivisionWins.Add(int.Parse(reader["@DivisionWins"]?.ToString() ?? string.Empty));
                    DivisionLosses.Add(int.Parse(reader["@DivisionLosses"]?.ToString() ?? string.Empty));
                    HomeWins.Add(int.Parse(reader["@HomeWins"]?.ToString() ?? string.Empty));
                    HomeLosses.Add(int.Parse(reader["@HomeLosses"]?.ToString() ?? string.Empty));
                    AwayWins.Add(int.Parse(reader["@AwayWins"]?.ToString() ?? string.Empty));
                    AwayLosses.Add(int.Parse(reader["@AwayLosses"]?.ToString() ?? string.Empty));
                    LastTenWins.Add(int.Parse(reader["@LastTenWins"]?.ToString() ?? string.Empty));
                    LastTenLosses.Add(int.Parse(reader["@LastTenLosses"]?.ToString() ?? string.Empty));
                    PointsPerGameFor.Add(int.Parse(reader["@PointsPerGameFor"]?.ToString() ?? string.Empty));
                    PointsPerGameAgainst.Add(int.Parse(reader["@PointsPerGameAgainst"]?.ToString() ?? string.Empty));
                    Streak.Add(int.Parse(reader["@Streak"]?.ToString() ?? string.Empty));
                    GamesBack.Add(int.Parse(reader["@GamesBack"]?.ToString() ?? string.Empty));
                    StreakDescription.Add(reader["@StreakDescription"]?.ToString() ?? string.Empty);
                    GlobalTeamID.Add(int.Parse(reader["@GlobalTeamID"]?.ToString() ?? string.Empty));
                    ConferenceRank.Add(int.Parse(reader["@ConferenceRank"]?.ToString() ?? string.Empty));
                    DivisionRank.Add(int.Parse(reader["@DivisionRank"]?.ToString() ?? string.Empty));




                    data01[0] =
                   $"{reader["@TeamID"].ToString()}\n" +
                   $"{reader["@Season"].ToString()}\n" +
                   $"{reader["@SeasonType"].ToString()}\n" +
                   $"{reader["@TeamID"].ToString()}\n" +
                   $"{reader["@Key"].ToString()}\n" +
                   $"{reader["@City"].ToString()}\n" +
                   $"{reader["@Name"].ToString()}\n" +
                   $"{reader["@Conference"].ToString()}\n" +
                   $"{reader["@Division"].ToString()}\n" +
                   $"{reader["@Wins"].ToString()}\n" +
                   $"{reader["@Losses"].ToString()}\n" +
                   $"{reader["@Percentage"].ToString()}\n" +
                   $"{reader["@ConferenceWins"].ToString()}\n" +
                   $"{reader["@ConferenceLosses"].ToString()}\n" +
                   $"{reader["@DivisionWins"].ToString()}\n" +
                   $"{reader["@DivisionLosses"].ToString()}\n" +
                   $"{reader["@HomeWins"].ToString()}\n" +
                   $"{reader["@HomeLosses"].ToString()}\n" +
                   $"{reader["@AwayWins"].ToString()}\n" +
                   $"{reader["@AwayLosses"].ToString()}\n" +
                   $"{reader["@LastTenWins"].ToString()}\n" +
                   $"{reader["@LastTenLosses"].ToString()}\n" +
                   $"{reader["@PointsPerGameFor"].ToString()}\n" +
                   $"{reader["@PointsPerGameAgainst"].ToString()}\n" +
                   $"{reader["@Streak"].ToString()}\n" +
                   $"{reader["@GamesBack"].ToString()}\n" +
                   $"{reader["@StreakDescription"].ToString()}\n" +
                   $"{reader["@GlobalTeamID"].ToString()}\n" +
                   $"{reader["@ConferenceRank"].ToString()}\n" +
                   $"{reader["@DivisionRank"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model03
                    {
                        TeamID = int.Parse(reader["TeamID"]?.ToString() ?? string.Empty),
                        Season = int.Parse($"{reader["@Season"].ToString()}"),
                        SeasonType = int.Parse($"{reader["@SeasonType"].ToString()}"),
                        Key = $"{reader["@Key"].ToString()}",
                        City = $"{reader["@City"].ToString()}",
                        Name = $"{reader["@Name"].ToString()}",
                        Conference = $"{reader["@Conference"].ToString()}",
                        Division = $"{reader["@Division"].ToString()}",
                        Wins = int.Parse($"{reader["@Wins"].ToString()}"),
                        Losses = int.Parse($"{reader["@Losses"].ToString()}"),
                        Percentage = double.Parse($"{reader["@Percentage"].ToString()}"),
                        ConferenceWins = int.Parse($"{reader["@ConferenceWins"].ToString()}"),
                        ConferenceLosses = int.Parse($"{reader["@ConferenceLosses"].ToString()}"),
                        DivisionWins = int.Parse($"{reader["@DivisionWins"].ToString()}"),
                        DivisionLosses = int.Parse($"{reader["@DivisionLosses"].ToString()}"),
                        HomeWins = int.Parse($"{reader["@HomeWins"].ToString()}"),
                        HomeLosses = int.Parse($"{reader["@HomeLosses"].ToString()}"),
                        AwayWins = int.Parse($"{reader["@AwayWins"].ToString()}"),
                        AwayLosses = int.Parse($"{reader["@AwayLosses"].ToString()}"),
                        LastTenWins = int.Parse($"{reader["@LastTenWins"].ToString()}"),
                        LastTenLosses = int.Parse($"{reader["@LastTenLosses"].ToString()}"),
                        PointsPerGameFor = double.Parse($"{reader["@PointsPerGameFor"].ToString()}"),
                        PointsPerGameAgainst = double.Parse($"{reader["@PointsPerGameAgainst"].ToString()}"),
                        Streak = int.Parse($"{reader["@Streak"].ToString()}"),
                        GamesBack = double.Parse($"{reader["@GamesBack"].ToString()}"),
                        StreakDescription = $"{reader["@StreakDescription"].ToString()}",
                        GlobalTeamID = int.Parse($"{reader["@GlobalTeamID"].ToString()}"),
                        ConferenceRank = int.Parse($"{reader["@ConferenceRank"].ToString()}"),
                        DivisionRank = int.Parse($"{reader["@DivisionRank"].ToString()}"),
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
        public string find_team_standings_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[37].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[37].Parameters.Clear();
            Sql_Manager01.cmd[37].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[37].ExecuteReader())
            {
                if (reader.Read())
                {
                    TeamID.Add(reader["TeamID"]?.ToString() ?? string.Empty);
                    Season.Add(int.Parse(reader["Season"]?.ToString() ?? string.Empty));
                    SeasonType.Add(int.Parse(reader["SeasonType"]?.ToString() ?? string.Empty));
                    Key.Add(reader["Keys"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Conference.Add(reader["Conference"]?.ToString() ?? string.Empty);
                    Division.Add(reader["Division"]?.ToString() ?? string.Empty);
                    Wins.Add(int.Parse(reader["Wins"]?.ToString() ?? string.Empty));
                    Losses.Add(int.Parse(reader["Losses"]?.ToString() ?? string.Empty));
                    Percentage.Add(double.Parse(reader["Percentage"]?.ToString() ?? string.Empty));
                    ConferenceWins.Add(int.Parse(reader["ConferenceWins"]?.ToString() ?? string.Empty));
                    ConferenceLosses.Add(int.Parse(reader["ConferenceLosses"]?.ToString() ?? string.Empty));
                    DivisionWins.Add(int.Parse(reader["DivisionWins"]?.ToString() ?? string.Empty));
                    DivisionLosses.Add(int.Parse(reader["DivisionLosses"]?.ToString() ?? string.Empty));
                    HomeWins.Add(int.Parse(reader["HomeWins"]?.ToString() ?? string.Empty));
                    HomeLosses.Add(int.Parse(reader["HomeLosses"]?.ToString() ?? string.Empty));
                    AwayWins.Add(int.Parse(reader["AwayWins"]?.ToString() ?? string.Empty));
                    AwayLosses.Add(int.Parse(reader["AwayLosses"]?.ToString() ?? string.Empty));
                    LastTenWins.Add(int.Parse(reader["LastTenWins"]?.ToString() ?? string.Empty));
                    LastTenLosses.Add(int.Parse(reader["LastTenLosses"]?.ToString() ?? string.Empty));
                    PointsPerGameFor.Add(double.Parse(reader["PointsPerGameFor"]?.ToString() ?? string.Empty));
                    PointsPerGameAgainst.Add(double.Parse(reader["PointsPerGameAgainst"]?.ToString() ?? string.Empty));
                    Streak.Add(int.Parse(reader["Streak"]?.ToString() ?? string.Empty));
                    GamesBack.Add(int.Parse(reader["GamesBack"]?.ToString() ?? string.Empty));
                    StreakDescription.Add(reader["StreakDescription"]?.ToString() ?? string.Empty);
                    GlobalTeamID.Add(int.Parse(reader["GlobalTeamID"]?.ToString() ?? string.Empty));
                    ConferenceRank.Add(int.Parse(reader["ConferenceRank"]?.ToString() ?? string.Empty));
                    DivisionRank.Add(int.Parse(reader["DivisionRank"]?.ToString() ?? string.Empty));
                    data01[0] =
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Season"].ToString()}\n" +
                   $"{reader["SeasonType"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Keys"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Conference"].ToString()}\n" +
                   $"{reader["Division"].ToString()}\n" +
                   $"{reader["Wins"].ToString()}\n" +
                   $"{reader["Losses"].ToString()}\n" +
                   $"{reader["Percentage"].ToString()}\n" +
                   $"{reader["ConferenceWins"].ToString()}\n" +
                   $"{reader["ConferenceLosses"].ToString()}\n" +
                   $"{reader["DivisionWins"].ToString()}\n" +
                   $"{reader["DivisionLosses"].ToString()}\n" +
                   $"{reader["HomeWins"].ToString()}\n" +
                   $"{reader["HomeLosses"].ToString()}\n" +
                   $"{reader["AwayWins"].ToString()}\n" +
                   $"{reader["AwayLosses"].ToString()}\n" +
                   $"{reader["LastTenWins"].ToString()}\n" +
                   $"{reader["LastTenLosses"].ToString()}\n" +
                   $"{reader["PointsPerGameFor"].ToString()}\n" +
                   $"{reader["PointsPerGameAgainst"].ToString()}\n" +
                   $"{reader["Streak"].ToString()}\n" +
                   $"{reader["GamesBack"].ToString()}\n" +
                   $"{reader["StreakDescription"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["ConferenceRank"].ToString()}\n" +
                   $"{reader["DivisionRank"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model03
                    {
                        TeamID = int.Parse(reader["TeamID"]?.ToString() ?? string.Empty),
                        Season = int.Parse($"{reader["Season"].ToString()}"),
                        SeasonType = int.Parse($"{reader["SeasonType"].ToString()}"),
                        Key = $"{reader["Keys"].ToString()}",
                        City = $"{reader["City"].ToString()}",
                        Name = $"{reader["Name"].ToString()}",
                        Conference = $"{reader["Conference"].ToString()}",
                        Division = $"{reader["Division"].ToString()}",
                        Wins = int.Parse($"{reader["Wins"].ToString()}"),
                        Losses = int.Parse($"{reader["Losses"].ToString()}"),
                        Percentage = double.Parse($"{reader["Percentage"].ToString()}"),
                        ConferenceWins = int.Parse($"{reader["ConferenceWins"].ToString()}"),
                        ConferenceLosses = int.Parse($"{reader["ConferenceLosses"].ToString()}"),
                        DivisionWins = int.Parse($"{reader["DivisionWins"].ToString()}"),
                        DivisionLosses = int.Parse($"{reader["DivisionLosses"].ToString()}"),
                        HomeWins = int.Parse($"{reader["HomeWins"].ToString()}"),
                        HomeLosses = int.Parse($"{reader["HomeLosses"].ToString()}"),
                        AwayWins = int.Parse($"{reader["AwayWins"].ToString()}"),
                        AwayLosses = int.Parse($"{reader["AwayLosses"].ToString()}"),
                        LastTenWins = int.Parse($"{reader["LastTenWins"].ToString()}"),
                        LastTenLosses = int.Parse($"{reader["LastTenLosses"].ToString()}"),
                        PointsPerGameFor = double.Parse($"{reader["PointsPerGameFor"].ToString()}"),
                        PointsPerGameAgainst = double.Parse($"{reader["PointsPerGameAgainst"].ToString()}"),
                        Streak = int.Parse($"{reader["Streak"].ToString()}"),
                        GamesBack = double.Parse($"{reader["GamesBack"].ToString()}"),
                        StreakDescription = $"{reader["StreakDescription"].ToString()}",
                        GlobalTeamID = int.Parse($"{reader["GlobalTeamID"].ToString()}"),
                        ConferenceRank = int.Parse($"{reader["ConferenceRank"].ToString()}"),
                        DivisionRank = int.Parse($"{reader["DivisionRank"].ToString()}"),
                    };

                    collectiondata01.Add(collection_set);
                }
                else
                {
                    data01[0] = "Failed";
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
    }
}
