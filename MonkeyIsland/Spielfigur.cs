using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyIsland
{
    internal class Spielfigur: Pirat 
    {
        private Strand strand;
        private Kneipe kneipe;
        private Insel insel;
        private Spielfigur pp;

        public void SetKneipePosition(Kneipe n)
        {
            kneipe = n;
            strand = null;
            insel = null;
        }
        public Kneipe GetKneipePosition()
        {
            return kneipe;
        }
        public void SetStrandPosition(Strand s) 
        { 
            strand = s;
            insel = null;
            kneipe = null;
        
        }
        public Strand GetStrandPosition() 
        { 
            return strand;
        }
        public void SetInselPosition(Insel i)
        { 
            insel = i;
            strand = null;
            kneipe = null;
        }
        public Insel GetInselPosition() 
        {
            return insel;
        }

    }
}
