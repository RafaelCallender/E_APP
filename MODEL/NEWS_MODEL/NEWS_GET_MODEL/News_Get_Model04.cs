
namespace E_APP.MODEL.NEWS_MODEL.NEWS_GET_MODEL
{
    internal class News_Get_Model04
    {
        public class Root
        {
            public string status { get; set; } = string.Empty;
            public string request_id { get; set; } = string.Empty;
            public List<Item> data { get; set; }= new List<Item>();
        }

        public class Item
        {
            public string name { get; set; }=string.Empty;
            public string lang { get; set; } = string.Empty;
        }
    }
}
