

namespace E_APP.MODEL.LANGUAGE_MODEL.LANGUAGE_GET_MODEL
{
    internal class Language_Get_Model03
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Extra
        {
            public string image { get; set; } = string.Empty;
            public int comment_counts { get; set; }
            public LastComment last_comment { get; set; }= new LastComment();
        }

        public class LastComment
        {
            public string author { get; set; } = string.Empty;
            public string short_text { get; set; } = string.Empty;
        }

        public class Root
        {
            public Trans trans { get; set; }=new Trans();           
        }

        public class Trans
        {
            public string title { get; set; }= string.Empty;
            public string author { get; set; } = string.Empty;
            public double rate { get; set; }
            public Extra extra { get; set; } = new Extra();
        }


    }
}
