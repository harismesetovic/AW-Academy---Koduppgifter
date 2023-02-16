using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //delegate bool Filter(string filePath);

    static class FileFinder
    {
        public static void Find(string folderPath, Func<string, bool> filter)
        {
            var filePaths = Directory.GetFiles(folderPath);
            foreach (var filePath in filePaths)
            {
                if (filter(filePath))
                Console.WriteLine(filePath);
            }
        }
    }
}
