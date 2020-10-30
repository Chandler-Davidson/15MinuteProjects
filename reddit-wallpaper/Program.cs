using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RedditSharp;
using System.Drawing;

namespace RedditWallpaperChanger
{
    class Program
    {
        /// <summary>
        /// Sets the active wallpaper to the latest of a given subreddit.
        /// </summary>
        /// <param name="args">Subreddit name, ex. "/r/wallpapers"</param>
        static void Main(string[] args)
        {
            // Reddit as a service from https://github.com/ddevault/RedditSharp
            var reddit = new Reddit();

            var subredditStr = args.Length > 0 ? args.First() : "/r/wallpapers";    // Decide on subreddit
            var subreddit = reddit.GetSubreddit(subredditStr);  // Fetch the subreddit

            // Fetch the best post within 24 hours
            var post = subreddit.GetTop(RedditSharp.Things.FromTime.Day).Take(1).First();

            var fileName = ValidateFileName(post.Title);    // Remove any illegal characters
            var fileType = Path.GetExtension(post.Url.AbsolutePath);    // Fetch the file extension
            var localUri = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Wallpapers\" + fileName;   // Store the local path

            // Download the image from Reddit
            using (var client = new WebClient())
                client.DownloadFile(new Uri(post.Url.AbsoluteUri), localUri + fileType);

            // Resize the image, then save locally
            var resizedImage = Resizer.ResizeImage(Image.FromFile(localUri + fileType), 1920, 1080);
            resizedImage.Save(localUri);

            // Set the new image to our wallpaper
            Wallpaper.Set(new Uri(localUri), Wallpaper.Style.Centered);
        }

        /// <summary>
        /// Literally copy/pasted from https://stackoverflow.com/a/620619
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static string ValidateFileName(string fileName)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                fileName = fileName.Replace(c, '_');

            return fileName;
        }
    }
}
