using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.MODEL.AI_MODEL.AI_TEXT_TO_IMAGE.GET_MODEL
{
    internal class AI_Get_Model01
    {// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Data
        {
            public string prompt_id { get; set; }
            public QueueInfo queue_info { get; set; }
            public List<Result2> results { get; set; }
        }

        public class QueueInfo
        {
            public string status { get; set; }
            public int index { get; set; }
            public string prompt_status { get; set; }
        }

        public class Result
        {
            public Data data { get; set; }
        }

        public class Result2
        {
            public int index { get; set; }
            public bool nsfw { get; set; }
            public string origin { get; set; }
            public string thumb { get; set; }
        }

        public class Root
        {
            public int code { get; set; }
            public string message { get; set; }
            public Result result { get; set; }
        }


    }
}
