
namespace E_APP.MODEL.AI_MODEL.AI_IMAGE_MODEL_EDIT.SET_MODEL
{
    internal class Set_Model02
    {
        public int status_code { get; set; }
        public string code { get; set; }= string.Empty;
        public string code_message { get; set; } = string.Empty;
        public string message { get; set; } = string.Empty;
        public string request_id { get; set; } = string.Empty;
        public string log_id { get; set; } = string.Empty;
        public int error_code { get; set; }
        public string error_code_str { get; set; } = string.Empty;
        public string error_msg { get; set; } = string.Empty;
        public string task_type { get; set; } = string.Empty;
        public string task_id { get; set; } = string.Empty;
    }
}
