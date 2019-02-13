using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development
{
    class JatekosLovese
    {
        string name;
        double x;
        double y;
        public int id { get; set; }
        double distance;
        double pontszam;
        int lovesekSzama;
        double atlagPontszam;

        public JatekosLovese(string name, double atlagPontszam)
        {
            this.name = name;
            this.atlagPontszam = atlagPontszam;
        }

        public JatekosLovese(string name, int lovesekSzama)
        {
            this.name = name;
            this.lovesekSzama = lovesekSzama;
        }

        public JatekosLovese(string name, double x, double y, int id)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.id = id;
        }

        
        public double Y { get => y; set => y = value; }
        public double X { get => x; set => x = value; }
        public string Name { get => name; set => name = value; }
        public double Distance
        {
            get
            {
                return Math.Sqrt(Math.Pow((x - CelTabla.x), 2)+ Math.Pow((y - CelTabla.y), 2) );
            }
            set => distance = value;
        }

        public double Pontszam
        {
            get
            {
                return 10 - Distance;
            }
            
            set => pontszam = value;
        }

        public int LovesekSzama { get => lovesekSzama; set => lovesekSzama = value; }
        public double AtlagPontszam { get => atlagPontszam; set => atlagPontszam = value; }
    }
}
