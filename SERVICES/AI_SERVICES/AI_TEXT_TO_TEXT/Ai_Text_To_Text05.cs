using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using LLama;
using LLama.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using E_APP.SERVICES.AI_SERVICES.AI_HELPER;
namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    internal class Ai_Text_To_Text05
    {
        private readonly Dictionary<string, string> _chunkCache = new();
        private static Ai_Helper01 Ai_H01 = new Ai_Helper01();
        public Ai_Text_To_Text05()
        {
            Ai_H01.LoadModel();
        }

        public async Task<string> text_to_text_content01(string input, Action[] chunkLoader)
        {

            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);
            string textfile_content = string.Empty;

            for (int i = 0; i < chunkLoader.Length; i++)
            {
                if (!_chunkCache.TryGetValue(input, out textfile_content))
                {
                    textfile_content = Ai_H01.RetrieveContext(input, chunkLoader[i], maxChunks: 3);
                    _chunkCache[input] = textfile_content;
                }
            }

            string prompt = $"""

You are a book of Enoch,The King James Bible, and book of the Jubilees scholar.
Answer ONLY using the book of the Jubilees,book of Enoch, and The King James Bible text below.

collection of book Text:
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