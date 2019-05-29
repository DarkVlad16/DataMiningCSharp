
using System;
using System.Collections.Generic;
using System.Drawing;

namespace DataMining
{
    public static class Algorithms
    {

        #region PrincipalComponentMethod

        public static Color[,] PrincipalComponentMethod(Color[,] pixels, int iterations, 
            ref double[] alpha, ref double[] vector)
        {
            var height = pixels.GetLength(0);
            var width = pixels.GetLength(1);
            var newVector = new double[3];
            var newAlpha = new double[height * width];
            var beta = new double[3];
            var newPixels = new Color[height, width];

            for (var i = 0; i < 3; i++)
                newVector[i] = 1.0 / Math.Sqrt(3);

            for (var k = 0; k < iterations; k++)
            {
                for (var i = 0; i < 3; i++)
                    beta[i] = 0;

                for (var i = 0; i < height; i++)
                for (var j = 0; j < width; j++)
                {
                    var alphaRGB = CalculateAlphaByPixel(pixels[i, j], newVector);
                    newAlpha[j + i * width] = alphaRGB[0] + alphaRGB[1] + alphaRGB[2];

                    CalculateBetaByPixel(pixels[i, j], ref beta, newAlpha[j + i * width]);
                }

                var sAlpha = Math.Sqrt(beta[0] * beta[0] + beta[1] * beta[1] + beta[2] * beta[2]);

                for (var i = 0; i < 3; i++)
                    newVector[i] = beta[i] / sAlpha;
            }

            alpha = newAlpha;
            vector = newVector;

            for (var i = 0; i < height; i++)
                for (var j = 0; j < width; j++)
                {
                    var alphaRGB = CalculateAlphaByPixel(pixels[i, j], vector, alpha[j + i * width]);
                    newPixels[i, j] = Color.FromArgb((int) alphaRGB[0], (int) alphaRGB[1], (int) alphaRGB[2]);
                }

            return newPixels;
        }

        private static double[] CalculateAlphaByPixel(Color pixel, double[] newVector, double alphaRGB)
        {
            var newColor = new double[3];
            newColor[0] = Math.Abs(pixel.R - newVector[0] * alphaRGB);
            newColor[1] = Math.Abs(pixel.G - newVector[1] * alphaRGB);
            newColor[2] = Math.Abs(pixel.B - newVector[2] * alphaRGB);

            return newColor;
        }

        private static double[] CalculateAlphaByPixel(Color pixel, double[] newVector)
        {
            var newAlphaColor = new double[3];
            newAlphaColor[0] = newVector[0] * pixel.R;
            newAlphaColor[1] = newVector[1] * pixel.G;
            newAlphaColor[2] = newVector[2] * pixel.B;

            return newAlphaColor;
        }

        private static void CalculateBetaByPixel(Color pixel, ref double[] beta, double newAlpha)
        {
            beta[0] += newAlpha * pixel.R;
            beta[1] += newAlpha * pixel.G;
            beta[2] += newAlpha * pixel.B;
        }


        #endregion
    }
}