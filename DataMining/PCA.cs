using System;
using System.Collections.Generic;
using System.Drawing;

namespace DataMining
{
    class PCA
    {
        private static PCA instance;
        public static PCA getPCA()
        {
            if (instance == null)
                instance = new PCA();
            return instance;
        }

        private PCA()
        {
            image = null;
            photo = null;
            iWidth = 0;
            iHeight = 0;
            imData = new List<object>();
            singleComponentValues = new List<double>();
            singleComponentVector = new List<double>();
            singlePhoto = null;
            doubleComponentValues = new List<double>();
            doubleComponentVector = new List<double>();
            doublePhoto = null;
            doublePhoto13 = null;
            doublePhoto23 = null;
            tripleComponentValues = new List<double>();
            tripleComponentVector = new List<double>();
            triplePhoto = null;
        }
        
        public Bitmap image;
        public Bitmap photo;
        public double iWidth = 0;
        public double iHeight = 0;
        public List<object> imData;
        public List<double> singleComponentValues;
        public List<double> singleComponentVector;
        public Bitmap singlePhoto;
        public List<double> doubleComponentValues;
        public List<double> doubleComponentVector;
        public Bitmap doublePhoto;
        public Bitmap doublePhoto13;
        public Bitmap doublePhoto23;
        public List<double> tripleComponentValues;
        public List<double> tripleComponentVector;
        public Bitmap triplePhoto;
        
        private void singleComponent()
        {
            if (doublePhoto == null)
            {
                //List<(int r, int g, int b)> pixels = new List<(int r, int g, int b)>();

                foreach (var el in singleComponentValues)
                {
                    var r = el * singleComponentVector[0];
                    var g = el * singleComponentVector[1];
                    var b = el * singleComponentVector[2];
                    //pixels.Add((r: (int)r, g: (int)g, b: (int) b));
                }

                image = new Bitmap(image.Size.Width, image.Size.Height);
                //image.SetPixel(pixels);
                singlePhoto = image;
            }
        }

        private Bitmap doubleComponent(List<double> componentVector1, List<double> componentVector2, 
            List<double> componentValues1, List<double> componentValues2)
        {
            if (doublePhoto == null)
            {
                //List<(int r, int g, int b)> pixels = new List<(int r, int g, int b)>();
                for (int i = 0; i < componentValues1.Count; i++)
                {
                    var el1 = componentValues1[i];
                    var el2 = componentValues2[i];

                    var r = el2 * componentVector2[0] + el1 * componentVector1[0];
                    var g = el2 * componentVector2[1] + el1 * componentVector1[1];
                    var b = el2 * componentVector2[2] + el1 * componentVector1[2];
                    //pixels.Add((r: (int) r, g: (int) g, b: (int) b));
                }
                //image = Image.new (image.mode, image.size);
                //image.putdata(pixels);
                //return ImageTk.PhotoImage(image);
            }

            return null;
        }

        public void doubleComponent12()
        {
            doublePhoto = doubleComponent(singleComponentVector, doubleComponentVector, singleComponentValues, doubleComponentValues);
        }

        public void doubleComponent13()
        {
            doublePhoto = doubleComponent(singleComponentVector, tripleComponentVector, singleComponentValues, tripleComponentValues);
        }


        public void doubleComponent23()
        {
            doublePhoto = doubleComponent(doubleComponentVector, tripleComponentVector, doubleComponentValues, tripleComponentValues);
        }

        private void tripleComponent()
        {
            if (doublePhoto == null)
            {
                //List<(int r, int g, int b)> pixels = new List<(int r, int g, int b)>();

                for (int i = 0; i < singleComponentValues.Count; i++)
                {
                    var el1 = singleComponentValues[i];
                    var el2 = doubleComponentValues[i];
                    var el3 = tripleComponentValues[i];

                    var r = el2 * doubleComponentVector[0] + el1 * singleComponentVector[0] + el3 * tripleComponentVector[0];
                    var g = el2 * doubleComponentVector[1] + el1 * singleComponentVector[1] + el3 * tripleComponentVector[1];
                    var b = el2 * doubleComponentVector[2] + el1 * singleComponentVector[2] + el3 * tripleComponentVector[2];
                    //pixels.Add((r: (int)r, g: (int)g, b: (int)b));
                }
                //image = Image.new (image.mode, image.size);
                //image.putdata(pixels);
                //triplePhoto = ImageTk.PhotoImage(image);
            }
        }
    }
}
