using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ImageResizer
{
    public static class Resizer
    {
        public static string Resize(Image img, int maxHeight, int maxWidth)
        {
            if (img.Width > maxWidth || img.Height > maxHeight)
            {
                double widthRatio = (double)img.Width / maxWidth;
                double heightRatio = (double)img.Height / maxHeight;
                double ratio = Math.Max(widthRatio, heightRatio);

                int newWidth = (int)(img.Width / ratio);
                int newHeight = (int)(img.Height / ratio);
                return newHeight.ToString() + "," + newWidth.ToString();
            }
            else
            {
                return img.Height.ToString() + "," + img.Width.ToString();
            }
        }
    }
}
