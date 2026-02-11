

namespace E_APP.MODEL.NEWS_MODEL.NEWS_SET_MODEL
{
    internal class News_Set_Model02
    {
        public string Status { get; set; }= string.Empty;
        public string Request_id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Snippet { get; set; } = string.Empty;
        public string Photo_url { get; set; } = string.Empty;
        public string Thumbnail_url { get; set; } = string.Empty;
        public DateTime? Published_datetime_utc { get; set; }
        public string Authors { get; set; } = string.Empty;
        public string Source_url { get; set; } = string.Empty;
        public string Source_name { get; set; } = string.Empty;
        public string Source_logo_url { get; set; } = string.Empty;
        public string Source_favicon_url { get; set; } = string.Empty;
        public string Source_publication_id { get; set; } = string.Empty;
        public string Story_id { get; set; } = string.Empty;
        public List<string> Topic_id { get; set; }= new List<string>();
        public List<string> Topic_name { get; set; }= new List<string>();
    }
}
