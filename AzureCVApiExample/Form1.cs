using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AzureCVApiExample
{
    public partial class Form1 : Form
    {
        private const string _apiKey = "cc3dc874fe0247879bf8f6b29d51f6aa";
        private const string _apiEndpoint = "https://cv-20200606.cognitiveservices.azure.com/";
        private Stream _imageStream = null;
        private IEnumerable<Rectangle> _faceRectangles = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSelectImage_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _faceRectangles = Enumerable.Empty<Rectangle>();

                    var stream = File.OpenRead(ofd.FileName);
                    panelImage.BackgroundImage = Image.FromStream(stream);
                    panelImage.Refresh();

                    Bitmap bmp = new Bitmap(panelImage.ClientSize.Width, panelImage.ClientSize.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.DrawImage(panelImage.BackgroundImage,
                            new Rectangle(0, 0, bmp.Width, bmp.Height));
                    }

                    _imageStream = new MemoryStream();
                    bmp.Save(_imageStream, panelImage.BackgroundImage.RawFormat);
                    _imageStream.Flush();
                    _imageStream.Position = 0;

                    txtResponseContent.Text = "Analyzing image...";
                    AnalyzeImage();
                }
            }
        }
        
        private void AnalyzeImage()
        {
            var client = new ComputerVisionClient(new ApiKeyServiceClientCredentials(_apiKey));
            client.Endpoint = _apiEndpoint;

            var features = new List<VisualFeatureTypes>()
            {
                VisualFeatureTypes.Categories,
                VisualFeatureTypes.Color,
                VisualFeatureTypes.Adult,
                VisualFeatureTypes.Brands,
                VisualFeatureTypes.Description,
                VisualFeatureTypes.ImageType,
                VisualFeatureTypes.Objects,
                VisualFeatureTypes.Tags,
                VisualFeatureTypes.Faces
            };

            var result = client.AnalyzeImageInStreamAsync(_imageStream, features).Result;

            // extract face rectangle.
            if (result.Faces.Count > 0)
            {
                _faceRectangles = result.Faces.Select(x => new Rectangle()
                {                    
                    Location = new Point(x.FaceRectangle.Left, x.FaceRectangle.Top),
                    Size = new Size(x.FaceRectangle.Width, x.FaceRectangle.Height)
                });
            }
            else
                _faceRectangles = Enumerable.Empty<Rectangle>();

            panelImage.Refresh();
            txtResponseContent.Text = JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        private void panelImage_Paint(object sender, PaintEventArgs e)
        {
            if (_faceRectangles == null || _faceRectangles.Count() == 0)
                return;

            var g = e.Graphics;

            foreach (var rect in _faceRectangles)
            {
                var brush = new SolidBrush(Color.Blue);
                var pen = new Pen(brush, 3);

                g.DrawRectangle(pen, rect);
            }
        }
    }
}
