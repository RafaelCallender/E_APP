

namespace E_APP.MODEL.NEWS_MODEL.NEWS_GET_MODEL
{
    internal class News_Get_Model03
    {
        public class Root
        {
            public string status { get; set; }= string.Empty;
            public string request_id { get; set; } = string.Empty;
            public Data data { get; set; }= new Data();
        }

        public class Data
        {
            public List<Article> all_articles { get; set; }= new List<Article>();
            public List<TwitterPost> twitter_posts { get; set; } = new List<TwitterPost>();
        }

        public class Article
        {
            public string title { get; set; }= string.Empty;
            public string link { get; set; } = string.Empty;
            public string snippet { get; set; } = string.Empty;
            public string photo_url { get; set; } = string.Empty;
            public string thumbnail_url { get; set; } = string.Empty;
            public DateTime? published_datetime_utc { get; set; }
            public string source_url { get; set; } = string.Empty;
            public string source_name { get; set; } = string.Empty;
            public string source_logo_url { get; set; } = string.Empty;
            public string source_favicon_url { get; set; } = string.Empty;
            public string source_publication_id { get; set; } = string.Empty;

            public List<RelatedTopic> related_topics { get; set; }= new List<RelatedTopic>();
        }

        public class RelatedTopic
        {
            public string topic_id { get; set; } = string.Empty;
            public string topic_name { get; set; } = string.Empty;
        }

        public class TwitterPost
        {
            public string post_id { get; set; } = string.Empty;
            public string photo { get; set; } = string.Empty;
            public string post_author_username { get; set; } = string.Empty;
            public string post_author_picture { get; set; } = string.Empty;
        }
    }
}
