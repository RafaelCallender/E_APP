    using E_APP.SERVICES.AI_SERVICES.AI_HELPER;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using LLama;
using LLama.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    internal class Ai_Text_To_Text03
    {
        private readonly Dictionary<string, string> _chunkCache = new();
        private static Ai_Helper01 Ai_H01 = new Ai_Helper01();
        public Ai_Text_To_Text03()
        {
            Ai_H01.LoadModel();
        }


        public async Task<string> text_to_text_content01(string input, Action? chunkLoader)
        {
        
            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);

            string textfile_content = string.Empty;

            if (!_chunkCache.TryGetValue(input, out textfile_content)
                  ) 
            {
                textfile_content = Ai_H01.RetrieveContext(input, chunkLoader, maxChunks: 3);
                _chunkCache[input] = textfile_content;
            }

            string prompt = $"""
You are a book of the Enoch scholar.
Answer ONLY using the book of the Enoch text below.

book of the Enoch Text:
{textfile_content}

Question:
{input}

Answer:
""";

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