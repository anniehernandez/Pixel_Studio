using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace PI_PixelStudio
{
    public partial class CameraUserCtrl : UserControl
    {
        private VideoCapture capture;
        private Mat frame;
        private Bitmap image;
        private bool isOpen = false;
        private bool isCapturing = false;
        public CameraUserCtrl()
        {
            InitializeComponent();
            GetCameras();
        }
        private void GetCameras()
        {
            int indexCamera = 0;
            while (true)
            {
                VideoCapture testCapture = new VideoCapture(indexCamera);
                if (!testCapture.IsOpened())
                    break;

                SelectCamera.Items.Add($"Camera {indexCamera + 1}");
                testCapture.Release();
                indexCamera++;
            }
            if (SelectCamera.Items.Count > 0)
            {
                SelectCamera.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No Cameras where found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void OpenCamera_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                int cameraIndex = SelectCamera.SelectedIndex;
                capture = new VideoCapture(cameraIndex);

                Application.Idle += ProcessFrame;

                OpenCloseCamera.Image = Properties.Resources.close_camera;
                isOpen = true;
                isCapturing = true;
            }
            else
            {
                Application.Idle -= ProcessFrame;
                capture.Release();
                CameraImage.Image = null;

                OpenCloseCamera.Image = Properties.Resources.open_camera;
                isOpen = false;
                isCapturing = false;
            }
        }
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (capture != null && capture.IsOpened())
            {
                frame = new Mat();
                capture.Read(frame);

                if (!frame.Empty())
                {
                    image = BitmapConverter.ToBitmap(frame);

                    using (Graphics g = Graphics.FromImage(image))
                    {
                        int centerX = frame.Width / 2;
                        int centerY = frame.Height / 2;
                        int boxSize = 50;

                        Pen pen = new Pen(Color.Red, 1);
                        g.DrawLine(pen, centerX - 40, centerY, centerX + 40, centerY);
                        g.DrawLine(pen, centerX, centerY - 40, centerX, centerY + 40);
                        g.DrawRectangle(pen, centerX - boxSize / 2, centerY - boxSize / 2, boxSize, boxSize);
                    }

                    CameraImage.Image = image;

                    if (isCapturing)
                    {
                        GetColor();
                    }
                }
            }
        }

        private void GetColor()
        {
            if (frame == null || frame.Empty()) return;

            Mat labImg = new Mat();

            Cv2.CvtColor(frame, labImg, ColorConversionCodes.BGR2Lab);

            int x = labImg.Width / 2;
            int y = labImg.Height / 2;

            Vec3b pixel = labImg.At<Vec3b>(y, x);

            int L = (int)(pixel.Item0 / 2.55);
            int a = pixel.Item1 - 128;
            int b = pixel.Item2 - 128;

            if (a > 0)
            {
                if (b > 0)
                {
                    QTextBox.Text = "Quadrant I";
                }
                else
                {
                    QTextBox.Text = "Quadrant IV";
                }
            }
            else
            {
                if (b > 0)
                {
                    QTextBox.Text = "Quadrant II";
                }
                else
                {
                    QTextBox.Text = "Quadrant III";
                }

            }

            LTextBox.Text = $"{L}";
            aTextBox.Text = $"{a}";
            bTextBox.Text = $"{b}";

            Color colorDisplay = LABtoRGB((int)(L * 2.55), a + 128, b + 128);
            ColorDisplay.BackColor = colorDisplay;
            PlotCIELABColor(a, b);

            HexadecimalTextBox.Text = $"#{colorDisplay.R:X2}{colorDisplay.G:X2}{colorDisplay.B:X2}";
        }
        private void PlotCIELABColor(float a, float b)
        {
            Bitmap labChart = new Bitmap(Properties.Resources.CIELAB1);
            Graphics g = Graphics.FromImage(labChart);

            int centerX = labChart.Width / 2;
            int centerY = labChart.Height / 2;
            int scale = 3;

            int posX = centerX + (int)(a * scale);
            int posY = centerY - (int)(b * scale);

            Pen pen = new Pen(Color.Red, 3);
            g.DrawEllipse(pen, posX - 5, posY - 5, 10, 10);

            pictureBox1.Image = labChart;
        }
        private Color LABtoRGB(int L, int A, int B)
        {
            Mat labMat = new Mat(1, 1, MatType.CV_8UC3, new Scalar(L, A, B));
            Mat bgrMat = new Mat();

            Cv2.CvtColor(labMat, bgrMat, ColorConversionCodes.Lab2BGR);

            Vec3b bgrPixel = bgrMat.At<Vec3b>(0, 0);
            Color rgbColor = Color.FromArgb(bgrPixel.Item2, bgrPixel.Item1, bgrPixel.Item0);

            labMat.Dispose();
            bgrMat.Dispose();

            return rgbColor;
        }
        private void CaptureButton_Click(object sender, EventArgs e)
        {
            if (isCapturing)
            {
                CaptureButton.Text = "Let Go";
                isCapturing = false;
            }
            else
            {
                CaptureButton.Text = "Capture";
                GetColor();

                isCapturing = true;
            }
        }
    }
}
