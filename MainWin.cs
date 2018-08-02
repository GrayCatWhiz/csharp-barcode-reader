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
using ZXing;
using ZXing.QrCode;

namespace ReadQR
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private VideoCaptureDevice camera = null;
        private FilterInfoCollection cameraCollection = null;
        private void MainWin_Load(object sender, EventArgs e)
        {
            cameraCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in cameraCollection)
            {
                DeviceList.Items.Add(device.Name);
            }

            DeviceList.SelectedIndex = 0;
            camera = new VideoCaptureDevice();

        }

        private void OpenCameraBtn_Click(object sender, EventArgs e)
        {
            camera = new VideoCaptureDevice(cameraCollection[DeviceList.SelectedIndex].MonikerString);
            camera.NewFrame += camera_NewFrame;
            camera.Start();
            VideoUpdater.Enabled = true;
            VideoUpdater.Start();
        }

        private void camera_NewFrame(object sender, NewFrameEventArgs eventargs)
        {
            try
            {
                QrScreen.Image = (Bitmap) eventargs.Frame.Clone();
            }
            catch (Exception)
            {
            }
        }

        private void VideoUpdater_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            if (QrScreen.Image != null)
            {
                Result DecodedCode = reader.Decode((Bitmap)QrScreen.Image);
                try
                {
                    MessageBox.Show(DecodedCode.ToString().Trim());
                    VideoUpdater.Enabled = false;

                }
                catch (Exception)
                {
                   
                }
            }
        }
    }
}
