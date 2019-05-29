using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataMining {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        PCA pca;

        private void PCAOpenImage_Click(object sender, EventArgs @event) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
            else {
                return;
            }
            pca = new PCA((Bitmap)PCAPicture.Image);
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
            if(string.IsNullOrEmpty(openFileDialog1.FileName)) {
                return;
            }
            PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
        }
    }
}
