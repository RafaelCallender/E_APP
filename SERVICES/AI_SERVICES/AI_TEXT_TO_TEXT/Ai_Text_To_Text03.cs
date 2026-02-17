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
        private static readonly File_Helper01 File_H01 = new File_Helper01();

        private LLamaWeights? _model;
        private LLamaContext? _context;

        private ModelParams? _parameters;

        private readonly Dictionary<string, string> _chunkCache = new();

        // Bible chunk storage
        private static bool _chunksLoaded = false;
        private static List<string> ContentChunks = new();

        private static readonly HashSet<string> StopWords = new()
        {
            "the", "and", "that", "with", "from", "this", "have",
            "were", "shall", "unto", "them", "they", "their"
        };

        public Ai_Text_To_Text03()
        {
            LoadModel();
        }

        private void LoadModel()
        {
            string[] models = File_H01.all_text_to_text_gguf_models();
            string modelPath = models[0].Trim();

            _parameters = new ModelParams(modelPath)
            {
                ContextSize = 4096,
                GpuLayerCount = 0
            };

            _model = LLamaWeights.LoadFromFile(_parameters);
        }

        public async Task<string> text_to_text_content01(string input, Action? chunkLoader)
        {
            if (_model == null || _parameters == null)
                throw new InvalidOperationException("Model not initialized.");

            // 🔥 CREATE FRESH CONTEXT EACH QUESTION
            using var context = _model.CreateContext(_parameters);
            var executor = new InteractiveExecutor(context);

            string bibleContext;

            if (!_chunkCache.TryGetValue(input, out bibleContext))
            {
                bibleContext = RetrieveContext(input, chunkLoader, maxChunks: 3);
                _chunkCache[input] = bibleContext;
            }

            string prompt = $"""
You are a book of the Enoch scholar.
Answer ONLY using the book of the Enoch text below.

book of the Enoch Text:
{bibleContext}

Question:
{input}

Answer:
""";

            var inferenceParams = new InferenceParams
            {
                MaxTokens = 512,

                AntiPrompts = new List<string> { "Question:" }
            };

            var result = new StringBuilder();

            await foreach (var token in executor.InferAsync(prompt, inferenceParams))
            {
                result.Append(token);
            }

            return result.ToString().Trim();
        }


        private string RetrieveContext(string question, Action? chunkLoader, int maxChunks = 3)
        {
            if (!_chunksLoaded && chunkLoader != null)
            {
                chunkLoader();
                _chunksLoaded = true;
            }

            if (ContentChunks.Count == 0)
                return string.Empty;

            var keywords = question
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(w => w.Trim().ToLowerInvariant())
                .Where(w => w.Length > 3 && !StopWords.Contains(w))
                .Distinct()
                .ToList();

            if (keywords.Count == 0)
                return string.Empty;

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

        private static void LoadBibleChunks(List<string> chunks)
        {
            ContentChunks = chunks;
            _chunksLoaded = true;
        }

        private void Dispose()
        {
            _context?.Dispose();
            _model?.Dispose();
        }
    }
}
