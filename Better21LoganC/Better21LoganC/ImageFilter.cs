using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Better21LoganC
{
    public static class ImageOperations
    {

        public static Image GreyedOut(this Image inputImage)
        {
            // Scaling image so that it is an appropriate size
            inputImage = new Bitmap(inputImage, Card.cardSize);

            // Code from a youtube video (link in sources)
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);
            Graphics imageGraphics = Graphics.FromImage(outputImage);
            imageGraphics.DrawImage(inputImage, 0, 0);

            // Applying the filter
            imageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(200, Color.Gray)), 0, 0, inputImage.Width, inputImage.Height);

            return outputImage;
        }

        public static Image RotateImage(this Image inputImage)
        {
            Bitmap outputImage = new Bitmap(inputImage);

            using (Graphics gfx = Graphics.FromImage(outputImage))
            {
                gfx.Clear(Color.White);
                gfx.DrawImage(inputImage, 0, 0, inputImage.Width, inputImage.Height);
            }

            outputImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

            return outputImage;
        }
    }
}
