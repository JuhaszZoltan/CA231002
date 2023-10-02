using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA231002
{
    internal class Auto
    {
        public string Model { get; set; }
        public int Teljesitmeny { get; set; }
        public float Tomeg { get; set; }
        public int Gyorsulas { get; set; }
        public int NoBeavatkozas { get; set; }

        public Auto(string r)
        {
            string[] v = r.Split(';');
            Model = v[0];
            Teljesitmeny = int.Parse(v[1]);
            Tomeg = float.Parse(v[2]);
            Gyorsulas = int.Parse(v[3]);
            NoBeavatkozas = int.Parse(v[4]);
        }
    }
}
