using E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL;
using E_MauiApp01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;


//https://rapidapi.com/api-sports/api/api-nba/playground/apiendpoint_fc1e75e8-0885-4a21-a857-62a54c69cc99
namespace E_APP.SERVICES.SPORTS_SERVICES.NBA
{
    internal class Nba_Services01
    {
        private static string[] data01 = new string[100];
        private List<string> get = new List<string>();
        private List<object> parameters = new List<object>();
        private List<object> errors = new List<object>();
        private List<int> results = new List<int>();
        private List<int> response = new List<int>();
        private List<string> date = new List<string>();
        private List<int> id = new List<int>();
        private List<string> league = new List<string>();
        private List<int> season = new List<int>();
        private List<DateTime> start = new List<DateTime>();
        private List<DateTime> end = new List<DateTime>();
        private List<string> duration = new List<string>();
        private List<object> clock = new List<object>();
        private List<bool> halftime = new List<bool>();
        private List<int> @short = new List<int>();
        private List<string> @long = new List<string>();
        private List<int> current = new List<int>();
        private List<int> total = new List<int>();
        private List<bool> endOfPeriod = new List<bool>();
        private List<string> name = new List<string>();
        private List<string> city = new List<string>();
        private List<string> state = new List<string>();
        private List<string> country = new List<string>();
        private List<int> id1 = new List<int>();
        private List<string> name1 = new List<string>();
        private List<string> nickname1 = new List<string>();
        private List<string> code1 = new List<string>();
        private List<string> logo1 = new List<string>();
        private List<int> win1 = new List<int>();
        private List<int> loss1 = new List<int>();
        private List<int> series_win1 = new List<int>();
        private List<int> series_loss1 = new List<int>();
        private List<string> linescore1 = new List<string>();
        private List<int> points1 = new List<int>();
        private List<int> id2 = new List<int>();
        private List<string> name2 = new List<string>();
        private List<string> nickname2 = new List<string>();
        private List<string> code2 = new List<string>();
        private List<string> logo2 = new List<string>();
        private List<int> win2 = new List<int>();
        private List<int> loss2 = new List<int>();
        private List<int> stage = new List<int>();
        private List<int> series_win2 = new List<int>();
        private List<int> series_loss2 = new List<int>();
        private List<string> h2h = new List<string>();
        private List<string> live = new List<string>();
        private List<string> season2 = new List<string>();
        private List<string> linescore2 = new List<string>();
        private List<int> points2 = new List<int>();
        private List<string> officials = new List<string>();
        private List<int> timesTied = new List<int>();
        private List<int> leadChanges = new List<int>();
        private List<object> nugget = new List<object>();
        private List<string> id3 = new List<string>();
        private List<object> conference = new List<object>();
        private List<object> division = new List<object>();
        private List<string> nickname = new List<string>();
        private List<string> code = new List<string>();
        private List<string> logo = new List<string>();
        private List<bool> allStar = new List<bool>();
        private List<bool> nbaFranchise = new List<bool>();
        private List<string> conference1 = new List<string>();
        private List<string> division1 = new List<string>();
        private List<string> conference2 = new List<string>();
        private List<string> division2 = new List<string>();
        private List<string> conferenc3 = new List<string>();
        private List<string> division3 = new List<string>();
        private List<string> conference4 = new List<string>();
        private List<string> division4 = new List<string>();
        private List<string> conference3 = new List<string>();
        private List<string> parametersConference = new List<string>();
        private List<string> parametersDivision = new List<string>();
        private List<string> conferenceStandard = new List<string>();
        private List<string> divisionStandard = new List<string>();
        private List<string> conferenceVegas = new List<string>();
        private List<string> divisionVegas = new List<string>();
        private List<string> conferenceUtah = new List<string>();
        private List<string> divisionUtah = new List<string>();
        private List<string> conferenceSacramento = new List<string>();
        private List<string> divisionSacramento = new List<string>();
        private List<string> parametersCode = new List<string>();
        private List<string> parametersId = new List<string>();
        private List<string> conferenceName = new List<string>();
        private List<string> conferenceRank = new List<string>();
        private List<string> conferenceWin = new List<string>();
        private List<string> conferenceLoss = new List<string>();
        private List<string> divisionName = new List<string>();
        private List<string> divisionRank = new List<string>();
        private List<string> divisionWin = new List<string>();
        private List<string> divisionLoss = new List<string>();
        private List<string> divisionGamesBehind = new List<string>();
        private List<string> winHome = new List<string>();
        private List<string> winAway = new List<string>();
        private List<string> winTotal = new List<string>();
        private List<string> winPercentage = new List<string>();
        private List<string> winLastTen = new List<string>();
        private List<string> lossHome = new List<string>();
        private List<string> lossAway = new List<string>();
        private List<string> lossTotal = new List<string>();
        private List<string> lossPercentage = new List<string>();
        private List<string> lossLastTen = new List<string>();
        private List<string> gamesBehind = new List<string>();
        private List<string> streak = new List<string>();
        private List<string> winStreak = new List<string>();
        private List<string> tieBreakerPoints = new List<string>();
        private List<string> league1 = new List<string>();
        private List<string> points = new List<string>();
        private List<string> fgm = new List<string>();
        private List<string> fga = new List<string>();
        private List<string> fgp = new List<string>();
        private List<string> ftm = new List<string>();
        private List<string> fta = new List<string>();
        private List<string> ftp = new List<string>();
        private List<string> tpm = new List<string>();
        private List<string> tpa = new List<string>();
        private List<string> tpp = new List<string>();
        private List<string> offReb = new List<string>();
        private List<string> defReb = new List<string>();
        private List<string> totReb = new List<string>();
        private List<string> games = new List<string>();
        private List<string> fastBreakPoints = new List<string>();
        private List<string> pointsInPaint = new List<string>();
        private List<string> biggestLead = new List<string>();
        private List<string> secondChancePoints = new List<string>();
        private List<string> pointsOffTurnovers = new List<string>();
        private List<string> longestRun = new List<string>();
        private List<string> pos = new List<string>();
        private List<string> min = new List<string>();
        private List<string> firstname = new List<string>();
        private List<string> lastname = new List<string>();

