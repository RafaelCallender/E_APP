
namespace E_APP.MODEL.NEWS_MODEL.NEWS_GET_MODEL
{
    internal class News_Get_Model04
    {
        public class Root
        {
            public string status { get; set; }
            public string request_id { get; set; }
            public List<Item> data { get; set; }
        }

        public class Item
        {
            public string name { get; set; }
            public string lang { get; set; }
        }
    }
}
