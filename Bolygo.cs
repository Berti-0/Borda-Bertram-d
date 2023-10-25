using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Borda_Bertram_10._25
{
    internal class Bolygo
    {
        
        public string Nev { get; set; }
        public int Hold { get; set; }
        public float terfogat { get; set; }
       public Bolygo(string sor)
        {
            string[] splt = sor.Split(';');
            Nev = splt[0];
            Hold = int.Parse(splt[1]);
            terfogat = float.Parse(splt[2].Replace('.',','));
        }


    }
}
