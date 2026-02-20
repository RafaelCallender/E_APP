using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using LLama;
using LLama.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_APP.SERVICES.AI_SERVICES.AI_HELPER
{
    internal class Ai_Helper01
    {
        private static readonly File_Helper01 File_H01 = new File_Helper01();
        private readonly Dictionary<string, string> _chunkCache = new();
        private static bool _chunksLoaded = false;
        private static List<string> ContentChunks = new();
        public ModelParams? _parameters;
        public LLamaWeights? _model;
        private static readonly HashSet<string> StopWords = new()
        {
            "the", "and", "that", "with", "from", "this", "have",
            "were", "shall", "unto", "them", "they", "their"
        };

        public string RetrieveContext(string question, Action? chunkLoader, int maxChunks = 3)
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

        public void LoadModel()
        {

            _parameters = new ModelParams(File_H01.all_text_to_text_gguf_models()[0])
            {
                ContextSize = 4096,
                GpuLayerCount = 0
            };

            _model = LLamaWeights.LoadFromFile(_parameters);
        }



    }
}