        public string[] data_array = { "" };
        private static Read_Textfiles READ = new Read_Textfiles();
        private static string[] Headers_ ={ "x-rapidapi-key",READ.API[0].Trim(),
         "x-rapidapi-host",  "api-nba-v1.p.rapidapi.com" };
        public async Task<string> GET_Seasons()
        {
            data01[1] = await nba_data01($"https://api-nba-v1.p.rapidapi.com/seasons");
            return data01[1];
        }
        public async Task<string> GET_Leagues()
        {
            data01[1] = await nba_data01($"https://api-nba-v1.p.rapidapi.com/leagues");
            return data01[1];
        }
        public async Task<string> GET_Games(string input)
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?date={input}");
            return data01[1];
        }
        public async Task<string> GET_Games_between_two_teams()
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?h2h=1-2");
            return data01[1];
        }
        public async Task<string> GET_Games_in_live()
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?live=all");
            return data01[1];
        }
        public async Task<string> GET_Games_per_season(string input)
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?season={input}");
            return data01[1];
        }

        public async Task<string> GET_Games_per_date(string input)
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?date={input}");
            return data01[1];
        }


        public async Task<string> GET_Games_per_team_and_season(string input, string input1)
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?season={input}&team={input1}");
            return data01[1];
        }
        public async Task<string> GET_Games_per_id(string input)
        {
            data01[1] = await nba_data02($"https://api-nba-v1.p.rapidapi.com/games?id={input}");
            return data01[1];
        }
        public async Task<string> GET_Teams()
        {
            data01[1] = await nba_data03($"https://api-nba-v1.p.rapidapi.com/teams");
            return data01[1];
        }
        public async Task<string> GET_Teams_per_conference(string input)
        {
            //input = Eastern or Western    
            data01[1] = await nba_data04($"https://api-nba-v1.p.rapidapi.com/teams?conference={input}");
            return data01[1];
        }

        public async Task<string> GET_Teams_per_division(string input)
        {
            //input = Southern , Atlantic, Central, Northwest, Pacific, Southwest   
            data01[1] = await nba_data04($"https://api-nba-v1.p.rapidapi.com/teams?division={input}");
            return data01[1];
        }


        public async Task<string> GET_Teams_per_code(string input)
        {
            //input = Southern , Atlantic, Central, Northwest, Pacific, Southwest   
            data01[1] = await nba_data04($"https://api-nba-v1.p.rapidapi.com/teams?code={input}");
            return data01[1];
        }
        public async Task<string> GET_Teams_per_id(string input)
        {
            //input = Southern , Atlantic, Central, Northwest, Pacific, Southwest   
            data01[1] = await nba_data04($"https://api-nba-v1.p.rapidapi.com/teams?id{input}");
            return data01[1];
        }
        public async Task<string> GET_Teams(string input)
        {
            //input = Southern , Atlantic, Central, Northwest, Pacific, Southwest   
            data01[1] = await nba_data04($"https://api-nba-v1.p.rapidapi.com/teams?id{input}");
            return data01[1];
        }
        public async Task<string> GET_Standings(string input)
        {

            data01[1] = await nba_data05($"https://api-nba-v1.p.rapidapi.com/standings?league=standard&season={input}");
            return data01[1];
        }
        public async Task<string> GET_Standings_per_conference_and_season(string input, string input1)
        {

            data01[1] = await nba_data05($"https://api-nba-v1.p.rapidapi.com/standings?league=standard&season={input}&conference={input1}");
            return data01[1];
        }

        public async Task<string> GET_Standings_per_division_and_season(string input, string input1)
        {

            data01[1] = await nba_data05($"https://api-nba-v1.p.rapidapi.com/standings?league=standard&season={input}&conference={input1}");
            return data01[1];
        }
        public async Task<string> GET_Standings_per_team_and_season(string input, string input1)
        {

            data01[1] = await nba_data05($"https://api-nba-v1.p.rapidapi.com/standings?league=standard&season={input}&team={input1}");
            return data01[1];
        }
        public async Task<string> GET_Games_Statistics()
        {

            data01[1] = await nba_data06($"https://api-nba-v1.p.rapidapi.com/games/statistics?id=10403");
            return data01[1];
        }
        public async Task<string> GET_Teams_Statistics(string input, string input1)
        {

            data01[1] = await nba_data07($"https://api-nba-v1.p.rapidapi.com/teams/statistics?id={input}&season={input1}");
            return data01[1];
        }
        public async Task<string> GET_Players_Statistics_per_player_and_season(string input)
        {

            data01[1] = await nba_data08($"https://api-nba-v1.p.rapidapi.com/players/statistics?id=236&season={input}");
            return data01[1];
        }
        public async Task<string> GET_Players_Statistics_per_team_and_season(string input,string input1)
        {   

            data01[1] = await nba_data08($"https://api-nba-v1.p.rapidapi.com/players/statistics?team={input}&season={input1}");
            return data01[1];
        }
        private async Task<string> nba_data01(string input)
        {
            using var client = new HttpClient();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var StatusCode = await client.SendAsync(request))
            {
                StatusCode.EnsureSuccessStatusCode();
                var body = await StatusCode.Content.ReadAsStringAsync();

                Nba_Get_Model01.Root roots =
                    JsonConvert.DeserializeObject<Nba_Get_Model01.Root>(body);

                if (roots != null)
                {
                    get.Add(roots.get);
                    parameters.Add(roots.parameters);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    response.Add(roots.response != null && roots.response.Count > 0
                        ? roots.response[0]
                        : 0);
                }
                else
                {
                    get.Add(string.Empty);
                    parameters.Add(null);
                    errors.Add(null);
                    results.Add(0);
                    response.Add(0);
                }

                int minCount = new[]
                {
            get.Count,
            parameters.Count,
            errors.Count,
            results.Count,
            response.Count
        }.Min();

                for (int i = 0; i < minCount; i++)
                {
                    data01[0] +=
                        $"get: {get[i]}\n" +
                        $"parameters: {parameters[i]}\n" +
                        $"errors: {errors[i]}\n" +
                        $"results: {results[i]}\n" +
                        $"response: {response[i]}\n";
                }

                data01[1] +=
                    $"{string.Join(" ", get)}" +
                    $"{string.Join(" ", parameters)}" +
                    $"{string.Join(" ", errors)}" +
                    $"{string.Join(" ", results)}" +
                    $"{string.Join(" ", response)}";

                return data01[0];
            }
        }
        private async Task<string> nba_data02(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model02.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model02.Root>(body);

                if (roots != null)
                {
                    get.Add(roots.get);
                    date.Add(roots.parameters?.date ?? string.Empty);
                    h2h.Add(roots.parameters?.h2h ?? string.Empty);
                    id3.Add(roots.parameters?.id ?? string.Empty);
                    live.Add(roots.parameters?.live ?? string.Empty);
                    season2.Add(roots.parameters?.season ?? string.Empty);
                    errors.Add(roots.errors);
                    results.Add(roots.results);

                    if (roots.response != null)
                    {
                        foreach (var a in roots.response)
                        {

                            id.Add(a.id);
                            league.Add(a.league);
                            season.Add(a.season);
                            stage.Add(a.stage);
                            start.Add(a.date?.start ?? default);
                            end.Add(a.date?.end ?? default);
                            duration.Add(a.date?.duration ?? string.Empty);
                            clock.Add(a.status?.clock);
                            halftime.Add(a.status?.halftime ?? false);
                            @short.Add(a.status?.@short ?? 0);
                            @long.Add(a.status?.@long ?? string.Empty);
                            current.Add(a.periods?.current ?? 0);
                            total.Add(a.periods?.total ?? 0);
                            endOfPeriod.Add(a.periods?.endOfPeriod ?? false);
                            name.Add(a.arena?.name ?? string.Empty);
                            city.Add(a.arena?.city ?? string.Empty);
                            state.Add(a.arena?.state ?? string.Empty);
                            country.Add(a.arena?.country ?? string.Empty);
                            id1.Add(a.teams?.home?.id ?? 0);
                            name1.Add(a.teams?.home?.name ?? string.Empty);
                            nickname1.Add(a.teams?.home?.nickname ?? string.Empty);
                            code1.Add(a.teams?.home?.code ?? string.Empty);
                            logo1.Add(a.teams?.home?.logo ?? string.Empty);
                            win1.Add(a.teams?.home?.win ?? 0);
                            loss1.Add(a.teams?.home?.loss ?? 0);
                            series_win1.Add(a.teams?.home?.series?.win ?? 0);
                            series_loss1.Add(a.teams?.home?.series?.loss ?? 0);

                            if (a.teams?.home?.linescore != null && a.teams.home.linescore.Count > 0)
                            {
                                foreach (var b in a.teams.home.linescore)
                                {

                                    linescore1.Add(b);

                                }


                            }
                            else
                            {
                                linescore1.Add(string.Empty);
                            }


                            points1.Add(a.scores?.home?.points ?? 0);
                            id2.Add(a.teams?.visitors?.id ?? 0);
                            name2.Add(a.teams?.visitors?.name ?? string.Empty);
                            nickname2.Add(a.teams?.visitors?.nickname ?? string.Empty);
                            code2.Add(a.teams?.visitors?.code ?? string.Empty);
                            logo2.Add(a.teams?.visitors?.logo ?? string.Empty);
                            win2.Add(a.teams?.visitors?.win ?? 0);
                            loss2.Add(a.teams?.visitors?.loss ?? 0);
                            series_win2.Add(a.teams?.visitors?.series?.win ?? 0);
                            series_loss2.Add(a.teams?.visitors?.series?.loss ?? 0);

                            if (a.teams?.visitors?.linescore != null && a.teams.visitors.linescore.Count > 0)
                            {
                                foreach (var b in a.teams.visitors.linescore)
                                {
                                    linescore2.Add(b);
                                }

                            }
                            else

                            {
                                linescore2.Add(string.Empty);
                            }


                            points2.Add(a.scores?.visitors?.points ?? 0);

                            if (a.officials != null && a.officials.Count > 0)
                            {
                                foreach (var off in a.officials)
                                    officials.Add(off);
                            }
                            else
                                officials.Add(string.Empty);
                            timesTied.Add(a.timesTied);
                            leadChanges.Add(a.leadChanges);
                            nugget.Add(a.nugget?.ToString() ?? string.Empty);
                        }
                    }
                }
                else

                    get.Add(string.Empty);
                date.Add(string.Empty);
                h2h.Add(string.Empty);
                live.Add(string.Empty);
                id3.Add(string.Empty);
                season2.Add(string.Empty);
                errors.Add(null);
                results.Add(0);
            }

            int minCount = new[]
            {
            get.Count,
            date.Count,
            h2h.Count,
            live.Count,
            id3.Count,
            season2.Count,
            errors.Count,
            results.Count,
            id.Count,
            league.Count,
            season.Count,
            stage.Count,
            start.Count,
            end.Count,
            duration.Count,
            clock.Count,
            halftime.Count,
            @short.Count,
            @long.Count,
            current.Count,
            total.Count,
            endOfPeriod.Count,
            name.Count,
            city.Count,
            state.Count,
            country.Count,
            id1.Count,
            name1.Count,
            nickname1.Count,
            code1.Count,
            logo1.Count,
            win1.Count,
            loss1.Count,
            series_win1.Count,
            series_loss1.Count,
            linescore1.Count,
            points1.Count,
            id2.Count,
            name2.Count,
            nickname2.Count,
            code2.Count,
            logo2.Count,
            win2.Count,
            loss2.Count,
            series_win2.Count,
            series_loss2.Count,
            linescore2.Count,
            points2.Count,
            officials.Count,
            timesTied.Count,
            leadChanges.Count,
            nugget.Count
        }.Min();

            for (int i = 0; i < minCount; i++)
            {
                data01[0] +=
                    $"get: {get[i]} " +
                    $"date: {date[i]} " +
                    $"h2h: {h2h[i]} " +
                    $"live: {live[i]} " +
                    $"id3: {id3[i]} " +
                    $"season2: {season2[i]} " +
                    $"errors: {errors[i]} " +
                    $"results: {results[i]} " +
                    $"id: {id[i]} " +
                    $"league: {league[i]} " +
                    $"season: {season[i]} " +
                    $"stage: {stage[i]} " +
                    $"start: {start[i]} " +
                    $"end: {end[i]} " +
                    $"duration: {duration[i]} " +
                    $"clock: {clock[i]} " +
                    $"halftime: {halftime[i]} " +
                    $"short: {@short[i]} " +
                    $"long: {@long[i]} " +
                    $"current: {current[i]} " +
                    $"total: {total[i]} " +
                    $"endOfPeriod: {endOfPeriod[i]} " +
                    $"arenaName: {name[i]} " +
                    $"city: {city[i]} " +
                    $"state: {state[i]} " +
                    $"country: {country[i]} " +
                    $"homeID: {id1[i]} " +
                    $"homeName: {name1[i]} " +
                    $"homeNickname: {nickname1[i]} " +
                    $"homeCode: {code1[i]} " +
                    $"homeLogo: {logo1[i]} " +
                    $"homeWin: {win1[i]} " +
                    $"homeLoss: {loss1[i]} " +
                    $"homeSeriesWin: {series_win1[i]} " +
                    $"homeSeriesLoss: {series_loss1[i]} " +
                    $"homeLinescore: {linescore1[i]} " +
                    $"homePoints: {points1[i]} " +
                    $"visitID: {id2[i]} " +
                    $"visitName: {name2[i]} " +
                    $"visitNickname: {nickname2[i]} " +
                    $"visitCode: {code2[i]} " +
                    $"visitLogo: {logo2[i]} " +
                    $"visitWin: {win2[i]} " +
                    $"visitLoss: {loss2[i]} " +
                    $"visitSeriesWin: {series_win2[i]} " +
                    $"visitSeriesLoss: {series_loss2[i]} " +
                    $"visitLinescore: {linescore2[i]} " +
                    $"visitPoints: {points2[i]} " +
                    $"officials: {officials[i]} " +
                    $"timesTied: {timesTied[i]} " +
                    $"leadChanges: {leadChanges[i]} " +
                    $"nugget: {nugget[i]}\n";
            }

            data01[1] =
                $"{string.Join(" ", get)} " +
                $"{string.Join(" ", date)} " +
                $"{string.Join(" ", h2h)} " +
                $"{string.Join(" ", live)} " +
                $"{string.Join(" ", id3)} " +
                $"{string.Join(" ", season2)} " +
                $"{string.Join(" ", errors)} " +
                $"{string.Join(" ", results)} " +
                $"{string.Join(" ", id)} " +
                $"{string.Join(" ", league)} " +
                $"{string.Join(" ", season)} " +
                $"{string.Join(" ", stage)} " +
                $"{string.Join(" ", start)} " +
                $"{string.Join(" ", end)} " +
                $"{string.Join(" ", duration)} " +
                $"{string.Join(" ", clock)} " +
                $"{string.Join(" ", halftime)} " +
                $"{string.Join(" ", @short)} " +
                $"{string.Join(" ", @long)} " +
                $"{string.Join(" ", current)} " +
                $"{string.Join(" ", total)} " +
                $"{string.Join(" ", endOfPeriod)} " +
                $"{string.Join(" ", name)} " +
                $"{string.Join(" ", city)} " +
                $"{string.Join(" ", state)} " +
                $"{string.Join(" ", country)} " +
                $"{string.Join(" ", id1)} " +
                $"{string.Join(" ", name1)} " +
                $"{string.Join(" ", nickname1)} " +
                $"{string.Join(" ", code1)} " +
                $"{string.Join(" ", logo1)} " +
                $"{string.Join(" ", win1)} " +
                $"{string.Join(" ", loss1)} " +
                $"{string.Join(" ", series_win1)} " +
                $"{string.Join(" ", series_loss1)} " +
                $"{string.Join(" ", linescore1)} " +
                $"{string.Join(" ", points1)} " +
                $"{string.Join(" ", id2)} " +
                $"{string.Join(" ", name2)} " +
                $"{string.Join(" ", nickname2)} " +
                $"{string.Join(" ", code2)} " +
                $"{string.Join(" ", logo2)} " +
                $"{string.Join(" ", win2)} " +
                $"{string.Join(" ", loss2)} " +
                $"{string.Join(" ", series_win2)} " +
                $"{string.Join(" ", series_loss2)} " +
                $"{string.Join(" ", linescore2)} " +
                $"{string.Join(" ", points2)} " +
                $"{string.Join(" ", officials)} " +
                $"{string.Join(" ", timesTied)} " +
                $"{string.Join(" ", leadChanges)} " +
                $"{string.Join(" ", nugget)}";

            return data01[0];
        }

        private async Task<string> nba_data03(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model03.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model03.Root>(body);

                if (roots != null)
                {
                    get.Add(roots.get);
                    errors.Add(roots.errors);
                    results.Add(roots.results);

                    if (roots.response != null && roots.response.Count > 0)
                    {
                        foreach (var a in roots.response)
                        {
                            id3.Add(a.id.ToString());
                            name.Add(a.name);
                            nickname.Add(a.nickname);
                            code.Add(a.code);
                            city.Add(a.city);
                            logo.Add(a.logo);
                            allStar.Add(a.allStar);
                            nbaFranchise.Add(a.nbaFranchise);
                            conference1.Add(a.leagues?.standard?.conference ?? string.Empty);
                            division1.Add(a.leagues?.standard?.division ?? string.Empty);
                            conference2.Add(a.leagues?.vegas?.conference ?? string.Empty);
                            division2.Add(a.leagues?.vegas?.division ?? string.Empty);
                            conference3.Add(a.leagues?.utah?.conference ?? string.Empty);
                            division3.Add(a.leagues?.utah?.division ?? string.Empty);
                            conference4.Add(a.leagues?.sacramento?.conference ?? string.Empty);
                            division4.Add(a.leagues?.sacramento?.division ?? string.Empty);
                            conference.Add(a.leagues?.africa?.conference?.ToString() ?? string.Empty);
                            division.Add(a.leagues?.africa?.division?.ToString() ?? string.Empty);
                        }
                    }
                    else
                    {

                        id3.Add(string.Empty);
                        name.Add(string.Empty);
                        nickname.Add(string.Empty);
                        code.Add(string.Empty);
                        city.Add(string.Empty);
                        logo.Add(string.Empty);
                        allStar.Add(false);
                        nbaFranchise.Add(false);
                        conference1.Add(string.Empty);
                        division1.Add(string.Empty);
                        conference2.Add(string.Empty);
                        division2.Add(string.Empty);
                        conference3.Add(string.Empty);
                        division3.Add(string.Empty);
                        conference4.Add(string.Empty);
                        division4.Add(string.Empty);
                        conference.Add(string.Empty);
                        division.Add(string.Empty);
                    }
                }
                else
                {

                    get.Add(string.Empty);
                    errors.Add(null);
                    results.Add(0);
                    id3.Add(string.Empty);
                    name.Add(string.Empty);
                    nickname.Add(string.Empty);
                    code.Add(string.Empty);
                    city.Add(string.Empty);
                    logo.Add(string.Empty);
                    allStar.Add(false);
                    nbaFranchise.Add(false);
                    conference1.Add(string.Empty);
                    division1.Add(string.Empty);
                    conference2.Add(string.Empty);
                    division2.Add(string.Empty);
                    conference3.Add(string.Empty);
                    division3.Add(string.Empty);
                    conference4.Add(string.Empty);
                    division4.Add(string.Empty);
                    conference.Add(string.Empty);
                    division.Add(string.Empty);
                }

                int minCount = new[]
                {
            get.Count,
            errors.Count,
            results.Count,
            id3.Count,
            name.Count,
            nickname.Count,
            code.Count,
            city.Count,
            logo.Count,
            allStar.Count,
            nbaFranchise.Count,
            conference1.Count,
            division1.Count,
            conference2.Count,
            division2.Count,
            conference3.Count,
            division3.Count,
            conference4.Count,
            division4.Count,
            conference.Count,
            division.Count
        }.Min();
                for (int i = 0; i < minCount; i++)
                {
                    data01[0] +=
                        $"get: {get[i]} " +
                        $"errors: {errors[i]} " +
                        $"results: {results[i]} " +
                        $"id3: {id3[i]} " +
                        $"name: {name[i]} " +
                        $"nickname: {nickname[i]} " +
                        $"code: {code[i]} " +
                        $"city: {city[i]} " +
                        $"logo: {logo[i]} " +
                        $"allStar: {allStar[i]} " +
                        $"nbaFranchise: {nbaFranchise[i]} " +
                        $"conference1: {conference1[i]} " +
                        $"division1: {division1[i]} " +
                        $"conference2: {conference2[i]} " +
                        $"division2: {division2[i]} " +
                        $"conference3: {conference3[i]} " +
                        $"division3: {division3[i]} " +
                        $"conference4: {conference4[i]} " +
                        $"division4: {division4[i]} " +
                        $"conference: {conference[i]} " +
                        $"division: {division[i]}\n";
                }
                data01[1] =
                    $"{string.Join(" ", get)} " +
                    $"{string.Join(" ", errors)} " +
                    $"{string.Join(" ", results)} " +
                    $"{string.Join(" ", id3)} " +
                    $"{string.Join(" ", name)} " +
                    $"{string.Join(" ", nickname)} " +
                    $"{string.Join(" ", code)} " +
                    $"{string.Join(" ", city)} " +
                    $"{string.Join(" ", logo)} " +
                    $"{string.Join(" ", allStar)} " +
                    $"{string.Join(" ", nbaFranchise)} " +
                    $"{string.Join(" ", conference1)} " +
                    $"{string.Join(" ", division1)} " +
                    $"{string.Join(" ", conference2)} " +
                    $"{string.Join(" ", division2)} " +
                    $"{string.Join(" ", conference3)} " +
                    $"{string.Join(" ", division3)} " +
                    $"{string.Join(" ", conference4)} " +
                    $"{string.Join(" ", division4)} " +
                    $"{string.Join(" ", conference)} " +
                    $"{string.Join(" ", division)}";

                return data01[0];
            }
        }

        private async Task<string> nba_data04(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model04.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model04.Root>(body);
                if (roots != null)
                {

                    get.Add(roots.get);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    parametersConference.Add(roots.parameters?.conference ?? string.Empty);
                    parametersDivision.Add(roots.parameters?.division ?? string.Empty);
                    parametersCode.Add(roots.parameters?.code ?? string.Empty);
                    parametersId.Add(roots.parameters?.id ?? string.Empty);

                    if (roots.response != null && roots.response.Count > 0)
                    {
                        foreach (var item in roots.response)
                        {
                            id3.Add(item.id.ToString());
                            name.Add(item.name);
                            nickname.Add(item.nickname);
                            code.Add(item.code);
                            city.Add(item.city);
                            logo.Add(item.logo);
                            allStar.Add(item.allStar);
                            nbaFranchise.Add(item.nbaFranchise);
                            conferenceStandard.Add(item.leagues?.standard?.conference ?? string.Empty);
                            divisionStandard.Add(item.leagues?.standard?.division ?? string.Empty);
                            conferenceVegas.Add(item.leagues?.vegas?.conference ?? string.Empty);
                            divisionVegas.Add(item.leagues?.vegas?.division ?? string.Empty);
                            conferenceUtah.Add(item.leagues?.utah?.conference ?? string.Empty);
                            divisionUtah.Add(item.leagues?.utah?.division ?? string.Empty);
                            conferenceSacramento.Add(item.leagues?.sacramento?.conference ?? string.Empty);
                            divisionSacramento.Add(item.leagues?.sacramento?.division ?? string.Empty);
                        }
                    }
                    else
                    {

                        id3.Add(string.Empty);
                        name.Add(string.Empty);
                        nickname.Add(string.Empty);
                        code.Add(string.Empty);
                        city.Add(string.Empty);
                        logo.Add(string.Empty);
                        allStar.Add(false);
                        nbaFranchise.Add(false);

                        conferenceStandard.Add(string.Empty);
                        divisionStandard.Add(string.Empty);
                        conferenceVegas.Add(string.Empty);
                        divisionVegas.Add(string.Empty);
                        conferenceUtah.Add(string.Empty);
                        divisionUtah.Add(string.Empty);
                        conferenceSacramento.Add(string.Empty);
                        divisionSacramento.Add(string.Empty);

                        parametersConference.Add(string.Empty);
                        parametersDivision.Add(string.Empty);
                    }
                }
                else
                {
                    get.Add(string.Empty);
                    errors.Add(null);
                    results.Add(0);
                    parametersConference.Add(string.Empty);
                    parametersDivision.Add(string.Empty);
                }
                int minCount = new[]
                {
            get.Count,
            errors.Count,
            results.Count,
            parametersConference.Count,
            parametersDivision.Count,
            id3.Count,
            name.Count,
            nickname.Count,
            code.Count,
            city.Count,
            logo.Count,
            allStar.Count,
            nbaFranchise.Count,
            conferenceStandard.Count,
            divisionStandard.Count,
            conferenceVegas.Count,
            divisionVegas.Count,
            conferenceUtah.Count,
            divisionUtah.Count,
            conferenceSacramento.Count,
            divisionSacramento.Count
        }.Min();

                for (int i = 0; i < minCount; i++)
                {
                    data01[0] +=
                        $"get: {get[i]} " +
                        $"errors: {errors[i]} " +
                        $"results: {results[i]} " +
                        $"paramConf: {parametersConference[i]} " +
                        $"paramDiv: {parametersDivision[i]} " +
                        $"id3: {id3[i]} " +
                        $"name: {name[i]} " +
                        $"nickname: {nickname[i]} " +
                        $"code: {code[i]} " +
                        $"city: {city[i]} " +
                        $"logo: {logo[i]} " +
                        $"allStar: {allStar[i]} " +
                        $"nbaFranchise: {nbaFranchise[i]} " +
                        $"stdConf: {conferenceStandard[i]} " +
                        $"stdDiv: {divisionStandard[i]} " +
                        $"vegConf: {conferenceVegas[i]} " +
                        $"vegDiv: {divisionVegas[i]} " +
                        $"utaConf: {conferenceUtah[i]} " +
                        $"utaDiv: {divisionUtah[i]} " +
                        $"sacConf: {conferenceSacramento[i]} " +
                        $"sacDiv: {divisionSacramento[i]}\n";
                }
                data01[1] =
                    $"{string.Join(" ", get)} " +
                    $"{string.Join(" ", errors)} " +
                    $"{string.Join(" ", results)} " +
                    $"{string.Join(" ", parametersConference)} " +
                    $"{string.Join(" ", parametersDivision)} " +
                    $"{string.Join(" ", id3)} " +
                    $"{string.Join(" ", name)} " +
                    $"{string.Join(" ", nickname)} " +
                    $"{string.Join(" ", code)} " +
                    $"{string.Join(" ", city)} " +
                    $"{string.Join(" ", logo)} " +
                    $"{string.Join(" ", allStar)} " +
                    $"{string.Join(" ", nbaFranchise)} " +
                    $"{string.Join(" ", conferenceStandard)} " +
                    $"{string.Join(" ", divisionStandard)} " +
                    $"{string.Join(" ", conferenceVegas)} " +
                    $"{string.Join(" ", divisionVegas)} " +
                    $"{string.Join(" ", conferenceUtah)} " +
                    $"{string.Join(" ", divisionUtah)} " +
                    $"{string.Join(" ", conferenceSacramento)} " +
                    $"{string.Join(" ", divisionSacramento)}";

                return data01[0];
            }
        }
        private async Task<string> nba_data05(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model05.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model05.Root>(body);
                if (roots != null)
                {
                    get.Add(roots.get);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    league.Add(roots.parameters?.league ?? string.Empty);
                    season2.Add(roots.parameters?.season ?? string.Empty);
                    if (roots.response != null && roots.response.Count > 0)
                    {
                        foreach (var item in roots.response)
                        {
                            league1.Add(item.league);
                            season.Add(int.Parse(item.season.ToString()));
                            id3.Add(item.team?.id.ToString() ?? string.Empty);
                            name.Add(item.team?.name ?? string.Empty);
                            nickname.Add(item.team?.nickname ?? string.Empty);
                            code.Add(item.team?.code ?? string.Empty);
                            logo.Add(item.team?.logo ?? string.Empty);
                            conferenceName.Add(item.conference?.name ?? string.Empty);
                            conferenceRank.Add(item.conference?.rank.ToString() ?? string.Empty);
                            conferenceWin.Add(item.conference?.win.ToString() ?? string.Empty);
                            conferenceLoss.Add(item.conference?.loss.ToString() ?? string.Empty);
                            divisionName.Add(item.division?.name ?? string.Empty);
                            divisionRank.Add(item.division?.rank.ToString() ?? string.Empty);
                            divisionWin.Add(item.division?.win.ToString() ?? string.Empty);
                            divisionLoss.Add(item.division?.loss.ToString() ?? string.Empty);
                            divisionGamesBehind.Add(item.division?.gamesBehind ?? string.Empty);
                            winHome.Add(item.win?.home.ToString() ?? string.Empty);
                            winAway.Add(item.win?.away.ToString() ?? string.Empty);
                            winTotal.Add(item.win?.total.ToString() ?? string.Empty);
                            winPercentage.Add(item.win?.percentage ?? string.Empty);
                            winLastTen.Add(item.win?.lastTen.ToString() ?? string.Empty);
                            lossHome.Add(item.loss?.home.ToString() ?? string.Empty);
                            lossAway.Add(item.loss?.away.ToString() ?? string.Empty);
                            lossTotal.Add(item.loss?.total.ToString() ?? string.Empty);
                            lossPercentage.Add(item.loss?.percentage ?? string.Empty);
                            lossLastTen.Add(item.loss?.lastTen.ToString() ?? string.Empty);
                            gamesBehind.Add(item.gamesBehind ?? string.Empty);
                            streak.Add(item.streak.ToString());
                            winStreak.Add(item.winStreak.ToString());
                            tieBreakerPoints.Add(item.tieBreakerPoints?.ToString() ?? string.Empty);
                        }
                        int minCount = new[]
        {                    get.Count,
                             errors.Count,
                             results.Count,
                             league1.Count,
                             season.Count,
                             id3.Count,
                              name.Count,
                              nickname.Count,
                              code.Count,
                               logo.Count,
                                conferenceName.Count,
                                conferenceRank.Count,
                                conferenceWin.Count,
                                conferenceLoss.Count,
                                divisionName.Count,
                                divisionRank.Count,
                                divisionWin.Count,
                                divisionLoss.Count,
                                divisionGamesBehind.Count,
                                winHome.Count,
                                winAway.Count,
                                winTotal.Count,
                                winPercentage.Count,
                                winLastTen.Count,
                                lossHome.Count,
                                lossAway.Count,
                                lossTotal.Count,
                                lossPercentage.Count,
                                lossLastTen.Count,
                                gamesBehind.Count,
                                streak.Count,
                                winStreak.Count,
                                tieBreakerPoints.Count

                        }.Min();
                        for (int i = 0; i < minCount; i++)
                        {
                            data01[0] +=
                                $"get: {get[i]} " +
                                $"errors: {errors[i]} " +
                                $"results: {results[i]} " +
                                $"league1: {league1[i]} " +
                                $"season: {season[i]} " +
                                $"id3: {id3[i]} " +
                                $"name: {name[i]} " +
                                $"nickname: {nickname[i]} " +
                                $"code: {code[i]} " +
                                $"logo: {logo[i]} " +
                                $"conferenceName: {conferenceName[i]} " +
                                $"conferenceRank: {conferenceRank[i]} " +
                                $"conferenceWin: {conferenceWin[i]} " +
                                $"conferenceLoss: {conferenceLoss[i]} " +
                                $"divisionName: {divisionName[i]} " +
                                $"divisionRank: {divisionRank[i]} " +
                                $"divisionWin: {divisionWin[i]} " +
                                $"divisionLoss: {divisionLoss[i]} " +
                                $"divisionGamesBehind: {divisionGamesBehind[i]} " +
                                $"winHome: {winHome[i]} " +
                                $"winAway: {winAway[i]} " +
                                $"winTotal: {winTotal[i]} " +
                                $"winPercentage: {winPercentage[i]} " +
                                $"winLastTen: {winLastTen[i]} " +
                                $"lossHome: {lossHome[i]} " +
                                $"lossAway: {lossAway[i]} " +
                                $"lossTotal: {lossTotal[i]} " +
                                $"lossPercentage: {lossPercentage[i]} " +
                                $"lossLastTen: {lossLastTen[i]} " +
                                $"gamesBehind: {gamesBehind[i]} " +
                                $"streak: {streak[i]} " +
                                $"winStreak: {winStreak[i]} " +
                                $"tieBreakerPoints: {tieBreakerPoints[i]}\n";
                        }
                        data01[1] =
                            $"{string.Join(" ", get)} " +
                            $"{string.Join(" ", errors)} " +
                            $"{string.Join(" ", results)} " +
                            $"{string.Join(" ", league1)} " +
                            $"{string.Join(" ", season)} " +
                            $"{string.Join(" ", id3)} " +
                            $"{string.Join(" ", name)} " +
                            $"{string.Join(" ", nickname)} " +
                            $"{string.Join(" ", code)} " +
                            $"{string.Join(" ", logo)} " +
                            $"{string.Join(" ", conferenceName)} " +
                            $"{string.Join(" ", conferenceRank)} " +
                            $"{string.Join(" ", conferenceWin)} " +
                            $"{string.Join(" ", conferenceLoss)} " +
                            $"{string.Join(" ", divisionName)} " +
                            $"{string.Join(" ", divisionRank)} " +
                            $"{string.Join(" ", divisionWin)} " +
                            $"{string.Join(" ", divisionLoss)} " +
                            $"{string.Join(" ", divisionGamesBehind)} " +
                            $"{string.Join(" ", winHome)} " +
                            $"{string.Join(" ", winAway)} " +
                            $"{string.Join(" ", winTotal)} " +
                            $"{string.Join(" ", winPercentage)} " +
                            $"{string.Join(" ", winLastTen)} " +
                            $"{string.Join(" ", lossHome)} " +
                            $"{string.Join(" ", lossAway)} " +
                            $"{string.Join(" ", lossTotal)} " +
                            $"{string.Join(" ", lossPercentage)} " +
                            $"{string.Join(" ", lossLastTen)} " +
                            $"{string.Join(" ", gamesBehind)} " +
                            $"{string.Join(" ", streak)} " +
                            $"{string.Join(" ", winStreak)} " +
                            $"{string.Join(" ", tieBreakerPoints)}";
                    }
                    else
                    {
                        league1.Add(string.Empty);
                        season.Add(0);
                        id3.Add(string.Empty);
                        name.Add(string.Empty);
                        nickname.Add(string.Empty);
                        code.Add(string.Empty);
                        logo.Add(string.Empty);
                        conferenceName.Add(string.Empty);
                        conferenceRank.Add(string.Empty);
                        conferenceWin.Add(string.Empty);
                        conferenceLoss.Add(string.Empty);
                        divisionName.Add(string.Empty);
                        divisionRank.Add(string.Empty);
                        divisionWin.Add(string.Empty);
                        divisionLoss.Add(string.Empty);
                        divisionGamesBehind.Add(string.Empty);
                        winHome.Add(string.Empty);
                        winAway.Add(string.Empty);
                        winTotal.Add(string.Empty);
                        winPercentage.Add(string.Empty);
                        winLastTen.Add(string.Empty);
                        lossHome.Add(string.Empty);
                        lossAway.Add(string.Empty);
                        lossTotal.Add(string.Empty);
                        lossPercentage.Add(string.Empty);
                        lossLastTen.Add(string.Empty);
                        gamesBehind.Add(string.Empty);
                        streak.Add(string.Empty);
                        winStreak.Add(string.Empty);
                        tieBreakerPoints.Add(string.Empty);
                    }
                }
                else
                {
                    get.Add(string.Empty);
                    errors.Add(null);
                    results.Add(0);

                }
                return data01[0];
            }
        }
        private async Task<string> nba_data06(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model06.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model06.Root>(body);
                if (roots != null)
                {
                    get.Add(roots.get);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    if (roots.response != null && roots.response.Count > 0)
                    {
                        foreach (var item in roots.response)
                        {
                            id3.Add(item.team?.id.ToString() ?? string.Empty);
                            name.Add(item.team?.name ?? string.Empty);
                            nickname.Add(item.team?.nickname ?? string.Empty);
                            code.Add(item.team?.code ?? string.Empty);
                            logo.Add(item.team?.logo ?? string.Empty);
                            if (item.statistics != null && item.statistics.Count > 0)
                            {
                                foreach (var stats in item.statistics)
                                {
                                    points.Add(stats.points.ToString());
                                    fgm.Add(stats.fgm.ToString());
                                    fga.Add(stats.fga.ToString());
                                    fgp.Add(stats.fgp);
                                    ftm.Add(stats.ftm.ToString());
                                    fta.Add(stats.fta.ToString());
                                    ftp.Add(stats.ftp);
                                    tpm.Add(stats.tpm.ToString());
                                    tpa.Add(stats.tpa.ToString());
                                    tpp.Add(stats.tpp);
                                    offReb.Add(stats.offReb.ToString());
                                    defReb.Add(stats.defReb.ToString());
                                    totReb.Add(stats.totReb.ToString());


                                }
                                int minCount = new[]
                                {
                                    get.Count,
                                    errors.Count,
                                    results.Count,
                                    id3.Count,
                                    name.Count,
                                    nickname.Count,
                                    code.Count,
                                    logo.Count,
                                    points.Count,
                                    fgm.Count,
                                    fga.Count,
                                    fgp.Count,
                                    ftm.Count,
                                    fta.Count,
                                    ftp.Count,
                                    tpm.Count,
                                    tpa.Count,
                                    tpp.Count,
                                    offReb.Count,
                                    defReb.Count,
                                    totReb.Count

                                }.Min();
                                for (int i = 0; i < minCount; i++)
                                {
                                    data01[0] +=
                                        $"get: {get[i]} " +
                                        $"errors: {errors[i]} " +
                                        $"results: {results[i]} " +
                                        $"id3: {id3[i]} " +
                                        $"name: {name[i]} " +
                                        $"nickname: {nickname[i]} " +
                                        $"code: {code[i]} " +
                                        $"logo: {logo[i]} " +
                                        $"points: {points[i]} " +
                                        $"fgm: {fgm[i]} " +
                                        $"fga: {fga[i]} " +
                                        $"fgp: {fgp[i]} " +
                                        $"ftm: {ftm[i]} " +
                                        $"fta: {fta[i]} " +
                                        $"ftp: {ftp[i]} " +
                                        $"tpm: {tpm[i]} " +
                                        $"tpa: {tpa[i]} " +
                                        $"tpp: {tpp[i]} " +
                                        $"offReb: {offReb[i]} " +
                                        $"defReb: {defReb[i]} " +
                                        $"totReb: {totReb[i]}\n";
                                }
                                data01[1] =
                                    $"{string.Join(" ", get)} " +
                                    $"{string.Join(" ", errors)} " +
                                    $"{string.Join(" ", results)} " +
                                    $"{string.Join(" ", id3)} " +
                                    $"{string.Join(" ", name)} " +
                                    $"{string.Join(" ", nickname)} " +
                                    $"{string.Join(" ", code)} " +
                                    $"{string.Join(" ", logo)} " +
                                    $"{string.Join(" ", points)} " +
                                    $"{string.Join(" ", fgm)} " +
                                    $"{string.Join(" ", fga)} " +
                                    $"{string.Join(" ", fgp)} " +
                                    $"{string.Join(" ", ftm)} " +
                                    $"{string.Join(" ", fta)} " +
                                    $"{string.Join(" ", ftp)} " +
                                    $"{string.Join(" ", tpm)} " +
                                    $"{string.Join(" ", tpa)} " +
                                    $"{string.Join(" ", tpp)} " +
                                    $"{string.Join(" ", offReb)} " +
                                    $"{string.Join(" ", defReb)} " +
                                    $"{string.Join(" ", totReb)}";
                            }
                            else
                            {
                                points.Add(string.Empty);
                                fgm.Add(string.Empty);
                                fga.Add(string.Empty);
                                fgp.Add(string.Empty);
                                ftm.Add(string.Empty);
                                fta.Add(string.Empty);
                                ftp.Add(string.Empty);
                                tpm.Add(string.Empty);
                                tpa.Add(string.Empty);
                                tpp.Add(string.Empty);
                                offReb.Add(string.Empty);
                                defReb.Add(string.Empty);
                                totReb.Add(string.Empty);


                            }

                        }

                    }
                    else
                    {
                        id3.Add(string.Empty);
                        name.Add(string.Empty);
                        nickname.Add(string.Empty);
                        code.Add(string.Empty);
                        logo.Add(string.Empty);
                    }
                }
                return data01[0];
            }

        }
        private async Task<string> nba_data07(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model07.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model07.Root>(body);
                if (roots != null)
                {
                    get.Add(roots.get);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    if (roots.response != null && roots.response.Count > 0)
                    {

                        foreach (var item in roots.response)
                        {
                            games.Add(item.games.ToString());
                            fastBreakPoints.Add(item.fastBreakPoints.ToString());
                            pointsInPaint.Add(item.pointsInPaint.ToString());
                            biggestLead.Add(item.biggestLead.ToString());
                            secondChancePoints.Add(item.secondChancePoints.ToString());
                            pointsOffTurnovers.Add(item.pointsOffTurnovers.ToString());
                            longestRun.Add(item.longestRun.ToString());
                            points.Add(item.points.ToString());
                            fgm.Add(item.fgm.ToString());
                            fga.Add(item.fga.ToString());
                            fgp.Add(item.fgp);
                            ftm.Add(item.ftm.ToString());
                            fta.Add(item.fta.ToString());
                            ftp.Add(item.ftp);
                            tpm.Add(item.tpm.ToString());
                            tpa.Add(item.tpa.ToString());
                            tpp.Add(item.tpp);
                            offReb.Add(item.offReb.ToString());
                            defReb.Add(item.defReb.ToString());
                            totReb.Add(item.totReb.ToString());
                            int minCount = new[]
                            {
                                get.Count,
                                errors.Count,
                                results.Count,
                                games.Count,
                                fastBreakPoints.Count,
                                pointsInPaint.Count,
                                biggestLead.Count,
                                secondChancePoints.Count,
                                pointsOffTurnovers.Count,
                                longestRun.Count,
                                points.Count,
                                fgm.Count,
                                fga.Count,
                                fgp.Count,
                                ftm.Count,
                                fta.Count,
                                ftp.Count,
                                tpm.Count,
                                tpa.Count,
                                tpp.Count,
                                offReb.Count,
                                defReb.Count,
                                totReb.Count
                            }.Min();
                            for (int i = 0; i < minCount; i++)
                            {
                                data01[0] +=
                                    $"get: {get[i]} " +
                                    $"errors: {errors[i]} " +
                                    $"results: {results[i]} " +
                                    $"games: {games[i]} " +
                                    $"fastBreakPoints: {fastBreakPoints[i]} " +
                                    $"pointsInPaint: {pointsInPaint[i]} " +
                                    $"biggestLead: {biggestLead[i]} " +
                                    $"secondChancePoints: {secondChancePoints[i]} " +
                                    $"pointsOffTurnovers: {pointsOffTurnovers[i]} " +
                                    $"longestRun: {longestRun[i]} " +
                                    $"points: {points[i]} " +
                                    $"fgm: {fgm[i]} " +
                                    $"fga: {fga[i]} " +
                                    $"fgp: {fgp[i]} " +
                                    $"ftm: {ftm[i]} " +
                                    $"fta: {fta[i]} " +
                                    $"ftp: {ftp[i]} " +
                                    $"tpm: {tpm[i]} " +
                                    $"tpa: {tpa[i]} " +
                                    $"tpp: {tpp[i]} " +
                                    $"offReb: {offReb[i]} " +
                                    $"defReb: {defReb[i]} " +
                                    $"totReb: {totReb[i]}\n";
                            }
                            data01[1] +=
                                $"{string.Join(" ", get)} " +
                                $"{string.Join(" ", errors)} " +
                                $"{string.Join(" ", results)} " +
                                $"{string.Join(" ", games)} " +
                                $"{string.Join(" ", fastBreakPoints)} " +
                                $"{string.Join(" ", pointsInPaint)} " +
                                $"{string.Join(" ", biggestLead)} " +
                                $"{string.Join(" ", secondChancePoints)} " +
                                $"{string.Join(" ", pointsOffTurnovers)} " +
                                $"{string.Join(" ", longestRun)} " +
                                $"{string.Join(" ", points)} " +
                                $"{string.Join(" ", fgm)} " +
                                $"{string.Join(" ", fga)} " +
                                $"{string.Join(" ", fgp)} " +
                                $"{string.Join(" ", ftm)} " +
                                $"{string.Join(" ", fta)} " +
                                $"{string.Join(" ", ftp)} " +
                                $"{string.Join(" ", tpm)} " +
                                $"{string.Join(" ", tpa)} " +
                                $"{string.Join(" ", tpp)} " +
                                $"{string.Join(" ", offReb)} " +
                                $"{string.Join(" ", defReb)} " +
                                $"{string.Join(" ", totReb)}";

                        }
                    }
                    else
                    {
                        games.Add(string.Empty);
                        fastBreakPoints.Add(string.Empty);
                        pointsInPaint.Add(string.Empty);
                        biggestLead.Add(string.Empty);
                        secondChancePoints.Add(string.Empty);
                        pointsOffTurnovers.Add(string.Empty);
                        longestRun.Add(string.Empty);
                        points.Add(string.Empty);
                        fgm.Add(string.Empty);
                        fga.Add(string.Empty);
                        fgp.Add(string.Empty);
                        ftm.Add(string.Empty);
                        fta.Add(string.Empty);
                        ftp.Add(string.Empty);
                        tpm.Add(string.Empty);
                        tpa.Add(string.Empty);
                        tpp.Add(string.Empty);
                        offReb.Add(string.Empty);
                        defReb.Add(string.Empty);
                        totReb.Add(string.Empty);

                    }


                }
                else
                {
                    get.Add(string.Empty);
                    errors.Add(null);
                    results.Add(0);
                }
                return data01[0];
            }
        }
        private async Task<string> nba_data08(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
        {
            { Headers_[0], Headers_[1] },
            { Headers_[2], Headers_[3] },
        },
            };

            using (var responseMsg = await client.SendAsync(request))
            {
                responseMsg.EnsureSuccessStatusCode();
                var body = await responseMsg.Content.ReadAsStringAsync();
                Nba_Get_Model08.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model08.Root>(body);
                if (roots != null)
                {
                    get.Add(roots.get);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    if (roots.response != null && roots.response.Count > 0)
                    {
                        foreach (var item in roots.response)
                        {
                            id3.Add(item.player?.id.ToString() ?? string.Empty);
                            firstname.Add(item.player?.firstname ?? string.Empty);
                            lastname.Add(item.player?.lastname ?? string.Empty);
                            name.Add(item.team?.name ?? string.Empty);
                            nickname.Add(item.team?.nickname ?? string.Empty);
                            code.Add(item.team?.code ?? string.Empty);
                            logo.Add(item.team?.logo ?? string.Empty);
                            points.Add(item.points.ToString());
                            pos.Add(item.pos ?? string.Empty);
                            min.Add(item.min ?? string.Empty);
                            fgm.Add(item.fgm.ToString());
                            fga.Add(item.fga.ToString());
                            fgp.Add(item.fgp ?? string.Empty);
                            ftm.Add(item.ftm.ToString());
                            fta.Add(item.fta.ToString());
                            ftp.Add(item.ftp ?? string.Empty);
                            tpm.Add(item.tpm.ToString());
                            tpa.Add(item.tpa.ToString());
                            tpp.Add(item.tpp ?? string.Empty);
                            offReb.Add(item.offReb.ToString());
                            defReb.Add(item.defReb.ToString());
                            totReb.Add(item.totReb.ToString());
                        }
                        int minCount = new[]
                        {
                            get.Count,
                            errors.Count,
                            results.Count,
                            id3.Count,
                            firstname.Count,
                            lastname.Count,
                            name.Count,
                            nickname.Count,
                            code.Count,
                            logo.Count,
                            points.Count,
                            pos.Count,
                            min.Count,
                            fgm.Count,
                            fga.Count,
                            fgp.Count,
                            ftm.Count,
                            fta.Count,
                            ftp.Count,
                            tpm.Count,
                            tpa.Count,
                            tpp.Count,
                            offReb.Count,
                            defReb.Count,
                            totReb.Count
                        }.Min();
                        for (int i = 0; i < minCount; i++)
                        {
                            data01[0] +=
                                $"get: {get[i]} " +
                                $"errors: {errors[i]} " +
                                $"results: {results[i]} " +
                                $"id3: {id3[i]} " +
                                $"firstname: {firstname[i]} " +
                                $"lastname: {lastname[i]} " +
                                $"name: {name[i]} " +
                                $"nickname: {nickname[i]} " +
                                $"code: {code[i]} " +
                                $"logo: {logo[i]} " +
                                $"points: {points[i]} " +
                                $"pos: {pos[i]} " +
                                $"min: {min[i]} " +
                                $"fgm: {fgm[i]} " +
                                $"fga: {fga[i]} " +
                                $"fgp: {fgp[i]} " +
                                $"ftm: {ftm[i]} " +
                                $"fta: {fta[i]} " +
                                $"ftp: {ftp[i]} " +
                                $"tpm: {tpm[i]} " +
                                $"tpa: {tpa[i]} " +
                                $"tpp: {tpp[i]} " +
                                $"offReb: {offReb[i]} " +
                                $"defReb: {defReb[i]} " +
                                $"totReb: {totReb[i]}\n";
                        }
                        data01[1] +=
                            $"{string.Join(" ", get)} " +
                            $"{string.Join(" ", errors)} " +
                            $"{string.Join(" ", results)} " +
                            $"{string.Join(" ", id3)} " +
                            $"{string.Join(" ", firstname)} " +
                            $"{string.Join(" ", lastname)} " +
                            $"{string.Join(" ", name)} " +
                            $"{string.Join(" ", nickname)} " +
                            $"{string.Join(" ", code)} " +
                            $"{string.Join(" ", logo)} " +
                            $"{string.Join(" ", points)} " +
                            $"{string.Join(" ", pos)} " +
                            $"{string.Join(" ", min)} " +
                            $"{string.Join(" ", fgm)} " +
                            $"{string.Join(" ", fga)} " +
                            $"{string.Join(" ", fgp)} " +
                            $"{string.Join(" ", ftm)} " +
                            $"{string.Join(" ", fta)} " +
                            $"{string.Join(" ", ftp)} " +
                            $"{string.Join(" ", tpm)} " +
                            $"{string.Join(" ", tpa)} " +
                            $"{string.Join(" ", tpp)} " +
                            $"{string.Join(" ", offReb)} " +
                            $"{string.Join(" ", defReb)} " +
                            $"{string.Join(" ", totReb)}";
                    }
                    else
                    {
                        id3.Add(string.Empty);  
                        firstname.Add(string.Empty);
                        lastname.Add(string.Empty);
                        name.Add(string.Empty);
                        nickname.Add(string.Empty);
                        code.Add(string.Empty);
                        logo.Add(string.Empty);
                        points.Add(string.Empty);
                        pos.Add(string.Empty);
                        min.Add(string.Empty);
                        fgm.Add(string.Empty);
                        fga.Add(string.Empty);
                        fgp.Add(string.Empty);
                        tpm.Add(string.Empty);
                        tpa.Add(string.Empty);
                        tpp.Add(string.Empty);
                        offReb.Add(string.Empty);
                        defReb.Add(string.Empty);
                        totReb.Add(string.Empty);


                    }
                
                }
                else
                {
                    get.Add(string.Empty);
                    errors.Add(null);
                    results.Add(0);
                }   
                return data01[0];
            }
        }
    }
}
          