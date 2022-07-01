using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoFolderImages
{
    class Program
    {    

        public static readonly List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".BMP", ".GIF", ".PNG", ".WEBM" };


        static void Main(string[] args)
        {

           

            DateTime today = DateTime.Today;
            var folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var files = Directory.GetFiles(folder);

            string destinationDirectory = "D:\\Desktop\\" + DateTime.Today.ToString("yyyyMMdd");


            foreach (var f in files)
            {
                if (ImageExtensions.Contains(Path.GetExtension(f).ToUpperInvariant()))
                {
                    System.IO.Directory.CreateDirectory(destinationDirectory);                
                    System.IO.File.Move(f, destinationDirectory + "\\" + Path.GetFileName(f));
                }
            }


        }


    }
}
