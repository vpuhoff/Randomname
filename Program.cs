using System;
using System.IO;

namespace Randomname
{
    class Program
    {
        static void Main(string[] args)
        {
            string parameters = "abcdefghijklnopqrstuvwxyz1234567890";
            int count = 13;
            string result = "";
            Random rnd = new Random();
            int lenght = parameters.Length;
            for (int i = 0; i < count; i++)
            {
                result += parameters[rnd.Next(lenght)];
            }
            string oldname = args[0];
            string ext = Path.GetExtension(oldname);
            System.IO.Directory.Move(oldname, result + ext);       
        }
    }   
}
