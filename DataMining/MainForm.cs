using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataMining {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        PCA pca;
        KMeans kmeans;

        private void DrawPoint(PictureBox pictureBox, int x, int y, Color color)
        {
            Graphics g = Graphics.FromHwnd(pictureBox.Handle);
            SolidBrush brush = new SolidBrush(color);
            Point point = new Point(x, y);
            point.X = point.X - 5;
            point.Y = point.Y - 5;
            Rectangle rect = new Rectangle(point, new Size(5, 5));
            g.FillRectangle(brush, rect);
            g.Dispose();
        }

        private void PCAOpenImage_Click(object sender, EventArgs @event) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
                pca = new PCA((Bitmap)PCAPicture.Image);
            }
        }

        private void PCAComponent1_Click(object sender, EventArgs e) {
            pca.ChangeImage(useDoubleValue: false, useTripleValue: false);
            PCAPicture.Refresh();
        }

        private void PCAComponent12_Click(object sender, EventArgs e) {
            pca.ChangeImage(useTripleValue: false);
            PCAPicture.Refresh();
        }

        private void PCAComponent13_Click(object sender, EventArgs e) {
            pca.ChangeImage(useDoubleValue: false);
            PCAPicture.Refresh();
        }

        private void PCAComponent23_Click(object sender, EventArgs e) {
            pca.ChangeImage(useSingleValue: false);
            PCAPicture.Refresh();
        }

        private void PCAComponent3_Click(object sender, EventArgs e) {
            pca.ChangeImage();
            PCAPicture.Refresh();
        }

        private void PCAReset_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
                pca = new PCA((Bitmap)PCAPicture.Image);
            }
        }

        private void KMeansRun_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                KMeansPicture.Image = new Bitmap(openFileDialog1.OpenFile());
                kmeans = new KMeans((Bitmap)KMeansPicture.Image);
            }
        }

        private void KMeansFindNewCenters_Click(object sender, EventArgs e)
        {
            kmeans.FindNewCenters((int)KMeansClusters.Value);
            KMeansShowPoints_Click(sender, e);
        }

        private void KMeansShowClusters_Click(object sender, EventArgs e)
        {
            kmeans.CreateClusterBitmap();
            KMeansPicture.Image = kmeans.ClusterBitmap;
            KMeansPicture.Refresh();
        }

        private void KMeansPicture_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                Point point = ((MouseEventArgs)e).Location;
                kmeans.AddCenter(point);
                DrawPoint(KMeansPicture, point.X, point.Y, Color.OrangeRed);
            }
        }
        
        private void KMeansShowOriginal_Click(object sender, EventArgs e)
        {
            KMeansPicture.Image = kmeans.bitmap;
            KMeansPicture.Refresh();
        }

        private void KMeansShowPoints_Click(object sender, EventArgs e)
        {
            KMeansPicture.Refresh();
            foreach (var center in kmeans.Centers)
                DrawPoint(KMeansPicture, center.Key.X, center.Key.Y, kmeans.IsFindedNewCenters ? Color.Lime : Color.OrangeRed);
        }

        private void KMeansClearPoints_Click(object sender, EventArgs e)
        {
            kmeans.Centers.Clear();
            kmeans.IsFindedNewCenters = false;
            KMeansPicture.Refresh();
        }

        private void KMeansReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                KMeansPicture.Image = new Bitmap(openFileDialog1.OpenFile());
                kmeans = new KMeans((Bitmap)KMeansPicture.Image);
            }
        }
    }
}
