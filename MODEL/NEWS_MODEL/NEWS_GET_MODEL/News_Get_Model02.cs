

namespace E_APP.MODEL.NEWS_MODEL.NEWS_GET_MODEL
{
    internal class News_Get_Model02
    {
        public class Root
        {
            public string status { get; set; }= string.Empty;
            public string request_id { get; set; } = string.Empty;
            public List<Data> data { get; set; }= new List<Data>();
        }

        public class Data
        {
            public string story_id { get; set; }= string.Empty;
            public string title { get; set; } = string.Empty;
            public string link { get; set; } = string.Empty;
            public string snippet { get; set; } = string.Empty;
            public string photo_url { get; set; } = string.Empty;
            public string thumbnail_url { get; set; } = string.Empty;
     
            public List<string> authors { get; set; }= new List<string>();
            public string source_url { get; set; }= string.Empty;
            public string source_name { get; set; } = string.Empty;
            public string source_logo_url { get; set; } = string.Empty;
            public string source_favicon_url { get; set; } = string.Empty;
            public string source_publication_id { get; set; } = string.Empty;
         public DateTime?   published_datetime_utc { get; set; }
            public List<RelatedTopic> related_topics { get; set; } = new List<RelatedTopic>();
            public List<SubArticle> sub_articles { get; set; } = new List<SubArticle>();
        }

        public class RelatedTopic
        {
            public string topic_id { get; set; }= string.Empty;
            public string topic_name { get; set; } = string.Empty;
        }

        public class SubArticle
        {
            public string title { get; set; } = string.Empty;
            public string link { get; set; } = string.Empty;
            public string photo_url { get; set; } = string.Empty;
            public string thumbnail_url { get; set; } = string.Empty;
   
            public List<string> authors { get; set; } = new List<string>();
            public string source_url { get; set; } = string.Empty;
            public string source_name { get; set; } = string.Empty;
            public string source_logo_url { get; set; } = string.Empty;
            public string source_favicon_url { get; set; } = string.Empty;
            public string source_publication_id { get; set; } = string.Empty;
            public DateTime? published_datetime_utc { get; set; }
        }
    }
}
