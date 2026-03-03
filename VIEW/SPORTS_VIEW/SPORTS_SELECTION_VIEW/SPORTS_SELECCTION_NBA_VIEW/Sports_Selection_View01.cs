using E_APP.SERVICES.SECURITY_SERVICES;
using E_APP.SERVICES.SPORTS_SERVICES.NBA;


namespace E_APP.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NBA_VIEW
{
    internal class Sports_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Nba_Services01 Nba_Serv01=new Nba_Services01();
        private int counter01 = 0;      
        public Sports_Selection_View01()
        {
            load_Sports_Selection_View01().Wait();
        }
        private async Task load_Sports_Selection_View01()
        {

            data01[0] += "GET_Seasons\n" +
                        "GET_Leagues\n" +
                        "GET_Games\n" +
                        "GET_Games_between_two_teams\n" +
                        "GET_Games_in_live\n" +
                        "GET_Games_per_season\n" +
                        "GET_Games_per_date\n" +
                        "GET_Games_per_team_and_season\n" +
                        "GET_Games_per_id\n" +
                        "GET_Teams GET_Teams_per_conference\n" +
                        "GET_Teams_per_division\n" +
                        "GET_Teams_per_codeGET_Teams_per_id\n" +
                        "GET_Teams GET_Standings\n" +
                        "GET_Standings_per_conference_and_season\n" +
                        "GET_Standings_per_division_and_season\n" +
                        "GET_Standings_per_team_and_season GET_Games_Statistics\n" +
                        "GET_Teams_Statistics\n" +
                        "GET_Players_Statistics_per_player_and_season\n" +
                        "GET_Players_Statistics_per_team_and_season\n" +
                        "GET_Players_Statistics_per_game_id GET_Search_teams()\n" +
                        "GET_Search_players()\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            if (Security_Serv01.empty_string(data01[1]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1]) == true)
                {
                    switch (int.Parse(data01[1]))
                    {
                        case 1:

                            data01[2] = await Nba_Serv01.GET_Seasons();
                            Console.WriteLine(data01[2]);
                            break;
                        case 2:

                            data01[2] = await Nba_Serv01.GET_Leagues();
                            Console.WriteLine(data01[2]);
                            break;
                        case 3:
                            data01[2] = $"enter date\n";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.date_check(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Games(data01[3]);
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }
                                
                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 4:

                            data01[2] = await Nba_Serv01.GET_Games_between_two_teams();
                            Console.WriteLine(data01[2]);
                            break;
                        case 5:

                            data01[2] = await Nba_Serv01.GET_Games_in_live();
                            Console.WriteLine(data01[2]);
                            break;
                        case 6:
                            data01[2] = $"enter year\n";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3])==true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Games_per_season(data01[3]);
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input must be only digits. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;
                                }

                            }
                            else
                            {
                                data01[2] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[2]);
                            }
      
                            break;
                        case 7:
                            data01[2] = $"enter date\n";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.date_check(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Games_per_date(data01[3]);
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 8:
                            data01[2] = $"enter year\n";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = $"enter team\n";
                                    Console.WriteLine(data01[4]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {

                                            data01[6] = await Nba_Serv01.GET_Games_per_team_and_season(data01[3], data01[5]);
                                            Console.WriteLine(data01[6]);
                                        }
                                        else
                                        {
                                            data01[6] = "Input must be only digits. Please try again.";
                                            Console.WriteLine(data01[6]);
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        data01[5] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[5]);
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 9:
                            data01[2] = $"enter team ID\n";
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Games_per_id(data01[3]);
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                            case 10:

                            data01[2] = await Nba_Serv01.GET_Teams();
                            Console.WriteLine(data01[2]);

                            break;
                            case 11:
                            data01[2] = $"enter team conference\n";
                            foreach (var a in Nba_Serv01.data_array)
                            {
                                counter01++;
                                data01[2] += $"{counter01}.) {a}\n";
                            }
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                    if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Teams_per_conference(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                 
                                }
                            
                     

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 12:
                            data01[2] = $"enter team division\n";
                            foreach (var a in Nba_Serv01.data_array01)
                            {
                                counter01++;
                                data01[2] += $"{counter01}.) {a}\n";
                            }
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Teams_per_division(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);

                                }



                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 13:
                            data01[2] = $"enter team code\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Teams_per_code(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);

                                }



                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 14:
                            data01[2] = $"enter team id\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Teams_per_id(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);

                                }



                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 15:
                            data01[2] = $"enter team id\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Teams(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);

                                }



                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 16:
                            data01[2] = $"enter season year\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = await Nba_Serv01.GET_Standings(int.Parse(data01[3]));
                                    Console.WriteLine(data01[4]);
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);

                                }



                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 17:
           
                            data01[2] = $"enter season year\n";
                  
                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = $"enter conference\n";
                                    foreach (var a in Nba_Serv01.data_array)
                                    {
                                        counter01++;
                                        data01[4] += $"{counter01}.) {a}\n";
                                    }
                                    Console.WriteLine(data01[4]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {

                                            data01[6] = await Nba_Serv01.GET_Standings_per_conference_and_season(int.Parse(data01[3]),int.Parse( data01[5]));
                                            Console.WriteLine(data01[6]);
                                        }
                                        else
                                        {
                                            data01[6] = "Input must be only digits. Please try again.";
                                            Console.WriteLine(data01[6]);
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        data01[5] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[5]);
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 18:

                            data01[2] = $"enter season year\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = $"enter divison\n";
                                    foreach (var a in Nba_Serv01.data_array01)
                                    {
                                        counter01++;
                                        data01[4] += $"{counter01}.) {a}\n";
                                    }
                                    Console.WriteLine(data01[4]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {

                                            data01[6] = await Nba_Serv01.GET_Standings_per_division_and_season(int.Parse(data01[3]), int.Parse(data01[5]));
                                            Console.WriteLine(data01[6]);
                                        }
                                        else
                                        {
                                            data01[6] = "Input must be only digits. Please try again.";
                                            Console.WriteLine(data01[6]);
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        data01[5] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[5]);
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 19:

                            data01[2] = $"enter season year\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = $"enter team id\n";
     
                                    Console.WriteLine(data01[4]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {

                                            data01[6] = await Nba_Serv01.GET_Standings_per_team_and_season(int.Parse(data01[3]), int.Parse(data01[5]));
                                            Console.WriteLine(data01[6]);
                                        }
                                        else
                                        {
                                            data01[6] = "Input must be only digits. Please try again.";
                                            Console.WriteLine(data01[6]);
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        data01[5] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[5]);
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 20:

                            data01[2] = await Nba_Serv01.GET_Games_Statistics();
                            Console.WriteLine(data01[2]);

                            break;
                        case 21:
                            data01[2] = $"enter team ID\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = $"enter season year\n";

                                    Console.WriteLine(data01[4]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {

                                            data01[6] = await Nba_Serv01.GET_Teams_Statistics(int.Parse(data01[3]), int.Parse(data01[5]));
                                            Console.WriteLine(data01[6]);
                                        }
                                        else
                                        {
                                            data01[6] = "Input must be only digits. Please try again.";
                                            Console.WriteLine(data01[6]);
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        data01[5] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[5]);
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }

                            break;
                        case 22:
                            data01[2] = $"enter team ID\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {


                                    data01[6] = await Nba_Serv01.GET_Players_Statistics_per_player_and_season(int.Parse(data01[3]));
                                    Console.WriteLine(data01[6]);

                                }
                                else
                                {
                                    data01[5] = "Input cannot be empty. Please try again.";
                                    Console.WriteLine(data01[5]);
                                }


                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }
                            break;
                        case 23:
                            data01[2] = $"enter team ID\n";

                            Console.WriteLine(data01[2]);
                            data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[3]) == true)
                                {
                                    data01[4] = $"enter season year\n";

                                    Console.WriteLine(data01[4]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[5]) == true)
                                    {
                                        if (Security_Serv01.string_only_digit(data01[5]) == true)
                                        {

                                            data01[6] = await Nba_Serv01.GET_Players_Statistics_per_team_and_season(int.Parse(data01[3]), int.Parse(data01[5]));
                                            Console.WriteLine(data01[6]);
                                        }
                                        else
                                        {
                                            data01[6] = "Input must be only digits. Please try again.";
                                            Console.WriteLine(data01[6]);
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        data01[5] = "Input cannot be empty. Please try again.";
                                        Console.WriteLine(data01[5]);
                                    }
                                }
                                else
                                {
                                    data01[4] = "Input date format is invalid. Please try again.";
                                    Console.WriteLine(data01[4]);
                                    break;

                                }

                            }
                            else
                            {
                                data01[3] = "Input cannot be empty. Please try again.";
                                Console.WriteLine(data01[3]);
                            }

                            break;
                        case 24:

                            data01[2] = await Nba_Serv01.GET_Players_Statistics_per_game_id();
                            Console.WriteLine(data01[2]);
                            break;
                        case 26:

                            data01[2] = await Nba_Serv01.GET_Search_players();
                            Console.WriteLine(data01[2]);
                            break;
              
                    }
                }
                else
                {
                    data01[2] = "Input must be only digits. Please try again.";
                    Console.WriteLine(data01[2]);

                }
            }
            else
            {
                data01[2] = "Input cannot be empty. Please try again.";
                Console.WriteLine(data01[2]);


            }



        }

    }
}