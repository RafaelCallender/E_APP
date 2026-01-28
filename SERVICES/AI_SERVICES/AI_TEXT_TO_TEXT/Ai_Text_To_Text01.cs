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
        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private static readonly object _lock = new();

        private static LLamaWeights? _weights;
        private static LLamaContext? _context;
        private static string? _loadedModelPath;

        private static readonly List<string> ContentChunks = new();
        private static bool _chunksLoaded = false;
        private static LLamaWeights model;
        private static LLamaContext context;

        // Common Bible stopwords
        private static readonly HashSet<string> StopWords = new(StringComparer.OrdinalIgnoreCase)
{
    "the","and","shall","said","unto","that","for","with","they","them","his","her"
};




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


        public async Task<string> text_to_text_content01(string question)
        {
            int index = 0;
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[index].Trim();
            string bibleContext = The_Bible_Serv01.read_full_bible_text();
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

            return data01[0].Trim();
        }
        public async Task<string> text_to_text_content01(string question, Action chunkLoader)
        {

            string modelPath = File_H01
                .all_text_to_text_gguf_models()[0]
                .Trim();

            var context = GetContext(modelPath);
            string bibleContext = RetrieveContext(question, chunkLoader, maxChunks: 3);

            string prompt = $"""
You are a Bible scholar.
Answer ONLY using the King James Version Bible text below.

Bible Text:
{bibleContext}

Question:
{question}

Answer:
""";

            var inferenceParams = new InferenceParams
            {
                MaxTokens = 512
            };

            var executor = new InteractiveExecutor(context);

            var sb = new StringBuilder();
            await foreach (var token in executor.InferAsync(
                prompt, inferenceParams, CancellationToken.None))
            {
                sb.Append(token);
            }

            return sb.ToString().Trim();
        }
        private LLamaContext GetContext(string modelPath)
        {
            lock (_lock)
            {
                if (_context != null && _loadedModelPath == modelPath)
                    return _context;

                _context?.Dispose();
                _weights?.Dispose();

                var parameters = new ModelParams(modelPath)
                {
                    ContextSize = 4096, 
                    GpuLayerCount = -1
                };

                _weights = LLamaWeights.LoadFromFile(parameters);
                _context = _weights.CreateContext(parameters);
                _loadedModelPath = modelPath;

                return _context;
            }
        }

        private string RetrieveContext(string question, Action chunkLoader, int maxChunks = 3)
        {
            // Call the passed-in chunk loader if chunks aren't loaded yet
            if (!_chunksLoaded && chunkLoader != null)
            {
                chunkLoader();  // This will call something like The_Bible_Serv01.LoadBibleChunks()
            }

            // Split question into keywords
            var keywords = question
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.Trim().ToLowerInvariant())
                .Where(w => w.Length > 3 && !StopWords.Contains(w))
                .Distinct()
                .ToList();

            if (keywords.Count == 0)
                return string.Empty;

            // Score and rank chunks
            var rankedChunks = ContentChunks
                .Select(chunk => new
                {
                    Text = chunk,
                    Score = keywords.Sum(k =>
                        chunk.Contains(k, StringComparison.OrdinalIgnoreCase) ? 1 : 0)
                })
                .Where(x => x.Score > 0)
                .OrderByDescending(x => x.Score)
                .Take(maxChunks)
                .Select(x => x.Text);

            return string.Join("\n\n", rankedChunks);
        }

    }
}