using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development
{
    class LovesekControl
    {
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
        public static void ParseCoordinates()
        {
            string[] content = System.IO.File.ReadAllLines(@"C:\Users\Lackó\source\repos\Development\development\Development\lovesek.txt");
            string[] coordinates = content[0].Split(';');
            CelTabla.x = Convert.ToDouble(coordinates[0]);
            CelTabla.y = Convert.ToDouble(coordinates[1]);
        }

        public static int LegjobbLoves(List<JatekosLovese> jatekoslovesek)
        {
            int id = 0;
            double tempDis = jatekoslovesek[0].Distance;
            foreach (var item in jatekoslovesek)
            {
                if (item.Distance < tempDis)
                    id = item.id;
            }
            return id;
        }

        public static int NullPontosok(List<JatekosLovese> jatekoslovesek)
        {
            int num = 0;

            foreach (var item in jatekoslovesek)
            {
                if (item.Pontszam == 0) num++;
            }

            return num;
        }

        public static List<string> JatekosokSzama(List<JatekosLovese> jatekoslovesek)
        {
            List<string> nevek = new List<string>();
            foreach (var item in jatekoslovesek)
            {
                if (!nevek.Contains(item.Name))
                    nevek.Add(item.Name);
            }
            return nevek;
        }

        public static List<JatekosLovese> JatekosLovesei(List<JatekosLovese> jatekoslovesek, List<string> nevek)
        {
            List<JatekosLovese> lovesek = new List<JatekosLovese>();
            for (int i = 0; i < nevek.Count ; i++)
            {
                int tempNum = 0;
                foreach (var item in jatekoslovesek)
                {
                    if(nevek[i] == item.Name)
                    {
                        tempNum++;
                    }
                }
                lovesek.Add(new JatekosLovese(nevek[i], tempNum));
                tempNum = 0;
            }
            return lovesek;
        }

        public static List<JatekosLovese> JatekosokAtlagai(List<JatekosLovese> jatekoslovesek, List<string> nevek)
        {
            List<JatekosLovese> lovesek = new List<JatekosLovese>();
            for (int i = 0; i < nevek.Count; i++)
            {
                int tempNum = 0;
                double tempPont = 0;
                foreach (var item in jatekoslovesek)
                {
                    if (nevek[i] == item.Name)
                    {
                        tempNum++;
                        tempPont += item.Pontszam;
                    }
                }
                lovesek.Add(new JatekosLovese(nevek[i], tempPont / tempNum));
                tempNum = 0;
                tempPont = 0;
            }
            return lovesek;
        }

        public static string Gyoztes(List<JatekosLovese> lovesek)
        {
            double atlag = lovesek[0].AtlagPontszam;
            string gyoztes = lovesek[0].Name;
            foreach (var item in lovesek)
            {
                if (item.AtlagPontszam > atlag)
                    gyoztes = item.Name;
            }
            return gyoztes;
        }

    }
}
