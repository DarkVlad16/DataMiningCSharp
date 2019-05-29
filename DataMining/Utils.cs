using System.Drawing;
using System.IO;

namespace DataMining
{
    public static class Utils
    {
        public static byte[] ImageToByteArray(Bitmap image)
        {
            using (var mStream = new MemoryStream())
            {
                image.Save(mStream, image.RawFormat);
                return mStream.ToArray();
            }
        }

        public static int[,] ImageToIntArray(Bitmap image)
        {
            var pixelArray = new int[image.Width, image.Height];

            for (var i = 0; i < image.Width; i++)
                for (var j = 0; j < image.Height; j++)
                    pixelArray[i, j] = image.GetPixel(i, j).ToArgb();

            return pixelArray;
        }

        public static Color[,] ImageToColorArray(Bitmap image)
        {
            var pixelArray = new Color[image.Width, image.Height];

            for (var i = 0; i < image.Width; i++)
            for (var j = 0; j < image.Height; j++)
                pixelArray[i, j] = image.GetPixel(i, j);

            return pixelArray;
        }

        public static Bitmap ArrayToImage(byte[] array)
        {
            using (var mStream = new MemoryStream(array))
            {
                return Image.FromStream(mStream) as Bitmap;
            }
        }

        public static Bitmap ArrayToImage(int[,] array)
        {
            var image = new Bitmap(array.GetLength(0), array.GetLength(1));

            for (var i = 0; i < image.Width; i++)
                for (var j = 0; j < image.Height; j++)
                    image.SetPixel(i, j, Color.FromArgb(array[i, j]));

            return image;
        }

        public static Bitmap ArrayToImage(Color[,] array)
        {
            var image = new Bitmap(array.GetLength(0), array.GetLength(1));

            for (var i = 0; i < image.Width; i++)
            for (var j = 0; j < image.Height; j++)
                image.SetPixel(i, j, array[i, j]);

            return image;
        }

    }
}