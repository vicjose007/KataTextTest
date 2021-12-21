using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1Text
{
    public class Text
    {
        public int Test1()
        {
            string filepath = @"C:\Desktop\test.txt";
            string[] lines = File.ReadAllLines(filepath);

            char[] frase = filepath.ToCharArray();


            int num = 0;
            int i = 0;

            while (frase[i] == ' ') i++;

            if (frase[i] == '.') num--;

            while (frase[i] != '.')
            {
                if (frase[i] == ' ')
                {
                    num++;
                    while (frase[i] == ' ') i++;

                    if (frase[i] == ',') num--;
                }
                else
                {
                    i++;
                }
            }
            num++;

            Console.WriteLine("El texto tiene " + num + "Palabras");

            Console.ReadKey();

            return 0;

        }
        
    }
}