

namespace E_APP.MODEL.AI_MODEL.AI_TEXT_TO_IMAGE.AI_SET_MODEL
{
    internal class AI_SET_MODEL
    {
        public int code { get; set; }
        public string message { get; set; }=string.Empty;
        public int index { get; set; }
        public bool nsfw { get; set; }
        public string origin { get; set; } = string.Empty;
        public string thumb { get; set; } = string.Empty;
        public string status { get; set; } = string.Empty;
        public int index01 { get; set; }
        public string prompt_status { get; set; } = string.Empty;
        public string prompt_id { get; set; } = string.Empty;
    }
}
