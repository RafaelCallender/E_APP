using E_APP.SERVICES.AI_SERVICES.AI_HELPER;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
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
    
            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);
            string prompt = $@"
You are a professional translation engine.

Translate strictly from {input.Trim().ToUpperInvariant()} to {input01.Trim().ToUpperInvariant()}.

Rules:
1. Output ONLY the translated text.
2. Do NOT explain.
3. Do NOT add quotes.
4. Do NOT repeat the source text.
5. Preserve formatting if present.

Reference Context:
{File_Helper01.file_path_data01[(int)File_Helper01.file_path_data01_enum.translation].Trim()}

Source Text:
{input02}
";




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