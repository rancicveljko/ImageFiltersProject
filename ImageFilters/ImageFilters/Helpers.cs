using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSProject
{
    public class Helpers
    {
        public static double[] GetColumn(double[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public static double[] GetRow(double[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }
        public static double[,] MultiplyMatrices(double[,] a, double[,] b)
        {
            int rowNumA = a.GetLength(0);
            int colNumA = a.GetLength(1);
            int rowNumB = b.GetLength(0);
            int colNumB = b.GetLength(1);
            double[,] rez = new double[rowNumA, colNumB];


            for (int i = 0; i < rowNumA; i++)
            {
                for (int j = 0; j < colNumB; j++)
                {
                    double tmp = 0;
                    for (int k = 0; k < rowNumB; k++)
                    {
                        tmp += a[i, k] * b[k, j];
                    }
                    rez[i, j] = tmp;
                }
            }
            return rez;
        }

        public static int[][,] GetSubMatrix(int[][,] mat, int subMatStartX, int subMatStartY)
        {
            int[][,] subMat = new int[3][,] { new int[3, 3], new int[3, 3], new int[3, 3] };
            //try
            {
                int xLimit = mat[0].GetUpperBound(0) - 1;
                int yLimit = mat[0].GetUpperBound(1) - 1;
                if ((subMatStartX < xLimit) && (subMatStartY < yLimit))
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            subMat[0][i, j] = mat[0][subMatStartX + i, subMatStartY + j];
                            subMat[1][i, j] = mat[1][subMatStartX + i, subMatStartY + j];
                            subMat[2][i, j] = mat[2][subMatStartX + i, subMatStartY + j];
                        }
                    }
                }
                else
                    throw new Exception($"XStart:{subMatStartX}, XLimit:{xLimit}; YStart:{subMatStartY}, YLimit:{yLimit}");
            }
            //catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            return subMat;
        }

        public static int[][,] GetMatrixOfBitmap(Bitmap b)
        {
            // first index of bmpMat defines R(0), G(1), B(2) matrices
            int[][,] bmpMat = new int[3][,] { new int[b.Width, b.Height], new int[b.Width, b.Height], new int[b.Width, b.Height] };

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var tmp = b.GetPixel(x, y);
                    bmpMat[0][x, y] = tmp.R;
                    bmpMat[1][x, y] = tmp.G;
                    bmpMat[2][x, y] = tmp.B;
                }
            }

            return bmpMat;
        }

        public static int[][,] ExpandMatrix(int[][,] mat, int padFactor)
        {
            int matRows = mat[0].GetLength(0);
            int matCols = mat[0].GetLength(1);
            int[][,] m = new int[3][,] { new int[matRows + 2, matCols + 2], new int[matRows + 2, matCols + 2], new int[matRows + 2, matCols + 2] };
            //try
            {
                // fill inside matrix
                for (int i = 0; i < matRows; i++)
                {
                    for (int j = 0; j < matCols; j++)
                    {
                        m[0][i + 1, j + 1] = mat[0][i, j];
                        m[2][i + 1, j + 1] = mat[1][i, j];
                        m[2][i + 1, j + 1] = mat[2][i, j];
                    }
                }

                // fill edges
                int mCols = m[0].GetLength(1);
                int lastRow = m[0].GetUpperBound(0);
                // first and last row
                for (int i = 0; i < mCols; i++)
                {
                    //m[0, i] = Color.FromArgb(padFactor, padFactor, padFactor);
                    m[0][0, i] = padFactor;
                    m[1][0, i] = padFactor;
                    m[2][0, i] = padFactor;
                    //m[lastRow, i] = Color.FromArgb(padFactor, padFactor, padFactor);
                    m[0][lastRow, i] = padFactor;
                    m[1][lastRow, i] = padFactor;
                    m[2][lastRow, i] = padFactor;
                }

                // first and last element of every row except first and last
                int lastCol = m[0].GetUpperBound(1);
                for (int i = 1; i < matRows + 1; i++)
                {
                    //m[i, 0] = Color.FromArgb(padFactor, padFactor, padFactor);
                    m[0][i, 0] = padFactor;
                    m[1][i, 0] = padFactor;
                    m[2][i, 0] = padFactor;
                    //m[i, lastCol] = Color.FromArgb(padFactor, padFactor, padFactor); 
                    m[0][i, lastCol] = padFactor;
                    m[1][i, lastCol] = padFactor;
                    m[2][i, lastCol] = padFactor;
                }

            }
            //catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return m;
        }

        // 3x3
        public static void SetConvolutionMatrix(int[][,] convMat, int[] midValues) // midValue represents n from presentation
        {
            int convMatWidth = convMat[0].GetLength(0);
            int convMatHeight = convMat[0].GetLength(1);
            for (int i = 0; i < convMatWidth; i++)
            {
                for (int j = 0; j < convMatHeight; j++)
                {
                    if (i == convMatWidth / 2 && j == convMatHeight / 2)
                    {
                        convMat[0][i, j] = midValues[0];
                        convMat[1][i, j] = midValues[1];
                        convMat[2][i, j] = midValues[2];
                    }
                    else
                    {
                        convMat[0][i, j] = -1;
                        convMat[1][i, j] = -1;
                        convMat[2][i, j] = -1;
                    }
                }
            }
        }

        public static int GetMaxOfMatrix(int[,] mat)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] > max)
                        max = mat[i, j];
                }
            }
            return max;
        }

        public static Point[,] MakeTimewarpOffsetMatrix(Bitmap b, int factor)
        {
            Point[,] offsetMat = new Point[b.Width, b.Height];
            Point midPoint = new Point(b.Width / 2, b.Height / 2);

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    int trueX = x - midPoint.X;
                    int trueY = y - midPoint.Y;

                    double theta = Math.Atan2(trueX, trueY);
                    double radius = Math.Sqrt(trueX * trueX + trueY * trueY);
                    double newRadius = Math.Sqrt(radius * factor);

                    int newX = midPoint.X + (int)(newRadius * Math.Cos(theta));
                    offsetMat[x, y].X = (newX > 0 && newX < b.Width) ? newX : 0;

                    int newY = midPoint.Y + (int)(newRadius * Math.Cos(theta));
                    offsetMat[x, y].Y = (newY > 0 && newY < b.Height) ? newY : 0;
                }
            }

            return offsetMat;
        }

        public static double[,] RgbToCieXyz(double[,] rgb, double[,] rgbToCieMatrix)
        {
            //double[,] rgbToCieMatrixNEW = new double[3, 3] { { 0.4124564, 0.3575761, 0.1804375 }, { 0.2126729, 0.7151522, 0.0721750 }, { 0.0193339, 0.0191920, 0.9503041 } };
            int rgbRows = rgb.GetLength(0);
            int rgbCols = rgb.GetLength(1);

            double[,] xyz;

            // linearize rgb values
            double[,] rgbLinear = new double[rgbRows, rgbCols];
            for (int i = 0; i < rgbRows; i++)
            {
                for (int j = 0; j < rgbCols; j++)
                {
                    rgbLinear[i, j] = rgb[i, j] / 255;

                    //var tmp = rgbLinear[i, j];
                    //if (tmp <= 0.04045)
                    //{
                    //    tmp /= 12.92;
                    //}
                    //else
                    //{
                    //    tmp += 0.055;
                    //    tmp /= 1.055;
                    //    tmp = Math.Pow(tmp, 2.4);
                    //}
                    //rgbLinear[i, j] = tmp;
                }
            }

            xyz = Helpers.MultiplyMatrices(rgbToCieMatrix, rgbLinear);

            return xyz;
        }

        public static double[,] CieXyzToRgb(double[,] xyz, double[,] cieToRgbMatrix)
        {
            int xyzRows = xyz.GetLength(0);
            int xyzCols = xyz.GetLength(1);

            double[,] rgb = Helpers.MultiplyMatrices(cieToRgbMatrix, xyz);


            //for (int i = 0; i < xyzRows; i++)
            //{
            //    for (int j = 0; j < xyzCols; j++)
            //    {

            //    }
            //}
            return rgb;
        }

        public static HistogramData[] CollectHistogramDataFromBitmap(Bitmap b)
        {
            HistogramData rChannelData, gChannelData, bChannelData;
            rChannelData = new HistogramData();
            gChannelData = new HistogramData();
            bChannelData = new HistogramData();

            for (int x = 0; x < b.Width; x++)
            {
                for (int y = 0; y < b.Height; y++)
                {
                    var pixel = b.GetPixel(x, y);
                    rChannelData.Frequencies[pixel.R]++;
                    gChannelData.Frequencies[pixel.G]++;
                    bChannelData.Frequencies[pixel.B]++;
                }
            }

            return new HistogramData[] { rChannelData, gChannelData, bChannelData };
        }

        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        public static void CropHistogramData(HistogramData[] channelsData, int t, int c)
        {
            var tmpRFreqs = channelsData[0].Frequencies;
            var tmpRed = Enumerable.Range(0, tmpRFreqs.Count).Where(ind => ind > t).Select(ind => (tmpRFreqs[ind] - c) > 0 ? (tmpRFreqs[ind] - c) : 0).ToList();
            channelsData[0].Frequencies = tmpRed;

            var tmpGFreqs = channelsData[1].Frequencies;
            var tmpGreen = Enumerable.Range(0, tmpGFreqs.Count).Where(ind => ind > t).Select(ind => (tmpGFreqs[ind] - c) > 0 ? (tmpGFreqs[ind] - c) : 0).ToList();
            channelsData[1].Frequencies = tmpGreen;

            var tmpBFreqs = channelsData[2].Frequencies;
            var tmpBlue = Enumerable.Range(0, tmpBFreqs.Count).Where(ind => ind > t).Select(ind => (tmpBFreqs[ind] - c) > 0 ? (tmpBFreqs[ind] - c) : 0).ToList();
            channelsData[2].Frequencies = tmpBlue;
        }
    }
}
