using System;
using System.Drawing;

namespace UserInterface
{
    public static class Helper
    {
        public static Image ResizeImage(string file,
                                        int width,
                                        int height,
                                        bool onlyResizeIfWider)
        {
            using (Image image = Image.FromFile(file))
            {
                // Prevent using images internal thumbnail
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);

                if (onlyResizeIfWider == true)
                {
                    if (image.Width <= width)
                    {
                        width = image.Width;
                    }
                }

                int newHeight = image.Height * width / image.Width;
                if (newHeight > height)
                {
                    // Resize with height instead
                    width = image.Width * height / image.Height;
                    newHeight = height;
                }

                Image NewImage = image.GetThumbnailImage(width, newHeight, null, IntPtr.Zero);

                return NewImage;
            }
        }
    }
}
