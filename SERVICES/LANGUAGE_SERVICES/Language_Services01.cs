using E_APP.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL;
using E_APP.SERVICES.SQL.SQL_SERVICES.SQL_LANGUAGE_SERVICES;
using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using E_APP.SERVICES.SECURITY_SERVICES;
//https://rapidapi.com/robust-api-robust-api-default/api/google-translate113/playground/apiendpoint_a13bd40a-5212-4f25-b997-f8bb30db6e5f
namespace E_APP.SERVICES.LANGUAGE_SERVICES
{
    internal class Language_Services01
    {

        private string[] data01 = new string[100];
        private List<string> trans = new List<string>();
        private List<string> source_language_code = new List<string>();
        private List<string> source_language = new List<string>();
        private List<int> trust_level = new List<int>();
        public List<string> code = new List<string>();
        public List<string> language = new List<string>();
        private List<string> source_lang = new List<string>();
        private List<int> trust_level01 = new List<int>();
        private List<string> source_lang_code = new List<string>();
        private List<string> lowercase01 = new List<string>();
        private List<string> lowercase02 = new List<string>();
        private Sql_Language_Services01 Sql_Serv01 = new Sql_Language_Services01();
        private static Read_Textfiles READ = new Read_Textfiles();
        private static Security_Services01 Security_Serv01=new Security_Services01();   

        public  string[] data_array01 = { "Tranlate Text", "select language" };
        private static Ai_Text_To_Text01 Ai_Text_To_T01= new Ai_Text_To_Text01();       
        public Language_Services01()
        {
            update_language_sql();
            update_language_sqlite();
        }
        public async Task<string> Tranlate_Text(string input01, string input02)
        {

            //input01= language apprivation en,vi,fr,jp,cn
            //input02= text need to translate
            string detct_lang = await Detect_Language(input02);
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/text"),
                    Headers =
    {
        { "x-rapidapi-key",  READ.API[0].Trim()},
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                    Content = new StringContent($"{{\"from\":\"{detct_lang.Trim()}\",\"to\":\"{input01.Trim()}\",\"text\":\"{input02.Trim() }\"}}", Encoding.UTF8, "application/json")

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
                    Language_Get_Model01.Root resaults = JsonConvert.DeserializeObject<Language_Get_Model01.Root>(body);

                    if (resaults != null)
                    {
                        trans.Add(resaults.trans);
                        source_language_code.Add(resaults.source_language_code);
                        source_language.Add(resaults.source_language);
                        trust_level.Add(resaults.trust_level);
                    }
                    else
                    {
                        trans.Add(" ");
                        source_language_code.Add(" ");
                        source_language.Add(" ");
                        trust_level.Add(0);
                    }

                    /* data01[3] = $"{string.Join(" ", trans)}\n" +
                                 $"{string.Join(" ", source_language_code)}\n" +
                                 $" {string.Join(" ", source_language)}\n" +
                                 $"{string.Join(" ", trust_level)}";*/

                    data01[3] = $"{string.Join(" ", trans)}\n";
                }
            }
            catch (Exception ex)
            {
                data01[3] = $"{ex}\n";


            }


            return data01[3];
        }

        public async Task<string> Tranlate_Text01(int input01, string input02)
        {

            //input01= language apprivation en,vi,fr,jp,cn
            //input02= text need to translate
            string detct_lang = await Detect_Language(input02);
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/text"),
                    Headers =
    {
        { "x-rapidapi-key",  READ.API[0].Trim()},
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                    Content = new StringContent($"{{\"from\":\"{detct_lang}\",\"to\":\"{READ.Language_Abbreviation[input01].Trim().ToLower()}\",\"text\":\"{input02}\"}}", Encoding.UTF8, "application/json")

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
                    Language_Get_Model01.Root resaults = JsonConvert.DeserializeObject<Language_Get_Model01.Root>(body);

                    if (resaults != null)
                    {
                        trans.Add(resaults.trans);
                        source_language_code.Add(resaults.source_language_code);
                        source_language.Add(resaults.source_language);
                        trust_level.Add(resaults.trust_level);
                    }
                    else
                    {
                        trans.Add(" ");
                        source_language_code.Add(" ");
                        source_language.Add(" ");
                        trust_level.Add(0);
                    }

                    /* data01[3] = $"{string.Join(" ", trans)}\n" +
                                 $"{string.Join(" ", source_language_code)}\n" +
                                 $" {string.Join(" ", source_language)}\n" +
                                 $"{string.Join(" ", trust_level)}";*/

                    data01[3] = $"{string.Join(" ", trans)}\n";
                }
            }
            catch (Exception ex)
            {
                data01[3] = $"{ex}\n";


            }


