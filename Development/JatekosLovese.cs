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
                return Math.Sqrt(x*x + y*y);
            }
            set => distance = value;
        }
    }
}
