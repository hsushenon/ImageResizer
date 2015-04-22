using System;
using System.IO; 
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
///Original post: http://www.codeproject.com/Articles/2941/Resizing-a-Photographic-image-with-GDI-for-NET
///By Joel Neubeck
///Modified by Hsu Shen On

namespace ImageResizerApp
{
    class ImageResize
    {
        
        public void Resize()
        {
            try
            {
                //set a working directory
                string WorkingDirectory = @"D:\projects\ImageResizerApp\ImageResizerApp\Images";

                //create a image object containing a verticel photograph
                Image imgPhotoVert = Image.FromFile(WorkingDirectory + @"\imageresize_vert.jpg");
                Image imgPhotoHoriz = Image.FromFile(WorkingDirectory + @"\imageresize_horiz.jpg");
                Image imgPhoto = null;

                imgPhoto = ScaleByPercent(imgPhotoVert, 50);
                imgPhoto.Save(WorkingDirectory + @"\resized\imageresize_1.jpg", ImageFormat.Jpeg);
                imgPhoto.Dispose();

            }
            catch (Exception ex)
            {
            }
        }

        internal string ResizeAllImagesInDirectory(string sourceDirectory, string targetDirectory, int percentToResize, int imageType)
        {
            string message = string.Empty;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDirectory);
                if (!dir.Exists)
                {
                    //dir does not exist
                    message = "Source directory does not exist";
                    return message;
                }

                dir = new DirectoryInfo(targetDirectory);
                if (!dir.Exists)
                {
                    dir.Create();
                }

                ImageFormat imageFormat = ImageFormat.Jpeg;

                switch (imageType)
                {
                    case 1: imageFormat = ImageFormat.Png;
                        break;
                    case 2: imageFormat = ImageFormat.Bmp;
                        break;
                    default: imageFormat = ImageFormat.Jpeg;
                        break;
                }

                string[] filePaths = Directory.GetFiles(sourceDirectory);

                if (filePaths != null && filePaths.Length > 0)
                {
                    foreach (string filePath in filePaths)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(filePath);
                        Image imgPhotoSource = null;
                        try
                        {
                             imgPhotoSource = Image.FromFile(filePath);
                        }
                        catch (OutOfMemoryException)
                        {
                            // Image.FromFile will throw this if file is invalid.
                            // Don't ask me why.
                            continue;
                        }

                        Image imgPhoto = null;

                        imgPhoto = ScaleByPercent(imgPhotoSource, percentToResize);

                        imgPhoto.Save(targetDirectory + "\\" + fileName + "." + imageFormat.ToString(), imageFormat);

                        imgPhoto.Dispose();
                    }
                }
                message = "Resizing successfull.";
            }
            catch (Exception)
            {
                message = "Error in resizing images.";
            }
            return message;

        }

        bool IsValidImage(string filename)
        {
            try
            {
                Image newImage = Image.FromFile(filename);
            }
            catch (OutOfMemoryException ex)
            {
                // Image.FromFile will throw this if file is invalid.
                // Don't ask me why.
                return false;
            }
            return true;
        }
//Otherwise if you're using WPF you can do the following:

//bool IsValidImage(string filename)
//{
//    try
//    {
//        BitmapImage newImage = new BitmapImage(filename);
//    }
//    catch(NotSupportedException)
//    {
//        // System.NotSupportedException:
//        // No imaging component suitable to complete this operation was found.
//        return false;
//    }
//    return true;
//}

        private Image ScaleByPercent(Image imgPhoto, int Percent)
        {
            float nPercent = ((float)Percent / 100);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;

            int destX = 0;
            int destY = 0;
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

    }
}
