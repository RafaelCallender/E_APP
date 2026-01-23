
using System.Diagnostics;


namespace E_APP.SERVICES.PYTHON_SERVICES.PYTHON_HELPER
{
    internal class Python_Helper01
    {

        private string[] data01 = new string[100];
        public string RunTextToImage(string input)
        {
            string prompt = input;
            string outputPath = "video_output.mp4";

            // Path to your Python script
            // Make sure this points to your actual .py file
            string pythonScript = @"C:\path\to\your\script.py";

            // Path to python.exe
            string pythonExe = @"C:\path\to\python.exe";

            // Build arguments
            string arguments = $"\"{pythonScript}\" \"{prompt}\" \"{outputPath}\"";

            // Create process start info
            var startInfo = new ProcessStartInfo
            {
                FileName = pythonExe,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.OutputDataReceived += (sender, e) =>
                {

                    data01[0] += e.Data;
                };

                process.ErrorDataReceived += (sender, e) =>
                {

                    data01[0] += "ERROR: " + e.Data;
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();
            }
            return data01[0];

        }
    }
}