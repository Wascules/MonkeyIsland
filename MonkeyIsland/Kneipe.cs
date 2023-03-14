using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Kneipe
    {
        private string name;
        private List<Pirat> pirats = new List<Pirat>();
        private Spielfigur sfpp;


        public void SetKneipe(string k)
        {
            name = k;
        }
        public string GetKneipe()
        {
            return name;
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
        public void SetPirat(Pirat pirat, int index)
        {
            pirats[index] = pirat;
        }
        public Pirat GetPiratName()
        {
            return pirats[0];
        }
    }
}
