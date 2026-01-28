

namespace E_APP.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL
{
    internal class Language_Get_Model03
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Extra
        {
            public string image { get; set; }
            public int comment_counts { get; set; }
            public LastComment last_comment { get; set; }
        }

        public class LastComment
        {
            public string author { get; set; }
            public string short_text { get; set; }
        }

        public class Root
        {
            public Trans trans { get; set; }
        }

        public class Trans
        {
            public string title { get; set; }
            public string author { get; set; }
            public double rate { get; set; }
            public Extra extra { get; set; }
        }


    }
}
