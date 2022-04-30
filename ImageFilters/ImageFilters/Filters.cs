using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMSProject
{
    public class Filters
    {
        private static double[,] cieToRgbMatrix = new double[3, 3] { { 3.2410, -1.5374, -0.4986 }, { -0.9692, 1.8760, 0.0416 }, { 0.0556, -0.2040, 1.0570 } };
        private static double[,] rgbToCieMatrix = new double[3, 3] { { 0.49 / 0.17697, 0.31 / 0.17697, 0.20 / 0.17697 }, { 0.17697 / 0.17697, 0.81240 / 0.17697, 0.01063 / 0.17697 }, { 0.0 / 0.17697, 0.01 / 0.17697, 0.99 / 0.17697 } };
        //private static double[,] rgbToCieMatrixNODIVISION = new double[3, 3] { { 0.49, 0.31, 0.20 }, { 0.17697, 0.81240, 0.01063 }, { 0.0, 0.01, 0.99 } };

        private static double[,] temp = new double[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        public static double[,] Mat { get => cieToRgbMatrix; }

        public static Bitmap[] GetChannelsRGB(Bitmap b)
        {
            Bitmap[] channels = new Bitmap[3];
            channels[0] = (Bitmap)b.Clone();
            channels[1] = (Bitmap)b.Clone();
            channels[2] = (Bitmap)b.Clone();

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var pixel = b.GetPixel(x, y);
                    channels[0].SetPixel(x, y, Color.FromArgb(pixel.R, 0, 0));
                    channels[1].SetPixel(x, y, Color.FromArgb(0, pixel.G, 0));
                    channels[2].SetPixel(x, y, Color.FromArgb(0, 0, pixel.B));
                }
            }

            return channels;
        }

        public static Bitmap[] GetChannelsCIE(Bitmap b)
        {
            Bitmap[] channels = new Bitmap[3]; // 0 - x channel, 1 - y channel, 2 - z channel

            double[,] rgbMat = new double[3, 1];
            double[,] xyzMat;

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    // set [R, G, B] matrix for conversion
                    rgbMat[0, 0] = b.GetPixel(x, y).R;
                    rgbMat[1, 0] = b.GetPixel(x, y).G;
                    rgbMat[2, 0] = b.GetPixel(x, y).B;

                    // rgb -> xyz
                    xyzMat = Helpers.MultiplyMatrices(rgbToCieMatrix, rgbMat);

                    // isolate xyz channels
                    double[,] xIsoMat = new double[3, 1] { { xyzMat[0, 0] }, { 0 }, { 0 } };
                    double[,] yIsoMat = new double[3, 1] { { 0 }, { xyzMat[1, 0] }, { 0 } };
                    double[,] zIsoMat = new double[3, 1] { { 0 }, { 0 }, { xyzMat[2, 0] } };


                    // each xyz -> rgb
                    double[,] rgbOut;

                    rgbOut = Helpers.MultiplyMatrices(cieToRgbMatrix, xIsoMat);
                    channels[0].SetPixel(x, y, Color.FromArgb((int)rgbOut[0, 0], (int)rgbOut[1, 0], (int)rgbOut[2, 0]));

                    rgbOut = Helpers.MultiplyMatrices(cieToRgbMatrix, yIsoMat);
                    channels[1].SetPixel(x, y, Color.FromArgb((int)rgbOut[0, 0], (int)rgbOut[1, 0], (int)rgbOut[2, 0]));

                    rgbOut = Helpers.MultiplyMatrices(cieToRgbMatrix, zIsoMat);
                    channels[2].SetPixel(x, y, Color.FromArgb((int)rgbOut[0, 0], (int)rgbOut[1, 0], (int)rgbOut[2, 0]));
                }
            }

            return channels;
        }
        public static Bitmap[] GetChannelsCIE2(Bitmap b)
        {
            Bitmap[] channels = new Bitmap[3];

            double[,] rgbMat = new double[3, 1];
            double[,] xyzMat;
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    // set [R, G, B] matrix for conversion
                    rgbMat[0, 0] = b.GetPixel(x, y).R;
                    rgbMat[1, 0] = b.GetPixel(x, y).G;
                    rgbMat[2, 0] = b.GetPixel(x, y).B;

                    xyzMat = Helpers.RgbToCieXyz(rgbMat, rgbToCieMatrix);

                    // isolate xyz channels
                    double[,] xIsoMat = new double[3, 1] { { xyzMat[0, 0] }, { 0 }, { 0 } };
                    double[,] yIsoMat = new double[3, 1] { { 0 }, { xyzMat[1, 0] }, { 0 } };
                    double[,] zIsoMat = new double[3, 1] { { 0 }, { 0 }, { xyzMat[2, 0] } };


                    // each xyz -> rgb
                    double[,] rgbOut;

                    rgbOut = Helpers.CieXyzToRgb(xIsoMat, cieToRgbMatrix);
                    channels[0].SetPixel(x, y, Color.FromArgb((int)rgbOut[0, 0], (int)rgbOut[1, 0], (int)rgbOut[2, 0]));

                    rgbOut = Helpers.MultiplyMatrices(cieToRgbMatrix, yIsoMat);
                    channels[1].SetPixel(x, y, Color.FromArgb((int)rgbOut[0, 0], (int)rgbOut[1, 0], (int)rgbOut[2, 0]));

                    rgbOut = Helpers.MultiplyMatrices(cieToRgbMatrix, zIsoMat);
                    channels[2].SetPixel(x, y, Color.FromArgb((int)rgbOut[0, 0], (int)rgbOut[1, 0], (int)rgbOut[2, 0]));
                }
            }

            return channels;
        }

        public static void ApplyColorFilter(Bitmap bitmap, int rValue, int gValue, int bValue)
        {
            if (bitmap != null)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color color = bitmap.GetPixel(i, j);

                        int r = color.R + rValue;
                        r = Math.Max(r, 0);
                        r = Math.Min(r, 255);

                        int g = color.G + gValue;
                        g = Math.Max(g, 0);
                        g = Math.Min(g, 255);

                        int b = color.B + bValue;
                        b = Math.Max(b, 0);
                        b = Math.Min(b, 255);

                        bitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                }
            }
        }

        public static void ApplyInvertFilter(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        Color c = bitmap.GetPixel(i, j);
                        bitmap.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                    }
                }
            }
        }

        public static void ApplyMeanRemovalFilter(Bitmap b)
        {
            var bmpMat = Helpers.GetMatrixOfBitmap(b);
            var expBmpMat = Helpers.ExpandMatrix(bmpMat, 127);
            int[][,] subMat;
            int[][,] convMat = new int[3][,] { new int[3, 3], new int[3, 3], new int[3, 3] };
            //Bitmap tmpBmp = (Bitmap)b.Clone();


            for (int x = 0; x < bmpMat[0].GetLength(0); x++)
            {
                for (int y = 0; y < bmpMat[1].GetLength(1); y++)
                {
                    subMat = Helpers.GetSubMatrix(expBmpMat, x, y);
                    int[] midValues = new int[3] { subMat[0][1, 1], subMat[1][1, 1], subMat[2][1, 1] };

                    Helpers.SetConvolutionMatrix(convMat, midValues);
                    // reduce each channel of expMat and convMat to 1 value and set bmp to it
                    int subRValue = 0, subGValue = 0, subBValue = 0;

                    for (int i = 0; i < subMat[0].GetLength(0); i++)
                    {
                        for (int j = 0; j < subMat[0].GetLength(1); j++)
                        {
                            subRValue += subMat[0][i, j] * convMat[0][i, j];
                            subGValue += subMat[1][i, j] * convMat[1][i, j];
                            subBValue += subMat[2][i, j] * convMat[2][i, j];
                        }
                    }
                    int offset = 0;
                    int[] factors = new int[3] { midValues[0] - 8, midValues[1] - 8, midValues[2] - 8 };

                    // damage control
                    for (int i = 0; i < factors.Length; i++)
                    {
                        if (factors[i] == 0)
                            factors[i] = 1;
                    }


                    int[] finalValues = new int[3] { (subRValue / factors[0]) + offset, (subGValue / factors[1]) + offset, (subBValue / factors[2]) + offset };

                    // damage control
                    for (int i = 0; i < finalValues.Length; i++)
                    {
                        if (finalValues[i] > 255)
                        {
                            finalValues[i] = 255;
                        }
                        else if (finalValues[i] < 0)
                        {
                            finalValues[i] = 0;
                        }
                    }

                    b.SetPixel(x, y, Color.FromArgb(finalValues[0], finalValues[1], finalValues[2]));
                }
            }
            //b = tmpBmp;
        }

        public static void ApplyEdgeDetectHomogenityFilter(Bitmap b, int rThreshold, int gThreshold, int bThreshold)
        {
            var bmpMat = Helpers.GetMatrixOfBitmap(b);
            var expBmpMat = Helpers.ExpandMatrix(bmpMat, 127);
            int[][,] subMat;
            //var tmpBmp = (Bitmap)b.Clone();

            for (int x = 0; x < bmpMat[0].GetLength(0); x++)
            {
                for (int y = 0; y < bmpMat[0].GetLength(1); y++)
                {
                    subMat = Helpers.GetSubMatrix(expBmpMat, x, y);
                    int[] midValues = new int[3] { subMat[0][1, 1], subMat[1][1, 1], subMat[2][1, 1] };// Values of S for R, G and B matrices

                    int subMatWidth = subMat[0].GetLength(0);
                    int subMatHeight = subMat[0].GetLength(1);
                    int[][,] tempMat = new int[subMat.GetLength(0)][,]; // filled with |p[x,y] - S|
                    for (int i = 0; i < tempMat.GetLength(0); i++)
                    {
                        tempMat[i] = new int[subMatWidth, subMatHeight];
                    }

                    for (int i = 0; i < subMatWidth; i++)
                    {
                        for (int j = 0; j < subMatHeight; j++)
                        {
                            tempMat[0][i, j] = Math.Abs(subMat[0][i, j] - midValues[0]);
                            tempMat[1][i, j] = Math.Abs(subMat[1][i, j] - midValues[1]);
                            tempMat[2][i, j] = Math.Abs(subMat[2][i, j] - midValues[2]);
                        }
                    }

                    int tmpMaxR = Helpers.GetMaxOfMatrix(tempMat[0]);
                    int tmpMaxG = Helpers.GetMaxOfMatrix(tempMat[1]);
                    int tmpMaxB = Helpers.GetMaxOfMatrix(tempMat[2]);
                    int maxR, maxG, maxB;
                    maxR = tmpMaxR < rThreshold ? 0 : tmpMaxR;
                    maxG = tmpMaxG < gThreshold ? 0 : tmpMaxG;
                    maxB = tmpMaxB < bThreshold ? 0 : tmpMaxB;

                    b.SetPixel(x, y, Color.FromArgb(maxR, maxG, maxB));
                }
            }
            //b = tmpBmp;
        }

        public static void ApplyTimeWarpFilter(Bitmap b, int factor)
        {
            Point[,] offsetMat = new Point[b.Width, b.Height];
            Point midPoint = new Point(b.Width / 2, b.Height / 2);

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    // set offsetMatrix element
                    int trueX = x - midPoint.X;
                    int trueY = y - midPoint.Y;

                    double theta = Math.Atan2(trueY, trueX);
                    double radius = Math.Sqrt(trueX * trueX + trueY * trueY);
                    double newRadius = Math.Sqrt(radius) * factor;

                    double newX = midPoint.X + (newRadius * Math.Cos(theta));
                    offsetMat[x, y].X = (newX > 0 && newX < b.Width) ? (int)newX : 0;

                    double newY = midPoint.Y + (newRadius * Math.Sin(theta));
                    offsetMat[x, y].Y = (newY > 0 && newY < b.Height) ? (int)newY : 0;

                    //int finalX = offsetMat[x, y].X;
                    //int finalY = offsetMat[x, y].Y;
                    //// implement offset in bitmap
                    //if ((finalX >= 0 && finalX < b.Width) && (finalY >= 0 && finalY < b.Height))
                    {
                        Color newColor = b.GetPixel(offsetMat[x, y].X, offsetMat[x, y].Y);
                        b.SetPixel(x, y, newColor);
                    }
                }
            }

        }

        public static void ApplyGrayscaleAvgFilter(Bitmap b)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var c = b.GetPixel(x, y);
                    int val = (c.R + c.G + c.B) / 3;
                    Color newC = Color.FromArgb(val, val, val);
                    b.SetPixel(x, y, newC);
                }
            }
        }

        public static void ApplyGrayScaleMaxFilter(Bitmap b)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var c = b.GetPixel(x, y);
                    int val = Math.Max(c.R, c.G);
                    val = Math.Max(val, c.B);
                    Color newC = Color.FromArgb(val, val, val);
                    b.SetPixel(x, y, newC);
                }
            }
        }

        public static void ApplyGrayscaleCustomFilter(Bitmap b)
        {
            // find where to get numberOfShades
            int numberOfShades = 200;
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var pixel = b.GetPixel(x, y);

                    int conversionFactor = 255 / (numberOfShades - 1);
                    int avgVal = (pixel.R + pixel.G + pixel.B) / 3;
                    int val = (int)(avgVal / conversionFactor + 0.5) * conversionFactor;

                    Color newC = Color.FromArgb(val, val, val);
                    b.SetPixel(x, y, newC);
                }
            }
        }

        public static void ApplySimpleColorizeFilter(Bitmap b)
        {
            // colormap from provided colormap.pdf
            int[] thresholds = new int[8] { 0, 70, 80, 120, 130, 160, 190, 255 };
            //(int r, int g, int b)[] colors = new[] { (0, 0, 0), (101, 67, 33), (255, 105, 180), (255, 255, 255) };
            Color[] colors = new Color[7];
            colors[0] = Color.FromArgb(0, 0, 0);
            colors[1] = Color.FromArgb(100, 40, 70);
            colors[2] = Color.FromArgb(90, 110, 70);
            colors[3] = Color.FromArgb(95, 140, 170);
            colors[3] = Color.FromArgb(140, 175, 10);
            colors[3] = Color.FromArgb(120, 190, 255);
            colors[3] = Color.FromArgb(190, 190, 190);
            colors[3] = Color.FromArgb(240, 240, 240);


            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var pixel = b.GetPixel(x, y);

                    var grayVal = pixel.R;

                    Color newPixel = Color.AliceBlue;

                    for (int i = 0; i < colors.Length; i++)
                    {
                        if (thresholds[i] <= grayVal && grayVal < thresholds[i + 1])
                        {
                            newPixel = colors[i];
                            break;
                        }
                    }

                    b.SetPixel(x, y, newPixel);
                }
            }
        }

        public static void ApplyCrossDomainColorizeFilter(Bitmap b, double newHue, double newSaturation)
        {
            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    double hue, saturation, value;
                    var pixel = b.GetPixel(x, y);
                    Helpers.ColorToHSV(pixel, out hue, out saturation, out value);

                    hue = newHue;
                    saturation = newSaturation;

                    var newPixel = Helpers.ColorFromHSV(hue, saturation, value);
                    b.SetPixel(x, y, newPixel);
                }
            }
        }
    }
}
