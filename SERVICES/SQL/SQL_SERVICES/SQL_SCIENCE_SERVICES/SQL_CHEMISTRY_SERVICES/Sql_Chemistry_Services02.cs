using E_APP.MODEL.SQL_MODEL.SQL_MODEL.SQL_CHEMISTRY_MODEL.SQL_CHEMISTRY_GET_MODEL;
using E_APP.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using Microsoft.Data.SqlClient;
using System.Data;


namespace E_APP.SERVICES.SQL.SQL_SERVICES.SQL_SCIENCE_SERVICES.SQL_CHEMISTRY_SERVICES
{
    internal class Sql_Chemistry_Services02
    {
        private bool status = false;
        private static string[] data01 = new string[3];
        private List<int> atomic_number = new List<int>();
        private List<string> element_name = new List<string>();
        private List<string> element_symboles = new List<string>();
        private List<string> atomic_mass = new List<string>();
        private List<int> protons = new List<int>();
        private List<int> electons = new List<int>();
        private List<int> neutrons = new List<int>();
        public List<Sql_Chemistry_Get_Model02> collectiondata01 = new List<Sql_Chemistry_Get_Model02>();


        public bool insert_element(int input01, string input02,
                                            string input03, double input04,
                                            int input05, int input06, int input07, out string output)
        {
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Open();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.Clear();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].CommandType = CommandType.StoredProcedure;
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@atomic_number", input01.ToString());
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@element_name", input02);
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@element_symboles", input03);
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@atomic_mass", input04);
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@protons ", input05);
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@electons", input06);
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].Parameters.AddWithValue("@neutrons", input07);
            object result = Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.insert_element].ExecuteScalar();

            if (result != null && result.ToString() == "EXISTS")
            {
                output = "Record already exists";
                status = true;
            }
            else if (result != null && result.ToString() == "INSERTED")
            {
                output = "success";
                status = true;
            }
            else
            {

                output = "Unknown result from database";
                status = false;
            }

            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public bool find_element_using_name(string input, out string output)
        {
            collectiondata01.Clear();
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Open();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_name].CommandType = CommandType.StoredProcedure;
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_name].Parameters.Clear();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_name].Parameters.AddWithValue("@element_name", input);
            using (SqlDataReader reader = Sql_Chemistry_Manager01.cmd[1].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),

                    };

                    collectiondata01.Add(collection_set);
                    status = true;
                }
                else
                {
                    output = "failed";
                    status = false; 
                }
            }
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Close();
            return status;
        }

        public bool find_element_using_atomic_number(string input, out string output)
        {
            collectiondata01.Clear();
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Open();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].CommandType = CommandType.StoredProcedure;
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].Parameters.Clear();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].Parameters.AddWithValue("@atomic_number", input);
            using (SqlDataReader reader = Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_atomic_number].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),
                    };

                    collectiondata01.Add(collection_set);
                    status = true;
                }
                else
                {
                    output = "failed";
                    status = false;
                }
            }
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Close();
            return (status);
        }

        public bool find_element_using_symbol(string input, out string output)
        {
            collectiondata01.Clear();
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Open();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_symbol].CommandType = CommandType.StoredProcedure;
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_symbol].Parameters.Clear();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_symbol].Parameters.AddWithValue("@element_symboles", input.Trim());
            using (SqlDataReader reader = Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.find_element_using_symbol].ExecuteReader())
            {
                if (reader.Read())
                {
                    output = $"{reader["atomic_number"].ToString()}\n" +
                                $"{reader["element_name"].ToString()}\n" +
                                $"{reader["element_symboles"].ToString()}\n" +
                                $"{reader["atomic_mass"].ToString()}\n" +
                                $"{reader["protons"].ToString()}\n" +
                                $"{reader["electons"].ToString()}\n" +
                                $"{reader["neutrons"].ToString()}\n";
                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),
                    };

                    collectiondata01.Add(collection_set);

                }
                else
                {
                    output = "failed";

                }
            }
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Close();
            return status;
        }
        public string view_all_elements()
        {
            collectiondata01.Clear();
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Open();
            Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.view_all_elements].CommandType = CommandType.StoredProcedure;
            using (SqlDataReader reader = Sql_Chemistry_Manager01.cmd[(int)Sql_Chemistry_Manager01.command_strings.view_all_elements].ExecuteReader())
            {
                while (reader.Read())
                {
                    atomic_number.Add(int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty));
                    element_name.Add(reader["element_name"]?.ToString() ?? string.Empty);
                    element_symboles.Add(reader["element_symboles"]?.ToString() ?? string.Empty);
                    atomic_mass.Add(reader["atomic_mass"]?.ToString() ?? string.Empty);
                    protons.Add(int.Parse(reader["protons"]?.ToString() ?? string.Empty));
                    electons.Add(int.Parse(reader["electons"]?.ToString() ?? string.Empty));
                    neutrons.Add(int.Parse(reader["neutrons"]?.ToString() ?? string.Empty));
                    data01[0] += $"{reader["atomic_number"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["element_name"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["element_symboles"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["atomic_mass"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["protons"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["electons"]?.ToString() ?? string.Empty}\n" +
                                 $"{reader["neutrons"]?.ToString() ?? string.Empty}\n";




                    var collection_set = new Sql_Chemistry_Get_Model02
                    {

                        atomic_number = (int.Parse(reader["atomic_number"]?.ToString() ?? string.Empty)),
                        element_name = (reader["element_name"]?.ToString() ?? string.Empty),
                        element_symboles = (reader["element_symboles"]?.ToString() ?? string.Empty),
                        atomic_mass = (reader["atomic_mass"]?.ToString() ?? string.Empty),
                        protons = (int.Parse(reader["protons"]?.ToString() ?? string.Empty)),
                        electons = (int.Parse(reader["electons"]?.ToString() ?? string.Empty)),
                        neutrons = (int.Parse(reader["neutrons"]?.ToString() ?? string.Empty)),
                    };

                    collectiondata01.Add(collection_set);

                }
            }
            data01[0] += $"{string.Join(" ", atomic_number)}\n" +
                         $"{string.Join(" ", element_name)}\n" +
                         $"{string.Join(" ", element_symboles)}\n" +
                         $"{string.Join(" ", atomic_mass)}\n" +
                         $"{string.Join(" ", protons)}\n" +
                         $"{string.Join(" ", electons)}\n" +
                         $"{string.Join(" ", neutrons)}\n";
            Sql_Chemistry_Manager01.conn[(int)Sql_Chemistry_Manager01.Connection_strings.Connection01].Close();
            return data01[1];
        }

    }
}