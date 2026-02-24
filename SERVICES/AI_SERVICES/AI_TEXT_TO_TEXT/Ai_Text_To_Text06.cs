using E_APP.SERVICES.AI_SERVICES.AI_HELPER;
using LLama;
using LLama.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    internal class Ai_Text_To_Text06
    {
        private static Ai_Helper01 Ai_H01 = new Ai_Helper01();

        public Ai_Text_To_Text06()
        {
            Ai_H01.LoadModel();
        }
        public async Task<string> text_to_text_translate01(string input, string input01, string input02)
        {
            int index = 0;
            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);
            string prompt =
        $@"Translate the following text from {input.ToUpper().Trim()} to {input01.ToUpper().Trim()}.
        and only output the translated text.       
        Text: ""{input02}""";
            var inferenceParams = new InferenceParams
            {
                MaxTokens = 512,

            };

            var result = new StringBuilder();

            await foreach (var token in executor.InferAsync(prompt, inferenceParams))
            {
                result.Append(token);
            }

            return result.ToString().Trim();
        }

    }
}