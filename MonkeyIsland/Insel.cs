using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Insel
    {
        private string name;
        private List<Pirat> pirats = new List<Pirat>();
        private Strand strand = new Strand();   //Komposition -> wenn Container weg dann auch Objekt weg
        private Kneipe kneipe = new Kneipe();   //Komposition -> wenn Container weg dann auch Objekt weg 
        private Schiff schiff;                  //Aggregation -> kein schiff sondern ein schiffsparkplatz wenn parkplatz weg schiff noch da
        private Spielfigur sfpp;

        public Kneipe GetKneipe()
        {
            return kneipe;
        }
        public Strand GetStrand()
        {
            return strand;
        }
        public void SetKneipe(Kneipe k)
        {
            kneipe = k;
        }
        public void SetStrand(Strand s)
        {
            strand = s;
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
        public Insel(string nInsel, string nKneipe , string nStrand)
        {
            name = nInsel;
            strand.SetStrand(nStrand);
            kneipe.SetKneipe(nKneipe);
        }
        public void SetSchiff(Schiff schiff)
        {
            this.schiff = schiff;
        }
        public Schiff GetSchiff()
        { 
            return schiff; 
        }
    }
}
