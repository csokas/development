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
        int x;
        int y;
        public int id { get; set; }

        public JatekosLovese(string name, int x, int y, int id)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.id = id;
        }

        

        

        public int Y { get => y; set => y = value; }
        public int X { get => x; set => x = value; }
        public string Name { get => name; set => name = value; }

    }
}
