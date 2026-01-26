using E_APP.MODEL.NEWS_MODEL.NEWS_GET_MODEL;
using E_APP.MODEL.SPORT_MODEL.NBA_MODEL.NBA_GET_MODEL;
using E_MauiApp01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http.Headers;
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

        private List<string> date = new List<stringint>();

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

        public List<string> linescore1 = new List<string>();
        private List<int> points1 = new List<int>();
        private List<int> id2 = new List<int>();
        private List<string> name2 = new List<string>();
        private List<string> nickname2 = new List<string>();
        private List<string> code2 = new List<string>();
        private List<string> logo2 = new List<string>();
        private List<int> win2 = new List<int>();
        private List<int> loss2 = new List<int>();

        private List<int> series_win2 = new List<int>();
        private List<int> series_loss2 = new List<int>();

        private List<string> linescore2 = new List<string();
        private List<int> points2 = new List<int>();
        public List<string> officials = new List<string>();
        private List<int> timesTied = new List<int>();
        private List<int> leadChanges = new List<int>();
        private List<object> nugget = new List<object>();
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
        private async Task<string> nba_data01(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(input),
                Headers =
    {
      { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var StatusCode = await client.SendAsync(request))
            {
                StatusCode.EnsureSuccessStatusCode();
                var body = await StatusCode.Content.ReadAsStringAsync();
                Nba_Get_Model01.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model01.Root>(body);
                if (roots != null)
                {
                    get.Add(roots.get);
                    parameters.Add(roots.parameters);
                    errors.Add(roots.errors);
                    results.Add(roots.results);
                    response.AddRange(roots.response);
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
                { get.Count,
                    parameters.Count,
                    errors.Count,
                    results.Count,
                response.Count}.Min();
                for (int i = 0; i < minCount; i++)
                {
                    data01[0] +=
                                $"get: {get[i]}\n" +
                                $"parameters: {parameters[i]}\n" +
                                $"errors: {errors[i]}\n" +
                                $"results: {results[i]}\n" +
                                $"response: {response[i]}\n";
                }
                data01[1] += $"{string.Join(" ", get)}" +
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
      { Headers_[0],Headers_[1] },
        { Headers_[2], Headers_[3] },
    },
            };
            using (var StatusCode = await client.SendAsync(request))
            {
                StatusCode.EnsureSuccessStatusCode();
                var body = await StatusCode.Content.ReadAsStringAsync();
                Nba_Get_Model02.Root roots = JsonConvert.DeserializeObject<Nba_Get_Model02.Root>(body);
                if (roots != null)
                {
                    get.Add(roots.get);
                    date.Add(roots.parameters.date);
                    errors.Add(roots.errors);
                    results.Add(roots.results);

                }
                else
                {
                    get.Add(string.Empty);

                }
                return data01[0];
            }
        }
    }
}
  