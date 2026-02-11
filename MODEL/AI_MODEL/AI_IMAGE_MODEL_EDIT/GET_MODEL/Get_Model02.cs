
namespace E_APP.MODEL.AI_MODEL.AI_IMAGE_MODEL_EDIT.GET_MODEL
{
    internal class Get_Model02
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class ErrorDetail
        {
            public int status_code { get; set; }
            public string code { get; set; } = string.Empty;
            public string code_message { get; set; } = string.Empty;
            public string message { get; set; } = string.Empty;
        }

        public class Root
        {
            public string request_id { get; set; } = string.Empty;
            public string log_id { get; set; } = string.Empty;
            public int error_code { get; set; }
            public string error_code_str { get; set; } = string.Empty;
            public string error_msg { get; set; } = string.Empty;
            public ErrorDetail error_detail { get; set; }= new ErrorDetail();
            public string task_type { get; set; } = string.Empty;
            public string task_id { get; set; } = string.Empty;
        }


    }
}