            return data01[3];
        }


        public async Task<string> Batch_Translation()//needs work
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/json"),
                Headers =
    {
        { "x-rapidapi-key",  READ.API[0] },
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                Content = new StringContent("{\"from\":\"auto\",\"to\":\"vi\",\"protected_paths\":[\"extra.last_comment.author\"],\"common_protected_paths\":[\"image\"],\"json\":[\"Batch Translation\",\"Mutiple Text\"]}")
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
                data01[0] = body;
                return data01[0];
            }
        }



        public async Task<string> Translate_JSON()
        {
            object jsonToTranslate = "";
            string targetLang = "vi";
            var client = new HttpClient();

            var bodyObject = new
            {
                from = "auto",
                to = targetLang,
                protected_paths = new[] { "extra.last_comment.author" },
                common_protected_paths = new[] { "image" },
                json = jsonToTranslate
            };
            string jsonPayload = JsonConvert.SerializeObject(bodyObject);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/json"),
                Headers =
        {
            { "x-rapidapi-key", READ.API[0] },
            { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
        },
                Content = new StringContent(jsonPayload, Encoding.UTF8, "application/json")
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                data01[0] = body;
            }

            return data01[0];
        }
        public async Task<string> Translate_HTML()//idk what this does
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/html"),
                Headers =
    {
        { "x-rapidapi-key", READ.API[0]},
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
                Content = new StringContent("{\"from\":\"en\",\"to\":\"vi\",\"html\":\"<ul><li>Hello</li><li>This is Translate HTML endpoint</li></ul>\"}")
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
                data01[0] = body;

            }
            return data01[0];
        }

        private async Task<string> Detect_Language(string input)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/detect-language"),
                Headers =
        {
            { "x-rapidapi-key", READ.API[0].Trim() },
            { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
        },
                Content = new StringContent($"{{\"text\":\"{input.Trim()}\"}}", Encoding.UTF8, "application/json")
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Language_Get_Model04.Root results = JsonConvert.DeserializeObject<Language_Get_Model04.Root>(body);
                source_lang.Add(results.source_lang);
                trust_level01.Add(results.trust_level);
                source_lang_code.Add(results.source_lang_code);
                data01[0] = $"{string.Join(" ", source_lang)}\n" +
                            $"{string.Join(" ", trust_level01)}\n" +
                            $"{string.Join(" ", source_lang_code)}";
                data01[1] = source_lang_code[0];
                return data01[1];
            }
        }
        private async Task<string> Supported_languages()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://google-translate113.p.rapidapi.com/api/v1/translator/support-languages"),
                Headers =
    {
        { "x-rapidapi-key", READ.API[0] },
        { "x-rapidapi-host", "google-translate113.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                List<Language_Get_Model05.Root> resaults = JsonConvert.DeserializeObject<List<Language_Get_Model05.Root>>(body);

                foreach (var a in resaults)
                {
                    code.Add(a.code);
                    language.Add(a.language);
                }
                data01[0] = $"{string.Join(" ", code)}\n" +
                            $"{string.Join(" ", language)}";

                return data01[0];
            }


        }
        public string pick_languge_using_text_file(string input)
        {
            string lowerInput = input.Trim().ToLower();
            for (int i = 0; i < READ.Language_Name.Length; i++)
            {
                lowercase01.Add(READ.Language_Name[i].Trim().ToLower());
                lowercase02.Add(READ.Language_Abbreviation[i].Trim().ToLower());
            }

            if (lowercase01.Contains(lowerInput))
            {
                int index = lowercase01.IndexOf(lowerInput);
                return lowercase01[index];
            }
            else if (lowercase02.Contains(lowerInput))
            {
                int index = lowercase01.IndexOf(lowerInput);
                return lowercase01[index];
            }
            else if (Security_Serv01.string_only_digit(lowerInput))
            {
                int inputIndex = int.Parse(lowerInput);
                if (inputIndex >= 0 && inputIndex < lowercase01.Count)
                {
                    return lowercase01[inputIndex];
                }
            }

            return "cant find";

        }
        public string view_language_using_text_file()
        {

            data01[0] = $"{string.Join("\n", language)}\n";
              
            return data01[0];
        }
        private void update_language_sql()
        {

            update_languge_using_text_file();
            for (int i = 0; i < code.Count; i++)
            {
                data01[0] += Sql_Serv01.insert_language(language[i], code[i]);
            }
        }
        private void update_language_sqlite()
        {
            update_languge_using_text_file();
            for (int i = 0; i < code.Count; i++)
            {
                data01[0] += Sql_Serv01.insert_language(language[i], code[i]);
            }
        }
        public string test()
        {

            update_languge_using_text_file();
            data01[0] += $"{string.Join("\n", code)}\n" +
                        $"{string.Join("\n", language)}\n" +
                        $"code {code.Count}" +
                        $"language {language.Count}";
            return data01[0];
        }
        private void update_languge_using_text_file()
        {
            for (int i = 0; i < READ.Language_Abbreviation.Length; i++)
            {
                code.Add(READ.Language_Abbreviation[i]);
            }
            for (int i = 0; i < READ.Language_Name.Length; i++)
            {
                language.Add(READ.Language_Name[i]);
            }

        }
        public string pick_language_using_sql(string input) //needs work 
        {

            data01[0] = Sql_Serv01.find_code_using_code(input);

            //     data01[0] = Sql_Serv04.find_code_using_language(input);

            return data01[0];
        }
        public async Task<string> Translate_using_Ai(string input, string input01)
        {
            string select_lang =input.Trim();   
            string detct_lang = await Detect_Language(input01);
            data01[0] = await Ai_Text_To_T01.text_to_text_translate01(detct_lang.Trim(), select_lang.Trim(), input01.Trim());
            return data01[0];
        }
    }
}