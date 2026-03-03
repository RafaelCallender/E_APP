using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;
using Newtonsoft.Json.Linq;
using System.Diagnostics;


namespace E_APP.SERVICES.DEVICE_SERVICES
{
    internal class Device_Services01
    {
        private static string[] data01 = new string[3];
        private static Read_Textfiles READ=new Read_Textfiles();    
        public string launch_default_browser(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
            data01[0] = "Success";
            return data01[0];
        }
        public  async Task<string> get_device_ip()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://ipinfo.io/json";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string json = await response.Content.ReadAsStringAsync();
                JObject data = JObject.Parse(json);
                data01[0] += $"{data["ip"]?.ToString()}\n" +
                            $"{data["city"]?.ToString()}\n" +
                            $"{data["region"]?.ToString()}\n" +
                            $"{data["country"]?.ToString()}\n" +
                            $"{data["loc"]?.ToString()}\n";

                data01[1] = $"{data["loc"]?.ToString()}\n";

                return data01[1];
            }
        }
        public  string image_to_url(string input)
        {
            var account = new Account(
                  $"{READ.cloudinary_com[0].Trim()}",   // <-- Replace with your Cloudinary cloud name
                  $"{READ.API[1].Trim()}",      // <-- Replace with your Cloudinary API key
                  $"{READ.cloudinary_com[1].Trim()}"    // <-- Replace with your Cloudinary API secret
              );

            var cloudinary = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription($"{input}"),
                UseFilename = true,
                UniqueFilename = false,
                Overwrite = true
            };

            // 4. Upload image
            var uploadResult = cloudinary.Upload(uploadParams);

            // 5. Output public URL
            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                data01[0] += $"{uploadResult.SecureUrl.ToString()}";
            }
            else
            {
                data01[0] = $"Upload failed:\n";
            }
            return data01[0];
        }
        public  async Task<string> image_url_to_file(string input)
        {
            // input = image URL
            string folderPath = @"C:\Photo01";
            Directory.CreateDirectory(folderPath);
            // Generate a unique filename from timestamp or GUID
            string fileName = "downloaded_image_" + DateTime.Now.Ticks + ".jpg";
            string fullPath = Path.Combine(folderPath, fileName);

            using (HttpClient client = new HttpClient())
            {

                byte[] imageBytes = await client.GetByteArrayAsync(input);
                await File.WriteAllBytesAsync(fullPath, imageBytes);
                data01[0] = "Image saved to: " + fullPath;

            }

            return data01[0];
        }
        public string open_files_using_windows(string input)
        {

            if (File.Exists(input.Trim()) == true)
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = $"{input.Trim()}",
                    UseShellExecute = true
                });
                data01[0] = "Success";
            }
            else
            {
                data01[0] = "Fail";
            }
            return data01[0];

        }
    }
}