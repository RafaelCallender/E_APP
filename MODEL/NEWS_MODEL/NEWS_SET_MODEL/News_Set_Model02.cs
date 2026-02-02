

namespace E_APP.MODEL.NEWS_MODEL.NEWS_SET_MODEL
{
    internal class News_Set_Model02
    {
        public string Status { get; set; }
        public string Request_id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public string Snippet { get; set; }
        public string Photo_url { get; set; }
        public string Thumbnail_url { get; set; }
        public DateTime? Published_datetime_utc { get; set; }
        public string Authors { get; set; }
        public string Source_url { get; set; }
        public string Source_name { get; set; }
        public string Source_logo_url { get; set; }
        public string Source_favicon_url { get; set; }
        public string Source_publication_id { get; set; }
        public string Story_id { get; set; }
        public List<string> Topic_id { get; set; }
        public List<string> Topic_name { get; set; }
    }
}
