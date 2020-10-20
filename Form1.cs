using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.Util;

namespace OPTICAL_FLOW_EMGU
{
    public partial class Form1 : Form
    {
        Capture cap = null;
        Mat source = new Mat();
        Mat hsv = new Mat();
        Mat output = new Mat();

        double hmin, hmax, smin, smax, vmin, vmax;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cap = new Capture();
            cap.ImageGrabbed +=cap_ImageGrabbed;
            cap.Start();
        }

        void cap_ImageGrabbed(object sender, EventArgs e)
        {
            cap.Retrieve(source);
            CvInvoke.CvtColor(source, hsv, ColorConversion.Bgr2Hsv);
            CvInvoke.InRange(hsv, new ScalarArray(new MCvScalar(hmin, smin, vmin)), new ScalarArray(new MCvScalar(hmax, smax, vmax)), output);

            Mat filter = CvInvoke.GetStructuringElement(ElementShape.Ellipse, new Size(4, 4), new Point(1, 1));
            CvInvoke.Erode(output, output, filter, new Point(1, 1), 1, BorderType.Constant, new MCvScalar(1, 1, 1, 1));
            CvInvoke.Dilate(output, output, filter, new Point(1, 1), 1, BorderType.Constant, new MCvScalar(1, 1, 1, 1));

            imageBox1.Image = source;
            imageBox2.Image = hsv;
            imageBox3.Image = output;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hmin = hmin_trackBar1.Value;
            hmax = hmax_trackBar2.Value;
            smin = smin_trackBar3.Value;
            smax = smax_trackBar4.Value;
            vmin = vmin_trackBar5.Value;
            vmax = vmax_trackBar6.Value;

            label1.Text = hmin.ToString();
            label2.Text = hmax.ToString();
            label3.Text = smin.ToString();
            label4.Text = smax.ToString();
            label5.Text = vmin.ToString();
            label6.Text = vmax.ToString();
        }

       
    }
}