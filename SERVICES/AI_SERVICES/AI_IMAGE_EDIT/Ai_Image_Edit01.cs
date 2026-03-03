using E_APP.MODEL.AI_MODEL.AI_IMAGE_MODEL_EDIT.AI_IMAGE_GET_MODEL;
using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
//https://rapidapi.com/karlbeyond/api/photo-anime/playground/apiendpoint_b3812724-d777-404c-9e9f-47c75f48054c
namespace E_APP.SERVICES.AI_SERVICES.IMAGE_EDIT
{
    internal class Ai_Image_Edit01
    {
        private string[] data01 = new string[100];
        private List<string> image_url = new List<string>();
        private static Read_Textfiles READ = new Read_Textfiles();
        public async Task<string> PhotoAnime(string input)
        {
            //input=url image
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://photo-anime.p.rapidapi.com/RapidPhotoAnime"),
                Headers =
    {
        { "x-rapidapi-key", READ.API[0].Trim() },
        { "x-rapidapi-host", "photo-anime.p.rapidapi.com" },
    },
                Content = new StringContent(
                    $"{{\"url\":\"{input.Trim()}\",\"type\":\"anime\",\"mask_id\":1}}",
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

                var results = JsonConvert.DeserializeObject<Get_Model01.Root>(body);

                image_url.Add(results?.image_url ?? " ");



                data01[0] += $"{image_url[0]}\n";
            }
            return data01[0];
        }
    }
}