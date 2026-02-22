using CloudinaryDotNet.Core;
using E_APP.SERVICES.AI_SERVICES.AI_HELPER;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using LLama;
using LLama.Common;
using LLama.Native;
using System.CodeDom.Compiler;
using System.Text;


namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{

    internal class Ai_Text_To_Text01
    {

        private static Ai_Helper01 Ai_H01 = new Ai_Helper01();

        public Ai_Text_To_Text01()
        {
            Ai_H01.LoadModel();
        }

        public async Task<string> text_to_text_generator01(string input)
        {

            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);
            string prompt = $"""
try to answer the following questions to the best of your ability. You can use the internet to find the answers, but you must only use reliable sources. If you don't know the answer, say you don't know. question is

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