using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCheck
{
    public class FileInput
    {
        public string GetFile()
        {
            string file = "input.txt";
            Console.WriteLine("Enter name of your .txt and press enter ");
            var userFileName = Console.ReadLine();

            var fileName = new FileInfo($"..\\..\\{userFileName}");
            if (!fileName.Exists)
            {
                Console.WriteLine($"There is no such file: {fileName.FullName}");
                Console.WriteLine("Default \"lorem ipsum\" input.txt has been used.");
            }
            else {
                file = fileName.FullName.ToString();
            }

            
            return file;
        }
    }
}
