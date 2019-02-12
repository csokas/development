using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development
{
    class Program
    {
        static void Main(string[] args)
        {
            List<JatekosLovese> list = ReadFile();
            Console.WriteLine("5. feladat: Lövések száma: {0} db", list.Count.ToString());
            
            Console.ReadLine();
        }

        public static List<JatekosLovese> ReadFile()
        {
            string[] content = System.IO.File.ReadAllLines(@"C:\Users\Lackó\source\repos\Development\development\Development\lovesek.txt");
            List<JatekosLovese> jatekoslovesek = new List<JatekosLovese>();
            string name;
            double x;
            double y;

            for (int i = 1; i < content.Length - 1; i++)
            {
                string[] datas = content[i].Split(';');
                name = datas[0];
                x = Convert.ToDouble(datas[1]);
                y = Convert.ToDouble(datas[2]);
                jatekoslovesek.Add(new JatekosLovese(name, x, y, i));
            }
            return jatekoslovesek;
        }
    }
}
