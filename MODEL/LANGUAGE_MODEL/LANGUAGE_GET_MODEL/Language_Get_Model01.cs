
namespace E_APP.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL
{
    internal class Language_Get_Model01
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {

            public string trans { get; set; }
            public string source_language_code { get; set; }
            public string source_language { get; set; }
            public int trust_level { get; set; }
        }

    }
}
