using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Meer
    {
        private List<Pirat> pirats = new List<Pirat>();
        private List<Insel> inseln = new List<Insel>();  //C# vorgegebene Liste mit diversen methoden
        private Schiff schiff;
        private Spielfigur sfpp;



        public void AddInsel(Insel insel)
        {
            inseln.Add(insel);
        }
        public Insel GetInsel(int position)
        {
            return inseln[position];
        }
        public void SetSchiff(Schiff schiff)
        {
            this.schiff = schiff;
        }
        public Schiff GetSchiff()
        {
            return schiff;
        }
        public void SetSfpp(Spielfigur sfpp)
        {
            this.sfpp = sfpp;
        }
        public Spielfigur GetSfpp()
        {
            return sfpp;
        }
        public void AddPirat(Pirat pirat)
        {
            pirats.Add(pirat);
        }
        public void SetPirat(Pirat pirat)
        {
            pirats = pirat;
        }
        public Pirat GetPiratName(int position)
        {
            return pirats[position];
        }
    }
}
