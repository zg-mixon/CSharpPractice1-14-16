using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

//Use Try Catch when working with external code
namespace TryCatchErrorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    File.AppendAllText("c:\\Notes.txt", "Hello World!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message); // Don't do this! It will show users info they shouldn't have if they are knowledable enough to find it

            //    Console.WriteLine("Sorry, could not append to file. Try again?");
            //}

            //// pause
            //Console.ReadLine();

            // creates bitmap for you
            //Always use using if you are working with IDisposable Classes
            using (var bitmap = new Bitmap(500, 500)) { 

            // randomly set 1000 pixels all over the bitmap
            var rnd = new Random();
            for (var i = 0; i < 1000; i++)
            {
                bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.Green);
            }

            // save bitmap to current directory (debug directory)
            var currentDirectory = Environment.CurrentDirectory;
            var path = Path.Combine(currentDirectory, "MyImage.png");
            bitmap.Save(path, ImageFormat.Png);

            Console.ReadLine();
        }
        }
    }
}
