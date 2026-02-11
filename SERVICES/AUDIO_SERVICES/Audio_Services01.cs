using NAudio.Wave;
using System.Security;
using System.Speech;
using System.Speech.Synthesis;
using Whisper.net;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Versioning;
namespace E_APP.SERVICES.AUDIO_SERVICES
{
    internal class Audio_Services01
    {
        private string[] data01 = new string[100];
        private static List<SegmentData> segments = new List<SegmentData>();
        private static MemoryStream memoryStream = new MemoryStream();



        public async Task<string> Convert_Speach_to_Text(string input)
        {

        //    Read_External_File01.modelStream01[0].CopyTo(memoryStream);
            memoryStream.Position = 0;

            using var model = WhisperFactory.FromBuffer(memoryStream.ToArray())
                                            .CreateBuilder()
                                            .WithLanguage("en")
                                            .Build();

            // Convert audio to 16KHz WAV
            using var audio16k = ConvertTo16kHz(input);
            await foreach (var segment in model.ProcessAsync(audio16k))
            {
                segments.Add(segment);
            }
            data01[0] = $"{segments.Count.ToString()}\n" +
                 $"{string.Join(" ", segments.Select(s => s.Text))}";

            return data01[0];
        }
        private MemoryStream ConvertTo16kHz(string inputFile)
        {
            using var reader = new AudioFileReader(inputFile);
            var outFormat = new WaveFormat(16000, 16, 1); // 16 kHz, 16-bit, mono
            using var resampler = new MediaFoundationResampler(reader, outFormat)
            {
                ResamplerQuality = 60
            };
            var outputStream = new MemoryStream();
            WaveFileWriter.WriteWavFileToStream(outputStream, resampler);
            outputStream.Position = 0;
            return outputStream;
        }


        [SupportedOSPlatform("windows")]
        public async Task convert_text_to_voice01(string input)
        {
            var synthesizer = new SpeechSynthesizer();

            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Rate = 0;     // speed (-10 to 10)
            synthesizer.Volume = 100; // 0–100

            synthesizer.SpeakAsync(input);


           await Task.CompletedTask;

        }

    }
}