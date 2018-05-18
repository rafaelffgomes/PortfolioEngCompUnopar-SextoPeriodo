using System.Drawing;
using System.Drawing.Drawing2D;

namespace PortfolioEngCompUnopar
{
    class Rotacao
    {
        public Bitmap Girar(Bitmap bitmap, float grau)
        {
            Bitmap bitmapgirada = new Bitmap(bitmap.Height, bitmap.Width);
            Graphics grafico = Graphics.FromImage(bitmapgirada);
            grafico.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grafico.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);
            grafico.RotateTransform(grau);
            grafico.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);
            grafico.DrawImage(bitmap, 0, 0);
            return bitmapgirada;
        }
    }
}