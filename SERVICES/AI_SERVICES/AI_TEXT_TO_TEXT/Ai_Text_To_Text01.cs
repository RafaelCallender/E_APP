using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using LLama;
using LLama.Common;
using E_APP.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;


namespace E_APP.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT
{
    internal class Ai_Text_To_Text01
    {
        private string[] data01 = new string[100];
        private static File_Helper01 File_H01 = new File_Helper01();
        private static The_Bible_Services01 The_Bible_Serv01= new The_Bible_Services01();   
        public async Task<string> text_generation(string input)
        {
            //  data01[1] = await text_to_text_generator01(input);
            data01[1] = await text_to_text_generator02(input);

            return data01[1];
        }

        private async Task<string> text_to_text_generator01(string input)
        {
            int index = 1;
            string[] model01 = File_H01.all_embedded_gguf_models().Split("\n");
            string file01 = model01[index].Trim();
            string fileName = string.Join(".",
                              model01[index].Split('.').TakeLast(2));
            var parameters = new ModelParams(file01)
            {
                ContextSize = 512,
                GpuLayerCount = 0 // Use CPU only
            };
            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);
            var executor = new InteractiveExecutor(context);
            var session = new ChatSession(executor);
            var inferenceParams = new InferenceParams
            {
                MaxTokens = 128,

            };
            var userMessage = new ChatHistory.Message(AuthorRole.User, input);
            await foreach (var token in session.ChatAsync(userMessage, inferenceParams, CancellationToken.None))
            {
                data01[0] += (token);
            }

            return data01[0];
        }

        private async Task<string> text_to_text_generator02(string input)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();

            // Estimate needed context size: input length + buffer (say 50% extra)
            int estimatedInputTokens = Math.Max(32, input.Length / 4); // rough estimate: 1 token ~ 4 chars
            uint contextSize = (uint)Math.Min(4096, estimatedInputTokens + 128); // don't exceed model max

            // Estimate output size: 2x input length (or max 1024)
            int maxTokens = Math.Min(1024, estimatedInputTokens * 2);

            var parameters = new ModelParams(modelPath)
            {
                ContextSize = contextSize,
                GpuLayerCount = 0 // CPU
            };

            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);

            var inferenceParams = new InferenceParams
            {
                MaxTokens = maxTokens

            };

            data01[0] = "";
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




            // Estimate needed context size: input length + buffer (say 50% extra)
            int estimatedInputTokens = Math.Max(32, prompt.Length / 4); // rough estimate: 1 token ~ 4 chars
            uint contextSize = (uint)Math.Min(4096, estimatedInputTokens + 128); // don't exceed model max

            // Estimate output size: 2x input length (or max 1024)
            int maxTokens = Math.Min(1024, estimatedInputTokens * 2);

            var parameters = new ModelParams(modelPath)
            {
                ContextSize = contextSize,
                GpuLayerCount = 0 // CPU
            };

            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);

            var inferenceParams = new InferenceParams
            {
                MaxTokens = maxTokens

            };

            data01[0] = "";
            var executor = new InteractiveExecutor(context);
            await foreach (var token in executor.InferAsync(prompt, inferenceParams, CancellationToken.None))
            {
                data01[0] += token;
            }

            return data01[0];
        }


        public async Task<string> text_to_text_bible(string question)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();

            string bibleContext = The_Bible_Serv01.RetrieveBibleContext(question);

            string prompt =
        $"""
You are a Bible scholar.
Answer ONLY using the King James Version Bible text below.
If the answer is not found, say "The Bible does not explicitly state this."

Bible Text:
{bibleContext}

Question:
{question}

Answer:
""";

            int estimatedInputTokens = Math.Max(128, prompt.Length / 4);
            uint contextSize = (uint)Math.Min(4096, estimatedInputTokens + 256);
            int maxTokens = 512;

            var parameters = new ModelParams(modelPath)
            {
                ContextSize = contextSize,
                GpuLayerCount = 0 // CPU
            };

            using var model = LLamaWeights.LoadFromFile(parameters);
            using var context = model.CreateContext(parameters);

            var inferenceParams = new InferenceParams
            {
                MaxTokens = maxTokens,

            };

            var executor = new InteractiveExecutor(context);

            string output = "";
            await foreach (var token in executor.InferAsync(prompt, inferenceParams, CancellationToken.None))
            {
                output += token;
            }

            return output.Trim();
        }
    }
}