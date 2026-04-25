using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessingApp
{
    public partial class Form1 : Form
    {
        Bitmap currentImage;
        Bitmap originalImage;

        public Form1()
        {
            InitializeComponent();
        }

        // 🟢 Open
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentImage = new Bitmap(ofd.FileName);
                originalImage = new Bitmap(ofd.FileName);

                pictureBox1.Image = currentImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // ⚫ Gray
        private void btnGray_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap bmp = new Bitmap(currentImage);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int gray = (c.R + c.G + c.B) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBox1.Image = bmp;
            currentImage = bmp;
        }

        // 🔴 Negative
        private void button7_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap bmp = new Bitmap(currentImage);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y,
                        Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }

            pictureBox1.Image = bmp;
            currentImage = bmp;
        }

        // ☀️ Bright +
        private void btnBrightPlus_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap bmp = new Bitmap(currentImage);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int r = Math.Min(255, c.R + 30);
                    int g = Math.Min(255, c.G + 30);
                    int b = Math.Min(255, c.B + 30);

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox1.Image = bmp;
            currentImage = bmp;
        }

        // 🌑 Bright -
        private void btnBrightMinus_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap bmp = new Bitmap(currentImage);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int r = Math.Max(0, c.R - 30);
                    int g = Math.Max(0, c.G - 30);
                    int b = Math.Max(0, c.B - 30);

                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox1.Image = bmp;
            currentImage = bmp;
        }

        // 🌫️ Gaussian Blur
        private void btnBlur_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap bmp = new Bitmap(currentImage);
            Bitmap blurred = new Bitmap(bmp.Width, bmp.Height);

            int[,] kernel = {
                {1, 2, 1},
                {2, 4, 2},
                {1, 2, 1}
            };

            int kernelSum = 16;

            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    int r = 0, g = 0, b = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = bmp.GetPixel(x + kx, y + ky);
                            int weight = kernel[ky + 1, kx + 1];

                            r += pixel.R * weight;
                            g += pixel.G * weight;
                            b += pixel.B * weight;
                        }
                    }

                    r /= kernelSum;
                    g /= kernelSum;
                    b /= kernelSum;

                    blurred.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox1.Image = blurred;
            currentImage = blurred;
        }

        // ✂️ Edge Detection (Sobel)
        private void btnEdge_Click(object sender, EventArgs e)
        {
            if (currentImage == null) return;

            Bitmap bmp = new Bitmap(currentImage);
            Bitmap edge = new Bitmap(bmp.Width, bmp.Height);

            int[,] gx = {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] gy = {
                { -1, -2, -1 },
                {  0,  0,  0 },
                {  1,  2,  1 }
            };

            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    int sumX = 0;
                    int sumY = 0;

                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = bmp.GetPixel(x + kx, y + ky);
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;

                            sumX += gray * gx[ky + 1, kx + 1];
                            sumY += gray * gy[ky + 1, kx + 1];
                        }
                    }

                    int mag = (int)Math.Sqrt(sumX * sumX + sumY * sumY);
                    mag = Math.Min(255, mag);

                    edge.SetPixel(x, y, Color.FromArgb(mag, mag, mag));
                }
            }

            pictureBox1.Image = edge;
            currentImage = edge;
        }

        // 🔁 Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;

            currentImage = new Bitmap(originalImage);
            pictureBox1.Image = currentImage;
        }
    }
}