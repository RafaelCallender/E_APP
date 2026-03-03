using E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_SET_MODEL;
using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;

namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SPORTS_SERVICES.SQL_NBA_SERVICES
{

    internal class Sql_Nba_Services02
    {
      
       
        private static string[] data01 = new string[100];
        private List<string> TeamID = new List<string>();
        private List<string> Key01 = new List<string>();
        private List<string> Active = new List<string>();
        private List<string> City = new List<string>();
        private List<string> Name = new List<string>();
        private List<string> LeagueID = new List<string>();
        private List<string> Conference = new List<string>();
        private List<string> Division = new List<string>();
        private List<string> PrimaryColor = new List<string>();
        private List<string> SecondaryColor = new List<string>();
        private List<string> TertiaryColor = new List<string>();
        private List<string> QuaternaryColor = new List<string>();
        private List<string> WikipediaLogoUrl = new List<string>();
        private List<string> WikipediaWordMarkUrl = new List<string>();
        private List<string> GlobalTeamID = new List<string>();
        private List<string> NbaDotComTeamID = new List<string>();
        private List<string> HeadCoach = new List<string>();
       
        private List<int> PlayerID = new List<int>();
        private List<string> SportsDataID = new List<string>();
        private List<string> Status = new List<string>();
        private List<string> Team = new List<string>();
        private List<string> Jersey = new List<string>();
        private List<string> PositionCategory = new List<string>();
        private List<object> Position = new List<object>();
        private List<string> FirstName = new List<string>();
        private List<string> LastName = new List<string>();
        private List<string> BirthDate = new List<string>();
        private List<string> BirthCity = new List<string>();
        private List<string> BirthState = new List<string>();
        private List<string> BirthCountry = new List<string>();
        private List<string> Height = new List<string>();
        private List<string> Weight = new List<string>();
        private List<int> RefereeID = new List<int>();
        private List<int> Number = new List<int>();
        private List<string> College = new List<string>();
        private List<string> Address = new List<string>();
        private List<string> State = new List<string>();
        private List<string> Zip = new List<string>();
        private List<string> Country = new List<string>();
        private List<int?> Capacity = new List<int?>();
        private List<double> GeoLat = new List<double>();
        private List<double> GeoLong = new List<double>();
        private List<int> StartYear = new List<int>();
        private List<int> EndYear = new List<int>();
        private List<string> Description = new List<string>();
        private List<DateTime> RegularSeasonStartDate = new List<DateTime>();
        private List<DateTime> PostSeasonStartDate = new List<DateTime>();
        private List<string> SeasonType01 = new List<string>();
        private List<string> ApiSeason = new List<string>();
        private List<string> StadiumID = new List<string>();

        public static List<Sql_Nba_Get_Model02> collectiondata01 = new List<Sql_Nba_Get_Model02>();


        public string[] data_array = {"first name",//0
                                      "last name",//2
                                      "player ID",//3
                                      "Team name",//4
                                      "Team ID",//5
                                      "Referee ID",//6
                                      "Referee Name",//7
                                      "stadium address",//8
                                      "stadium ID",//9
                                      "stadium Name",//10
                                      "city",//11
                                       "year",//12
        };




        public string insert_players(string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11, string input12,
                                            string input13, string input14, string input15, string input16, string input17)
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

            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[42].Parameters.Clear();
            Sql_Manager01.cmd[42].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@PlayerID", input01);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@SportsDataID", input02);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Status", input03);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@TeamID", input04);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Team", input05);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Jersey", input06);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@PositionCategory", input07);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Position", input08);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@FirstName", input09);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@LastName", input10);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthDate", input11);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthCity", input12);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthState", input13);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@BirthCountry", input14);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@GlobalTeamID", input15);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Height", input16);
            Sql_Manager01.cmd[42].Parameters.AddWithValue("@Weight", input17);
            object result = Sql_Manager01.cmd[42].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                data01[0] = "Record already exists";
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                data01[0] = "sucess"; // success text
            }
            else
            {

                data01[0] = "Unknown result from database";
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string view_all_players()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[39].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[39].ExecuteReader())
            {
                while (reader.Read())
                {

                    PlayerID.Add(int.Parse(reader["PlayerID"]?.ToString() ?? string.Empty));
                    SportsDataID.Add(reader["SportsDataID"]?.ToString() ?? string.Empty);
                    Status.Add(reader["Status"]?.ToString() ?? string.Empty);
                    TeamID.Add(reader["TeamID"]?.ToString() ?? string.Empty);
                    Team.Add(reader["Team"]?.ToString() ?? string.Empty);
                    Jersey.Add(reader["Jersey"]?.ToString() ?? string.Empty);
                    PositionCategory.Add(reader["PositionCategory"]?.ToString() ?? string.Empty);
                    Position.Add(reader["Position"]?.ToString() ?? string.Empty);
                    FirstName.Add(reader["FirstName"]?.ToString() ?? string.Empty);
                    LastName.Add(reader["LastName"]?.ToString() ?? string.Empty);
                    BirthDate.Add(reader["BirthDate"]?.ToString() ?? string.Empty);
                    BirthCity.Add(reader["BirthCity"]?.ToString() ?? string.Empty);
                    BirthState.Add(reader["BirthState"]?.ToString() ?? string.Empty);
                    BirthCountry.Add(reader["BirthCountry"]?.ToString() ?? string.Empty);
                    GlobalTeamID.Add(reader["GlobalTeamID"]?.ToString() ?? string.Empty);
                    Height.Add(reader["Height"]?.ToString() ?? string.Empty);
                    Weight.Add(reader["Weight"]?.ToString() ?? string.Empty);
                    data01[0] +=
                   $"{reader["PlayerID"].ToString()}\n" +
                   $"{reader["SportsDataID"].ToString()}\n" +
                   $"{reader["Status"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Team"].ToString()}\n" +
                   $"{reader["Jersey"].ToString()}\n" +
                   $"{reader["PositionCategory"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["FirstName"].ToString()}\n" +
                   $"{reader["LastName"].ToString()}\n" +
                   $"{reader["BirthDate"].ToString()}\n" +
                   $"{reader["BirthCity"].ToString()}\n" +
                   $"{reader["BirthState"].ToString()}\n" +
                   $"{reader["BirthCountry"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["Height"].ToString()}\n" +
                   $"{reader["Weight"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model02
                    {

                        PlayerID = reader["PlayerID"]?.ToString() ?? string.Empty,
                        SportsDataID = reader["SportsDataID"]?.ToString() ?? string.Empty,
                        Status = reader["Status"]?.ToString() ?? string.Empty,
                        TeamID = reader["TeamID"]?.ToString() ?? string.Empty,
                        Team = reader["Team"]?.ToString() ?? string.Empty,
                        Jersey = (reader["Jersey"]?.ToString() ?? string.Empty),
                        PositionCategory = reader["PositionCategory"]?.ToString() ?? string.Empty,
                        Position = reader["Position"]?.ToString() ?? string.Empty,
                        FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                        LastName = reader["LastName"]?.ToString() ?? string.Empty,
                        BirthDate = reader["BirthDate"]?.ToString() ?? string.Empty,
                        BirthCity = reader["BirthCity"]?.ToString() ?? string.Empty,
                        BirthState = reader["BirthState"]?.ToString() ?? string.Empty,
                        BirthCountry = reader["BirthCountry"]?.ToString() ?? string.Empty,
                        GlobalTeamID = reader["GlobalTeamID"]?.ToString() ?? string.Empty,
                        Height = reader["Height"]?.ToString() ?? string.Empty,
                        Weight = reader["Weight"]?.ToString() ?? string.Empty
                    };

                    collectiondata01.Add(collection_set);

                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string find_player_by_first_and_last_name(string input01, string input02)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[40].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[40].Parameters.Clear();
            Sql_Manager01.cmd[40].Parameters.AddWithValue("@FirstName", input01);
            Sql_Manager01.cmd[40].Parameters.AddWithValue("@LastName", input02);
            using (SqlDataReader reader = Sql_Manager01.cmd[40].ExecuteReader())
            {
                if (reader.Read())
                {
                    PlayerID.Add(int.Parse(reader["PlayerID"]?.ToString() ?? string.Empty));
                    SportsDataID.Add(reader["SportsDataID"]?.ToString() ?? string.Empty);
                    Status.Add(reader["Status"]?.ToString() ?? string.Empty);
                    TeamID.Add(reader["TeamID"]?.ToString() ?? string.Empty);
                    Team.Add(reader["Team"]?.ToString() ?? string.Empty);
                    Jersey.Add(reader["Jersey"]?.ToString() ?? string.Empty);
                    PositionCategory.Add(reader["PositionCategory"]?.ToString() ?? string.Empty);
                    Position.Add(reader["Position"]?.ToString() ?? string.Empty);
                    FirstName.Add(reader["FirstName"]?.ToString() ?? string.Empty);
                    LastName.Add(reader["LastName"]?.ToString() ?? string.Empty);
                    BirthDate.Add(reader["BirthDate"]?.ToString() ?? string.Empty);
                    BirthCity.Add(reader["BirthCity"]?.ToString() ?? string.Empty);
                    BirthState.Add(reader["BirthState"]?.ToString() ?? string.Empty);
                    BirthCountry.Add(reader["BirthCountry"]?.ToString() ?? string.Empty);
                    GlobalTeamID.Add(reader["GlobalTeamID"]?.ToString() ?? string.Empty);
                    Height.Add(reader["Height"]?.ToString() ?? string.Empty);
                    Weight.Add(reader["Weight"]?.ToString() ?? string.Empty);
                    data01[0] =
                   $"{reader["@PlayerID"].ToString()}\n" +
                   $"{reader["SportsDataID"].ToString()}\n" +
                   $"{reader["Status"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Team"].ToString()}\n" +
                   $"{reader["Jersey"].ToString()}\n" +
                   $"{reader["PositionCategory"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["FirstName"].ToString()}\n" +
                   $"{reader["LastName"].ToString()}\n" +
                   $"{reader["BirthDate"].ToString()}\n" +
                   $"{reader["BirthCity"].ToString()}\n" +
                   $"{reader["BirthState"].ToString()}\n" +
                   $"{reader["BirthCountry"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["Height"].ToString()}\n" +
                   $"{reader["Weight"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model02
                    {

                        PlayerID = reader["PlayerID"]?.ToString() ?? string.Empty,
                        SportsDataID = reader["SportsDataID"]?.ToString() ?? string.Empty,
                        Status = reader["Status"]?.ToString() ?? string.Empty,
                        TeamID = reader["TeamID"]?.ToString() ?? string.Empty,
                        Team = reader["Team"]?.ToString() ?? string.Empty,
                        Jersey = reader["Jersey"]?.ToString() ?? string.Empty,
                        PositionCategory = reader["PositionCategory"]?.ToString() ?? string.Empty,
                        Position = reader["Position"]?.ToString() ?? string.Empty,
                        FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                        LastName = reader["LastName"]?.ToString() ?? string.Empty,
                        BirthDate = reader["BirthDate"]?.ToString() ?? string.Empty,
                        BirthCity = reader["BirthCity"]?.ToString() ?? string.Empty,
                        BirthState = reader["BirthState"]?.ToString() ?? string.Empty,
                        BirthCountry = reader["BirthCountry"]?.ToString() ?? string.Empty,
                        GlobalTeamID = reader["GlobalTeamID"]?.ToString() ?? string.Empty,
                        Height = reader["Height"]?.ToString() ?? string.Empty,
                        Weight = reader["Weight"]?.ToString() ?? string.Empty
                    };

                    collectiondata01.Add(collection_set);

                }
                else
                {
                    data01[0] = "cant find";
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }
        public string find_player_by_id(string input01)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[41].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[41].Parameters.Clear();
            Sql_Manager01.cmd[41].Parameters.AddWithValue("@PlayerID", input01);
            using (SqlDataReader reader = Sql_Manager01.cmd[41].ExecuteReader())
            {
                if (reader.Read())
                {
                    PlayerID.Add(int.Parse(reader["PlayerID"]?.ToString() ?? string.Empty));
                    SportsDataID.Add(reader["SportsDataID"]?.ToString() ?? string.Empty);
                    Status.Add(reader["Status"]?.ToString() ?? string.Empty);
                    TeamID.Add(reader["TeamID"]?.ToString() ?? string.Empty);
                    Team.Add(reader["Team"]?.ToString() ?? string.Empty);
                    Jersey.Add(reader["Jersey"]?.ToString() ?? string.Empty);
                    PositionCategory.Add(reader["PositionCategory"]?.ToString() ?? string.Empty);
                    Position.Add(reader["Position"]?.ToString() ?? string.Empty);
                    FirstName.Add(reader["FirstName"]?.ToString() ?? string.Empty);
                    LastName.Add(reader["LastName"]?.ToString() ?? string.Empty);
                    BirthDate.Add(reader["BirthDate"]?.ToString() ?? string.Empty);
                    BirthCity.Add(reader["BirthCity"]?.ToString() ?? string.Empty);
                    BirthState.Add(reader["BirthState"]?.ToString() ?? string.Empty);
                    BirthCountry.Add(reader["BirthCountry"]?.ToString() ?? string.Empty);
                    GlobalTeamID.Add(reader["GlobalTeamID"]?.ToString() ?? string.Empty);
                    Height.Add(reader["Height"]?.ToString() ?? string.Empty);
                    Weight.Add(reader["Weight"]?.ToString() ?? string.Empty);

                    data01[0] =
                   $"{reader["PlayerID"].ToString()}\n" +
                   $"{reader["SportsDataID"].ToString()}\n" +
                   $"{reader["Status"].ToString()}\n" +
                   $"{reader["TeamID"].ToString()}\n" +
                   $"{reader["Team"].ToString()}\n" +
                   $"{reader["Jersey"].ToString()}\n" +
                   $"{reader["PositionCategory"].ToString()}\n" +
                   $"{reader["Position"].ToString()}\n" +
                   $"{reader["FirstName"].ToString()}\n" +
                   $"{reader["LastName"].ToString()}\n" +
                   $"{reader["BirthDate"].ToString()}\n" +
                   $"{reader["BirthCity"].ToString()}\n" +
                   $"{reader["BirthState"].ToString()}\n" +
                   $"{reader["BirthCountry"].ToString()}\n" +
                   $"{reader["GlobalTeamID"].ToString()}\n" +
                   $"{reader["Height"].ToString()}\n" +
                   $"{reader["Weight"].ToString()}\n";

                    var collection_set = new Sql_Nba_Get_Model02
                    {

                        PlayerID = reader["PlayerID"]?.ToString() ?? string.Empty,
                        SportsDataID = reader["SportsDataID"]?.ToString() ?? string.Empty,
                        Status = reader["Status"]?.ToString() ?? string.Empty,
                        TeamID = reader["TeamID"]?.ToString() ?? string.Empty,
                        Team = reader["Team"]?.ToString() ?? string.Empty,
                        Jersey = reader["Jersey"]?.ToString() ?? string.Empty,
                        PositionCategory = reader["PositionCategory"]?.ToString() ?? string.Empty,
                        Position = reader["Position"]?.ToString() ?? string.Empty,
                        FirstName = reader["FirstName"]?.ToString() ?? string.Empty,
                        LastName = reader["LastName"]?.ToString() ?? string.Empty,
                        BirthDate = reader["BirthDate"]?.ToString() ?? string.Empty,
                        BirthCity = reader["BirthCity"]?.ToString() ?? string.Empty,
                        BirthState = reader["BirthState"]?.ToString() ?? string.Empty,
                        BirthCountry = reader["BirthCountry"]?.ToString() ?? string.Empty,
                        GlobalTeamID = reader["GlobalTeamID"]?.ToString() ?? string.Empty,
                        Height = reader["Height"]?.ToString() ?? string.Empty,
                        Weight = reader["Weight"]?.ToString() ?? string.Empty
                    };

                    collectiondata01.Add(collection_set);

                }
                else
                {
                    data01[0] = "cant find";
                }
            }
            Sql_Manager01.conn[5].Close();
            return data01[0];
        }

    }
}