using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PortfolioEngCompUnopar
{
    class Escala
    {
        public Bitmap Escalar(Bitmap bitmap, double escala)
        {
            double calculo = escala / 100.0;
            Bitmap bmp = new Bitmap(bitmap, Convert.ToInt32(bitmap.Width * calculo), Convert.ToInt32(bitmap.Height * calculo));
            Graphics graficos = Graphics.FromImage(bmp);
            graficos.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bmp;
        }
    }
}