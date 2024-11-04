using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json;

namespace MatsiTranscriber.View
{
    public partial class ShellWindow : Form
    {
        private FilterInfoCollection webcamDevices;  // List of available webcams
        private VideoCaptureDevice webcam;           // Selected webcam device
        private System.Timers.Timer frameTimer;      // Timer to extract frames every 3 seconds

        public ShellWindow()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            // Get the available webcams
            webcamDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (webcamDevices.Count == 0)
            {
                MessageBox.Show("No webcam found.");
                return;
            }

            // Select the first available webcam
            webcam = new VideoCaptureDevice(webcamDevices[0].MonikerString);
            webcam.NewFrame += Webcam_NewFrame;  // Handle new frame event
            webcam.Start();

            // Initialize the timer to extract frames every 3 seconds
            frameTimer = new System.Timers.Timer(3000);  // 3000ms = 3 seconds
            frameTimer.Elapsed += async (s, ev) => await CaptureFrameAsync();
            frameTimer.Start();
        }

        private void Webcam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Display the current frame in the PictureBox
            Previewer.Image?.Dispose();  // Avoid memory leak
            Previewer.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private async Task CaptureFrameAsync()
        {
            if (Previewer.Image == null) return;

            // Save the current frame as a temporary JPEG file
            string tempFilePath = Path.GetTempFileName();
            Previewer.Image.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            // Send the image to the API
            var prediction = await SendImageToApiAsync(tempFilePath);

            // Update the label with the prediction result
            TranscriptionTextbox.Invoke((MethodInvoker)(() => TranscriptionTextbox.Text = $"Prediction: {prediction}"));

            // Clean up the temporary file
            File.Delete(tempFilePath);
        }

        private async Task<string> SendImageToApiAsync(string imagePath)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var content = new MultipartFormDataContent();
                    var imageContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
                    imageContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");
                    content.Add(imageContent, "file", Path.GetFileName(imagePath));

                    // Send POST request to Flask API
                    HttpResponseMessage response = await client.PostAsync("http://localhost:5000/predict", content);
                    response.EnsureSuccessStatusCode();

                    // Parse the JSON response
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic result = JsonConvert.DeserializeObject(jsonResponse);

                    return result.prediction;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return "Error";
                }
            }
        }
    }
}
