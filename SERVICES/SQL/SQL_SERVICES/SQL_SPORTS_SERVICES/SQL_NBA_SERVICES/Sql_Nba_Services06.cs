
using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_NBA_MODEL.SQL_NBA_GET_MODEL;
using Microsoft.Data.SqlClient;
using System.Data;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_NBA;

namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SPORTS_SERVICES.SQL_NBA_SERVICES
{
    internal class Sql_Nba_Services06
    {
        private static string[] data01 = new string[100];
        private List<int> StadiumID = new List<int>();
        private List<bool> Active = new List<bool>();
        private List<string> Name = new List<string>();
        private List<string> Address = new List<string>();
        private List<string> City = new List<string>();
        private List<string> State = new List<string>();
        private List<string> Zip = new List<string>();
        private List<string> Country = new List<string>();
        private List<int?> Capacity = new List<int?>();
        private List<double> GeoLat = new List<double>();
        private List<double> GeoLong = new List<double>();
        public static List<Sql_Nba_Get_Model06> collectiondata01 = new List<Sql_Nba_Get_Model06>();

        public string find_Stadium_by_Address(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[50].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[50].Parameters.Clear();
            Sql_Manager01.cmd[50].Parameters.AddWithValue("@Address", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[51].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty));
                    Active.Add(bool.Parse(reader["Active"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model06
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
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

        public string find_Stadium_by_City(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[50].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[50].Parameters.Clear();
            Sql_Manager01.cmd[50].Parameters.AddWithValue("@City", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[50].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty));
                    Active.Add(bool.Parse(reader["Active"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model06
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
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


        public string find_Stadium_by_id(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[49].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[49].Parameters.Clear();
            Sql_Manager01.cmd[49].Parameters.AddWithValue("@StadiumID", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[49].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty));
                    Active.Add(bool.Parse(reader["Active"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model06
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
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

        public string find_Stadium_by_name(string input)
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[48].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[48].Parameters.Clear();
            Sql_Manager01.cmd[48].Parameters.AddWithValue("@Name", input);
            using (SqlDataReader reader = Sql_Manager01.cmd[48].ExecuteReader())
            {
                if (reader.Read())
                {

                    StadiumID.Add(int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty));
                    Active.Add(bool.Parse(reader["Active"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model06
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
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

        public string insert_Stadium(string input01, string input02, string input03, string input04, string input05, string input06,
                                            string input07, string input08, string input09, string input10, string input11)
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
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[46].Parameters.Clear();
            Sql_Manager01.cmd[46].CommandType = CommandType.StoredProcedure;
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@StadiumID", input01);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Active", input02);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Name", input03);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Address", input04);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@City", input05);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@State", input06);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Zip", input07);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Country", input08);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@Capacity", input09);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@GeoLat", input10);
            Sql_Manager01.cmd[46].Parameters.AddWithValue("@GeoLong", input11);
            object result = Sql_Manager01.cmd[46].ExecuteScalar();

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
            return data01[0];
            ;
        }
        public string view_all_Stadium()
        {
            Sql_Manager01.conn[5].Open();
            Sql_Manager01.cmd[53].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Manager01.cmd[53].ExecuteReader())
            {
                while (reader.Read())
                {
                    StadiumID.Add(int.Parse(reader["StadiumID"]?.ToString() ?? string.Empty));
                    Active.Add(bool.Parse(reader["Active"]?.ToString() ?? string.Empty));
                    Name.Add(reader["Name"]?.ToString() ?? string.Empty);
                    Address.Add(reader["Address"]?.ToString() ?? string.Empty);
                    City.Add(reader["City"]?.ToString() ?? string.Empty);
                    State.Add(reader["State"]?.ToString() ?? string.Empty);
                    Zip.Add(reader["Zip"]?.ToString() ?? string.Empty);
                    Country.Add(reader["Country"]?.ToString() ?? string.Empty);
                    Capacity.Add(int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal) ? capacityVal : (int?)null);
                    GeoLat.Add(double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal) ? geoLatVal : 0.0);
                    GeoLong.Add(double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal) ? geoLongVal : 0.0);

                    data01[0] =
                   $"{reader["StadiumID"].ToString()}\n" +
                   $"{reader["Active"].ToString()}\n" +
                   $"{reader["Name"].ToString()}\n" +
                   $"{reader["Address"].ToString()}\n" +
                   $"{reader["City"].ToString()}\n" +
                   $"{reader["State"].ToString()}\n" +
                   $"{reader["Zip"].ToString()}\n" +
                   $"{reader["Country"].ToString()}\n" +
                   $"{reader["Capacity"].ToString()}\n" +
                   $"{reader["GeoLat"].ToString()}\n" +
                   $"{reader["GeoLong"].ToString()}\n";
                    var collection_set = new Sql_Nba_Get_Model06
                    {
                        StadiumID = int.TryParse(reader["StadiumID"]?.ToString(), out var stadiumIdVal) ? stadiumIdVal : 0,
                        Active = bool.TryParse(reader["Active"]?.ToString(), out var activeVal) ? activeVal : false,
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        City = reader["City"]?.ToString() ?? string.Empty,
                        State = reader["State"]?.ToString() ?? string.Empty,
                        Zip = reader["Zip"]?.ToString() ?? string.Empty,
                        Country = reader["Country"]?.ToString() ?? string.Empty,
                        Capacity = int.TryParse(reader["Capacity"]?.ToString(), out var capacityVal2) ? capacityVal2 : (int?)null,
                        GeoLat = double.TryParse(reader["GeoLat"]?.ToString(), out var geoLatVal2) ? geoLatVal2 : 0.0,
                        GeoLong = double.TryParse(reader["GeoLong"]?.ToString(), out var geoLongVal2) ? geoLongVal2 : 0.0,
                    };
                    collectiondata01.Add(collection_set);
                }
            }
            return data01[0];
        }

    }
}
