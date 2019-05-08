using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Gabinetes
    {
        string tipogabinete;
        int numgabinete;
        string medicoresponsavel;

        public int Numgabinete { get => numgabinete; set => numgabinete = value; }
        public string Medicoresponsavel { get => medicoresponsavel; set => medicoresponsavel = value; }
        public string Tipogabinete { get => tipogabinete; set => tipogabinete = value; }

        public Gabinetes()
        {
            tipogabinete = "";
            Numgabinete = 0;
            Medicoresponsavel = "";
        }

        public Gabinetes(Gabinetes g)
        {
            tipogabinete = g.tipogabinete;
            numgabinete = g.Numgabinete;
            medicoresponsavel = g.Medicoresponsavel;
        }

        public Gabinetes(int numgabinete, string medicoresponsavel, string tipogabinete)
        {
            this.Tipogabinete = tipogabinete;
            this.Numgabinete = numgabinete;
            this.Medicoresponsavel = medicoresponsavel;
        }

        public override bool Equals(object obj)
        {
            if (((Gabinetes)obj).tipogabinete == tipogabinete &&
            ((Gabinetes)obj).numgabinete == numgabinete &&
            ((Gabinetes)obj).medicoresponsavel == medicoresponsavel)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Tipo de Gabinete: "+tipogabinete+
                "\nNº Gabinete: "+numgabinete+
                "\nMédico Responsável: "+medicoresponsavel;

        }
    }
}
