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
            List<JatekosLovese> list = LovesekControl.ReadFile();
            Console.WriteLine("5. feladat: Lövések száma: {0} db", list.Count.ToString());

            LovesekControl.ParseCoordinates();
            int id = LovesekControl.LegjobbLoves(list);
            Console.WriteLine("7. feladat: Legpontosabb lövés: {0} x = {1} y = {2} távolság = {3}", list[id].Name, list[id].X, list[id].Y, list[id].Distance);

            int nullpoints = LovesekControl.NullPontosok(list);
            Console.WriteLine("9. feladat: nulla pontos lövések száma: {0}", nullpoints);

            int num = LovesekControl.JatekosokSzama(list).Count;
            Console.WriteLine("10. feladat: Játékosok száma: {0}", num);

            List<JatekosLovese> JatekosLovesek = LovesekControl.JatekosLovesei(list, LovesekControl.JatekosokSzama(list));
            Console.WriteLine("11.feladat: Lövések száma: ");
            foreach (var item in JatekosLovesek)
            {
                Console.WriteLine("{0} - {1} db", item.Name, item.LovesekSzama);
            }

            Console.WriteLine("12. feladat: Játékosok átlagai: ");
            List<JatekosLovese> Jatekosatlagok = LovesekControl.JatekosokAtlagai(list, LovesekControl.JatekosokSzama(list));
            foreach (var item in Jatekosatlagok)
            {
                Console.WriteLine("{0} - {1} ", item.Name, item.AtlagPontszam);
            }

            Console.WriteLine("13. feladat: Győztes játékos: ");
            Console.WriteLine(" {0} " ,LovesekControl.Gyoztes(Jatekosatlagok) );
            Console.ReadLine();
        }
    }
}
