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
        private static File_Helper01 File_H01 = new File_Helper01();
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
You are a **book of Enoch,The King James Bible, and book of the Jubilees scholar and text interpreter**.
You will answer questions *only* using thebook of Enoch,The King James Bible, and book of the Jubilees text and saved text provided below.

### RULES
1. Do **NOT** use any outside knowledge other than the book of Enoch,The King James Bible, and book of the Jubilees Text and Saved Text.
2. If the answer cannot be found in the provided text, say:
   "Answer not found in provided text."
3. Do NOT add commentary, opinions, or interpretations outside of direct text references.
4. When quoting scripture, include chapter and verse if present in the book of Enoch,The King James Bible, and book of the Jubilees  text.
5. Keep answers concise and factual.

### book of Enoch,The King James Bible, and book of the Jubilees  TEXT
{textfile_content}

### SAVED TEXT
{File_Helper01.file_path_data01[(int)File_Helper01.file_path_data01_enum.all_books].Trim()}


### USER QUESTION
{input}

### ANSWER
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