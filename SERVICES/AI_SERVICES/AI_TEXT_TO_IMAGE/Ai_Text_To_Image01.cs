using E_APP.MODEL.AI_MODEL.AI_TEXT_TO_IMAGE.GET_MODEL;
using E_APP.SERVICES.PYTHON_SERVICES.PYTHON_HELPER;
using E_MauiApp01.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_IMAGE
{
    internal class Ai_Text_To_Image01
    {
        private static Python_Helper01 Python_H01 = new Python_Helper01();
        private List<int> code = new List<int>();
        private List<string> message = new List<string>();
        private List<string> prompt_id = new List<string>();
        private List<string> status = new List<string>();
        private List<int> index = new List<int>();
        private List<string> prompt_status = new List<string>();
        private List<int> index01 = new List<int>();
        private List<bool> nsfw = new List<bool>();
        private List<string> origin = new List<string>();
        private List<string> thumb = new List<string>();
        private string[] data01 = new string[100];

        private static Read_Textfiles READ = new Read_Textfiles();

        public async Task<string> AI_Text_to_image_Generator_Flux_Free(string input)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://ai-text-to-image-generator-flux-free-api.p.rapidapi.com/aaaaaaaaaaaaaaaaaiimagegenerator/quick.php"),
                Headers =
    {
        { "x-rapidapi-key",READ.API[0].Trim() },
        { "x-rapidapi-host", "ai-text-to-image-generator-flux-free-api.p.rapidapi.com" },
    },
                Content = new StringContent(
    $"{{\"prompt\":\"{input}\",\"style_id\":4,\"size\":\"1-1\"}}",
    Encoding.UTF8,
    "application/json"
)

                {
                    Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                AI_Get_Model01.Root results = JsonConvert.DeserializeObject<AI_Get_Model01.Root>(body);

                if (results != null)
                {
                    code.Add(results.code);
                    message.Add(results.message);
                    prompt_id.Add(results.result.data.prompt_id);
                    status.Add(results.result.data.queue_info.status);
                    index.Add(results.result.data.queue_info.index);
                    prompt_status.Add(results.result.data.queue_info.prompt_status);
                    if (results.result.data.results != null)
                    {
                        foreach (var a in results.result.data.results)
                        {
                            index01.Add(a.index);
                            nsfw.Add(a.nsfw);
                            origin.Add(a.origin);
                            thumb.Add(a.thumb);
                        }
                    }
                    else
                    {
                        index01.Add(0);
                        nsfw.Add(false);
                        origin.Add("null");
                        thumb.Add("null");
                    }

                }
                else
                {
                    code.Add(0);
                    message.Add("null");
                    prompt_id.Add("null");
                    status.Add("null");
                    index.Add(0);
                    prompt_status.Add("null");
                    index01.Add(0);
                    nsfw.Add(false);
                    origin.Add("null");
                    thumb.Add("null");
                }

                data01[0] += $"{string.Join(" ", code)}\n" +
                             $"{string.Join(" ", message)}\n" +
                             $"{string.Join(" ", prompt_id)}\n" +
                             $"{string.Join(" ", status)}\n" +
                             $"{string.Join(" ", index)}\n" +
                             $"{string.Join(" ", prompt_status)}\n" +
                             $"{string.Join(" ", index01)}\n" +
                             $"{string.Join(" ", nsfw)}\n" +
                             $"{string.Join(" ", origin)}\n" +
                             $"{string.Join(" ", thumb)}\n";

                data01[1] += $"{origin[0]}";


                data01[2] = body.ToString();

                return data01[1];


            }
        }
        public string image_to_text01(string input)
        {
            data01[3] = Python_H01.RunTextToImage(input);
            return data01[3];
        }

    }
}