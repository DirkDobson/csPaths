using System;
using System.IO;

namespace csPaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @":\Projects/CSharpFundamentals\HellowWorld\HellowWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Get Direcotry Name " + Path.GetDirectoryName(path));
        }
    }
}
