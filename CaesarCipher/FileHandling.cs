using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class FileHandling
    {
        public static void WriteToFile(String filepath, String thingsToWrite)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@filepath, true))
                {
                    writer.WriteLine(thingsToWrite);
                }
            }
            catch (FileNotFoundException)
            {
                Console.Write("File Not Found");
            }
            catch (IOException)
            {
                Console.Write("IOException");
            }
        }

        public static Boolean fileExists(String filepath)
        {
            Boolean exist;
            if (File.Exists(@filepath))
            {
                exist = true;
            }
            else
            {
                exist = false;
            }
            return exist;
        }

        public static String[] ReadFromFileEachLine(String path)
        {
            string[] lines = File.ReadAllLines(@path);
            return lines;
        }
    }
}
