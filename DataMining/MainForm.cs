using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DataMining {
    public partial class MainForm : Form {
        class MColor {
            public MColor(Color color) : this(color.R, color.G, color.B) { }

            public MColor(double r, double g, double b) {
                R = r;
                G = g;
                B = b;
            }

            public double R { get; set; }
            public double G { get; set; }
            public double B { get; set; }
        }

        public MainForm() {
            InitializeComponent();
        }

        double[] singleComponentValues, singleComponentVector,
            doubleComponentValues, doubleComponentVector,
            tripleComponentValues, tripleComponentVector;

        private void PCAOpenImage_Click(object sender, EventArgs @event) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
            else {
                return;
            }

            var bitmap = PCAPicture.Image as Bitmap;
            var pixels = new Collection<MColor>();
            for(var x = 0; x < bitmap.Width; x++) {
                for(var y = 0; y < bitmap.Height; y++) {
                    pixels.Add(new MColor(bitmap.GetPixel(x, y)));
                }
            }
            var e = new double[3];
            for(var i1 = 0; i1 < 3; i1++) {
                e[i1] = 1 / Math.Sqrt(3);
            }
            var Y = new double[pixels.Count];
            for(var i = 0; i < 10; i++) {
                var beta = new double[3] { 0, 0, 0 };
                for(var i1 = 0; i1 < pixels.Count; i1++) {
                    Y[i1] = pixels[i1].R * e[0] + pixels[i1].G * e[1] + pixels[i1].B * e[2];
                    beta[0] += pixels[i1].R * Y[i1];
                    beta[1] += pixels[i1].G * Y[i1];
                    beta[2] += pixels[i1].B * Y[i1];
                }
                var salpha = Math.Sqrt(beta[0] * beta[0] + beta[1] * beta[1] + beta[2] * beta[2]);
                for(var i1 = 0; i1 < 3; i1++) {
                    e[i1] = beta[i1] / salpha;
                }
            }
            singleComponentValues = Y.ToArray();
            singleComponentVector = e.ToArray();

            var sPixels = new Collection<MColor>();
            for(var i = 0; i < pixels.Count; i++) {
                sPixels.Add(new MColor(pixels[i].R - e[0] * Y[i], pixels[i].G - e[1] * Y[i], pixels[i].B - e[2] * Y[i]));
            }
            for(var i1 = 0; i1 < 3; i1++) {
                e[i1] = 1 / Math.Sqrt(3);
            }
            Y = new double[sPixels.Count];
            for(var i = 0; i < 10; i++) {
                var beta = new double[3] { 0, 0, 0 };
                for(var i1 = 0; i1 < sPixels.Count; i1++) {
                    Y[i1] = sPixels[i1].R * e[0] + sPixels[i1].G * e[1] + sPixels[i1].B * e[2];
                    beta[0] += sPixels[i1].R * Y[i1];
                    beta[1] += sPixels[i1].G * Y[i1];
                    beta[2] += sPixels[i1].B * Y[i1];
                }
                var salpha = Math.Sqrt(beta[0] * beta[0] + beta[1] * beta[1] + beta[2] * beta[2]);
                for(var i1 = 0; i1 < 3; i1++) {
                    e[i1] = beta[i1] / salpha;
                }
            }
            doubleComponentValues = Y.ToArray();
            doubleComponentVector = e.ToArray();

            var tPixels = new Collection<MColor>();
            for(var i = 0; i < pixels.Count; i++) {
                tPixels.Add(new MColor(sPixels[i].R - e[0] * Y[i], sPixels[i].G - e[1] * Y[i], sPixels[i].B - e[2] * Y[i]));
            }
            for(var i1 = 0; i1 < 3; i1++) {
                e[i1] = 1 / Math.Sqrt(3);
            }
            Y = new double[tPixels.Count];
            for(var i = 0; i < 10; i++) {
                var beta = new double[3] { 0, 0, 0 };
                for(var i1 = 0; i1 < tPixels.Count; i1++) {
                    Y[i1] = tPixels[i1].R * e[0] + tPixels[i1].G * e[1] + tPixels[i1].B * e[2];
                    beta[0] += tPixels[i1].R * Y[i1];
                    beta[1] += tPixels[i1].G * Y[i1];
                    beta[2] += tPixels[i1].B * Y[i1];
                }
                var salpha = Math.Sqrt(beta[0] * beta[0] + beta[1] * beta[1] + beta[2] * beta[2]);
                for(var i1 = 0; i1 < 3; i1++) {
                    e[i1] = beta[i1] / salpha;
                }
            }
            tripleComponentValues = Y.ToArray();
            tripleComponentVector = e.ToArray();
        }

        private void PCAComponent1_Click(object sender, EventArgs e) {
            ChangeImage(useDoubleValue: false, useTripleValue: false);
        }

        private void PCAComponent12_Click(object sender, EventArgs e) {
            ChangeImage(useTripleValue: false);
        }

        private void PCAComponent13_Click(object sender, EventArgs e) {
            ChangeImage(useDoubleValue: false);
        }

        private void PCAComponent23_Click(object sender, EventArgs e) {
            ChangeImage(useSingleValue: false);
        }

        private void PCAComponent3_Click(object sender, EventArgs e) {
            ChangeImage();
        }

        void ChangeImage(bool useSingleValue = true, bool useDoubleValue = true, bool useTripleValue = true) {
            var bitmap = PCAPicture.Image as Bitmap;
            for(var x = 0; x < bitmap.Width; x++) {
                for(var y = 0; y < bitmap.Height; y++) {
                    var singleValue = useSingleValue ? singleComponentValues[x * PCAPicture.Image.Height + y] : 0;
                    var doubleValue = useDoubleValue ? doubleComponentValues[x * PCAPicture.Image.Height + y] : 0;
                    var tripleValue = useTripleValue ? tripleComponentValues[x * PCAPicture.Image.Height + y] : 0;
                    bitmap.SetPixel(x, y, Color.FromArgb(
                        red: CoerceColor(singleValue * singleComponentVector[0] + doubleValue * doubleComponentVector[0] + tripleValue * tripleComponentVector[0]),
                        green: CoerceColor(singleValue * singleComponentVector[1] + doubleValue * doubleComponentVector[1] + tripleValue * tripleComponentVector[1]),
                        blue: CoerceColor(singleValue * singleComponentVector[2] + doubleValue * doubleComponentVector[2] + tripleValue * tripleComponentVector[2])
                    ));
                }
            }
            PCAPicture.Refresh();
        }

        int CoerceColor(double color) {
            return new[] { new[] { (int)color, 0 }.Max(), 255 }.Min();
        }

        private void PCAReset_Click(object sender, EventArgs e) {
            if(string.IsNullOrEmpty(openFileDialog1.FileName)) {
                return;
            }
            PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
        }
    }
}
