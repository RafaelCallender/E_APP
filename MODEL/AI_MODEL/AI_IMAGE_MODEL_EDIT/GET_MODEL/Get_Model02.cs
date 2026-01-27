
namespace E_APP.MODEL.AI_MODEL.AI_IMAGE_MODEL_EDIT.GET_MODEL
{
    internal class Get_Model02
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ErrorDetail
        {
            public int status_code { get; set; }
            public string code { get; set; }
            public string code_message { get; set; }
            public string message { get; set; }
        }

        public class Root
        {
            public string request_id { get; set; }
            public string log_id { get; set; }
            public int error_code { get; set; }
            public string error_code_str { get; set; }
            public string error_msg { get; set; }
            public ErrorDetail error_detail { get; set; }
            public string task_type { get; set; }
            public string task_id { get; set; }
        }


    }
}
