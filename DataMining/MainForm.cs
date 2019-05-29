using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataMining
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PCAOpenImage_Click(object sender, EventArgs e)
        {
            if (PCAPicture.Image == null && openFileDialog1.ShowDialog() == DialogResult.OK)
                PCAPicture.Image = new Bitmap(openFileDialog1.OpenFile());
            else
            {
                

                PCA pca = PCA.getPCA();
                pca.image = PCAPicture.Image as Bitmap;
                //imData = Utils.ImageToColorArray(PCAPicture.Image as Bitmap);
                //        photo = ImageTk.PhotoImage(image)
                //        (iWidth, iHeight) = image.size
                //        canvas.configure(width = iWidth, height = iHeight)
                //        canvas.create_image(0, 0, image = photo, anchor = tk.NW)

                //        // FIRST COMPONENT
                //                r, g, b = [], [], []
                //        //get r, g and b arrays
                //        for pixel in imData:
                //            r.append(pixel[0])
                //            g.append(pixel[1])
                //            b.append(pixel[2])

                //// initial vector
                //        e = [1 / math.sqrt(3) for i in range(3)]

                //        //iterations
                //        for i in range(10) :

                //            // singleComponentValues
                //        Y = [r[i]* e[0]+g[i]*e[1]+b[i]*e[2] for i in range(len(r))]

                //            //mistake vector
                //            beta = [0, 0, 0]
                //            for i in range(len(Y)) :
                //                beta[0] += r[i]*Y[i]
                //                beta[1] += g[i]*Y[i]
                //                beta[2] += b[i]*Y[i]

                //            salpha = math.sqrt(beta[0] * *2 + beta[1] * *2 + beta[2] * *2)

                //            e[0] = beta[0]/salpha
                //            e[1] = beta[1] / salpha
                //            e[2] = beta[2]/salpha

                //        singleComponentValues = Y
                //        singleComponentVector = e

                //        // normalization
                //        sr, sg, sb = [], [], []

                //        for i in range(len(r)):
                //            sr.append(r[i] - e[0]*Y[i])
                //            sg.append(g[i] - e[1]*Y[i])
                //            sb.append(b[i] - e[2]*Y[i])

                //        //SECOND COMPONENT

                //        //initial vector
                //        e = [1/math.sqrt(3) for i in range(3)]

                //        //iterations
                //        for i in range(10) :

                //            // doubleComponentValues
                //        Y = [sr[i]* e[0]+sg[i]*e[1]+sb[i]*e[2] for i in range(len(sr))]

                //            //mistake vector
                //            beta = [0, 0, 0]
                //            for i in range(len(Y)) :
                //                beta[0] += sr[i]*Y[i]
                //                beta[1] += sg[i]*Y[i]
                //                beta[2] += sb[i]*Y[i]

                //            salpha = math.sqrt(beta[0] * *2 + beta[1] * *2 + beta[2] * *2)

                //            e[0] = beta[0]/salpha
                //            e[1] = beta[1] / salpha
                //            e[2] = beta[2]/salpha

                //        doubleComponentValues = Y
                //        doubleComponentVector = e

                //        // normalization
                //        tr, tg, tb = [], [], []

                //        for i in range(len(r)):
                //            tr.append(sr[i] - e[0]*Y[i])
                //            tg.append(sg[i] - e[1]*Y[i])
                //            tb.append(sb[i] - e[2]*Y[i])

                //        //THIRD COMPONENT

                //        //initial vector
                //        e = [1/math.sqrt(3) for i in range(3)]

                //        //iterations
                //        for i in range(10) :

                //            // tripleComponentValues
                //        Y = [tr[i]* e[0]+tg[i]*e[1]+tb[i]*e[2] for i in range(len(tr))]

                //            //mistake vector
                //            beta = [0, 0, 0]
                //            for i in range(len(Y)) :
                //                beta[0] += tr[i]*Y[i]
                //                beta[1] += tg[i]*Y[i]
                //                beta[2] += tb[i]*Y[i]

                //            salpha = math.sqrt(beta[0] * *2 + beta[1] * *2 + beta[2] * *2)

                //            e[0] = beta[0]/salpha
                //            e[1] = beta[1] / salpha
                //            e[2] = beta[2]/salpha

                //        tripleComponentValues = Y
                //        tripleComponentVector = e



                //                var pixels = Utils.ImageToColorArray(PCAPicture.Image as Bitmap);
            }
        }

        private void PCAComponent1_Click(object sender, EventArgs e)
        {

        }

        private void PCAComponent12_Click(object sender, EventArgs e)
        {

        }

        private void PCAComponent13_Click(object sender, EventArgs e)
        {

        }

        private void PCAComponent23_Click(object sender, EventArgs e)
        {

        }

        private void PCAComponent3_Click(object sender, EventArgs e)
        {

        }

        private void PCAReset_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var image = openFileDialog1.OpenFile();
                PCAPicture.Image = new Bitmap(image);
            }
        }
    }
}
