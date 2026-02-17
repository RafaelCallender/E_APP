using CloudinaryDotNet.Core;
using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using LLama;
using LLama.Common;
using LLama.Native;
using System.Text;


namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    internal class Ai_Text_To_Text01
    {
        private string[] data01 = new string[100];
        private static File_Helper01 File_H01 = new File_Helper01();
        private LLamaWeights? model;
        private LLamaContext? context;
      

        public async Task<string> text_to_text_generator01(string input)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();
            var parameters = new ModelParams(modelPath)
            {
                ContextSize = 4096,
                GpuLayerCount = -1 // CPU
            };

            model = LLamaWeights.LoadFromFile(parameters);
            context = model.CreateContext(parameters);
            LLamaToken[] tokenIds = context.Tokenize(input, true);
            int exactTokenCount = tokenIds.Length;

            var inferenceParams = new InferenceParams
            {
                MaxTokens = exactTokenCount

            };


            var executor = new InteractiveExecutor(context);
            await foreach (var token in executor.InferAsync(input, inferenceParams, CancellationToken.None))
            {
                data01[0] += token;
            }

            return data01[0];
        }
        public async Task<string> text_to_text_translate01(string input, string input01, string input02)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();
            string prompt =
        $@"Translate the following text from {input.ToUpper().Trim()} to {input01.ToUpper().Trim()}.
        and only output the translated text.       
        Text: ""{input02}""";
            var parameters = new ModelParams(modelPath)
            {
                ContextSize = 4096,
                GpuLayerCount = -1
            };

            model = LLamaWeights.LoadFromFile(parameters);
            context = model.CreateContext(parameters);
            LLamaToken[] tokenIds = context.Tokenize(prompt, true);
            int exactTokenCount = tokenIds.Length;
            var inferenceParams = new InferenceParams
            {
                MaxTokens = exactTokenCount
            };
            var executor = new InteractiveExecutor(context);
            await foreach (var token in executor.InferAsync(prompt, inferenceParams, CancellationToken.None))
            {
                data01[0] += token;
            }

            return data01[0];
        }

    }
}