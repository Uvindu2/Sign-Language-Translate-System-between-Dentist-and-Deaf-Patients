using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatsiTranscriber.View
{
    public partial class TestingWindow : Form
    {
        private Bitmap loadedImage;

        public TestingWindow()
        {
            InitializeComponent();
        }

        private void OpenImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    loadedImage = new Bitmap(openFileDialog.FileName);
                    SenderImage.Image = new Bitmap(loadedImage);  // Display image in sender PictureBox
                }
            }
        }

        private async void ManualTrigger(object sender, EventArgs e)
        {
            if (loadedImage != null)
            {
                var response = await SendImageToApiAsync(loadedImage);
                if (!string.IsNullOrEmpty(response))
                {
                    TranscriptionTextbox.Text = response;  // Display result with text
                    MessageBox.Show($"Prediction: {response}", "API Response");
                }
            }
            else
            {
                MessageBox.Show("Please load an image first!", "Error");
            }
        }

        private async Task<string> SendImageToApiAsync(Bitmap image)
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "manual_test_image.jpg");
            image.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            using (var client = new HttpClient())
            using (var content = new MultipartFormDataContent())
            {
                content.Add(new ByteArrayContent(File.ReadAllBytes(tempPath)), "file", "manual_test_image.jpg");

                try
                {
                    var response = await client.PostAsync("http://localhost:5000/predict", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response to extract the prediction
                        var result = System.Text.Json.JsonDocument.Parse(jsonResponse);
                        string prediction = result.RootElement.GetProperty("prediction").GetString();

                        return prediction; // Return the predicted letter
                    }
                    else
                    {
                        MessageBox.Show("Failed to get a valid response from the API.", "Error");
                        return string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Exception");
                    return string.Empty;
                }
            }
        }

        private Bitmap DrawTextOnImage(Bitmap image, string text)
        {
            Bitmap result = new Bitmap(image);
            using (Graphics g = Graphics.FromImage(result))
            {
                using (Font font = new Font("Arial", 24, FontStyle.Bold))
                {
                    g.DrawString(text, font, Brushes.Red, new PointF(10, 10));
                }
            }
            return result;
        }
    }
}
