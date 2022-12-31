using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationApp.Utilities
{
    public static class Compression
    {
        /// <summary>
        /// Compresses a string and returns a deflate compressed, Base64 encoded string.
        /// </summary>
        /// <param name="uncompressedString">String to compress</param>
        public static string Compress(byte[] uncompressed)
        {
            byte[] compressedBytes;

            using (var uncompressedStream = new MemoryStream(uncompressed))
            {
                using (var compressedStream = new MemoryStream())
                {
                    // setting the leaveOpen parameter to true to ensure that compressedStream will not be closed when compressorStream is disposed
                    // this allows compressorStream to close and flush its buffers to compressedStream and guarantees that compressedStream.ToArray() can be called afterward
                    // although MSDN documentation states that ToArray() can be called on a closed MemoryStream, I don't want to rely on that very odd behavior should it ever change
                    using (var compressorStream = new DeflateStream(compressedStream, CompressionLevel.Fastest, true))
                    {
                        uncompressedStream.CopyTo(compressorStream);
                    }

                    // call compressedStream.ToArray() after the enclosing DeflateStream has closed and flushed its buffer to compressedStream
                    compressedBytes = compressedStream.ToArray();
                }
            }

            return Convert.ToBase64String(compressedBytes);
        }

        /// <summary>
        /// Decompresses a deflate compressed, Base64 encoded string and returns an uncompressed string.
        /// </summary>
        /// <param name="compressedString">String to decompress.</param>
        public static string Decompress(string compressedString)
        {
            byte[] decompressedBytes;

            var compressedStream = new MemoryStream(Convert.FromBase64String(compressedString));

            using (var decompressorStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
            {
                using (var decompressedStream = new MemoryStream())
                {
                    decompressorStream.CopyTo(decompressedStream);

                    decompressedBytes = decompressedStream.ToArray();
                }
            }

            //return decompressedBytes;
            return Convert.ToBase64String(decompressedBytes);
        }
    }

    //public static class Compression
    //{
    //    /// <summary>
    //    /// Compresses a string and returns a deflate compressed, Base64 encoded string.
    //    /// </summary>
    //    /// <param name="uncompressedString">String to compress</param>
    //    public static string Compress(Image uncompressedIMG)
    //    {
    //        byte[] compressedBytes;

    //        using (var uncompressedStream = new MemoryStream())
    //        {
    //            uncompressedIMG.Save(uncompressedStream, uncompressedIMG.RawFormat);
    //            using (var compressedStream = new MemoryStream())
    //            {
    //                using (var compressorStream = new DeflateStream(compressedStream, CompressionLevel.Fastest, true))
    //                {
    //                    uncompressedStream.CopyTo(compressorStream);
    //                }
    //                compressedBytes = compressedStream.ToArray();
    //            }
    //        }

    //        return Convert.ToBase64String(compressedBytes);
    //    }

    //    /// <summary>
    //    /// Decompresses a deflate compressed, Base64 encoded string and returns an uncompressed string.
    //    /// </summary>
    //    /// <param name="compressedString">String to decompress.</param>
    //    public static string Decompress(string compressedString)
    //    {
    //        byte[] decompressedBytes;

    //        var compressedStream = new MemoryStream(Convert.FromBase64String(compressedString));

    //        using (var decompressorStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
    //        {
    //            using (var decompressedStream = new MemoryStream())
    //            {
    //                decompressorStream.CopyTo(decompressedStream);

    //                decompressedBytes = decompressedStream.ToArray();
    //            }
    //        }

    //        //return decompressedBytes;
    //        return Convert.ToBase64String(decompressedBytes);
    //    }

    //    public static Image ResizeImage(double scaleFactor, string sourcePath)
    //    {
    //        using (var image = Image.FromFile(sourcePath))
    //        {
    //            var newWidth = (int)(image.Width * scaleFactor);
    //            var newHeight = (int)(image.Height * scaleFactor);
    //            var thumbnailImg = new Bitmap(newWidth, newHeight);
    //            var thumbGraph = Graphics.FromImage(thumbnailImg);
    //            thumbGraph.CompositingQuality = CompositingQuality.HighQuality;
    //            thumbGraph.SmoothingMode = SmoothingMode.HighQuality;
    //            thumbGraph.InterpolationMode = InterpolationMode.HighQualityBicubic;
    //            var imageRectangle = new Rectangle(0, 0, newWidth, newHeight);
    //            thumbGraph.DrawImage(image, imageRectangle);
    //            //thumbnailImg.Save(targetPath, image.RawFormat);
    //            return image;
    //        }
    //    }

    //    public static Image ResizeImage(Image image, int width, int height)
    //    {
    //        var res = new Bitmap(width, height);
    //        using (var graphic = Graphics.FromImage(res))
    //        {
    //            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
    //            graphic.SmoothingMode = SmoothingMode.HighQuality;
    //            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
    //            graphic.CompositingQuality = CompositingQuality.HighQuality;
    //            graphic.DrawImage(image, 0, 0, width, height);
    //        }
    //        return res;
    //    }
    //}


}
