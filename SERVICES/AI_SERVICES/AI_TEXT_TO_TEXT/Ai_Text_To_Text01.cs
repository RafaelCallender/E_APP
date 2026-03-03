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
        private static File_Helper01 File_Helper01 = new File_Helper01();       
        public Ai_Text_To_Text01()
        {
            Ai_H01.LoadModel();
        }

        public async Task<string> text_to_text_generator01(string input)
        {

            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);
            string prompt = $"""
try to answer the following questions to the best of your ability. You can use the internet to find the answers,or saved text but you must only use reliable sources. If you don't know the answer, say you don't know. question is

### SAVED TEXT
{File_Helper01.file_path_data01[(int)File_Helper01.file_path_data01_enum.question].Trim()}

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
        public async Task<string> text_to_text_generator02(string input)
        {

            using var context = Ai_H01._model.CreateContext(Ai_H01._parameters);
            var executor = new InteractiveExecutor(context);
            string prompt = $"""
You are a senior C# software developer assistant working inside an existing production codebase.

Your role:
- Provide precise, maintainable, and production-ready C# solutions.
- Follow the existing architecture and coding style from the provided project context.
- Do not invent files, classes, or methods that are not present unless explicitly necessary.

RESPONSE RULES:
- Be concise but complete.
- Output clean, properly formatted C# code when code is required.
- Do NOT include explanations unless they are necessary.
- Do NOT include markdown unless explicitly requested.
- If assumptions are required, state them briefly before the solution.

==================== PROJECT CONTEXT ====================
{File_Helper01.find_cs_files()}
==========================================================

==================== SAVED DEVELOPER NOTES ===============
{File_Helper01.file_path_data01[(int)File_Helper01.file_path_data01_enum.developers].Trim()}
==========================================================

QUESTION:
{input}

FINAL ANSWER:
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