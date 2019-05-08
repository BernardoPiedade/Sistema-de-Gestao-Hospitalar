using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Salas
    {
        string nomesala;
        int numsala;
        string enfermeiroresponsavel;

        public string Nomesala { get => nomesala; set => nomesala = value; }
        public int Numsala { get => numsala; set => numsala = value; }
        public string Enfermeiroresponsavel { get => enfermeiroresponsavel; set => enfermeiroresponsavel = value; }

        public Salas()
        {
            nomesala = "";
            numsala = 0;
            enfermeiroresponsavel = "";
        }

        public Salas(Salas s)
        {
            nomesala = s.nomesala;
            numsala = s.numsala;
            enfermeiroresponsavel = s.enfermeiroresponsavel;
        }

        public Salas(string nomesala, int numsala, string efermeiroresponsavel)
        {
            this.Nomesala = nomesala;
            this.Numsala = numsala;
            this.Enfermeiroresponsavel = efermeiroresponsavel;
        }

        public override bool Equals(object obj)
        {
            if (((Salas)obj).nomesala == nomesala &&
            ((Salas)obj).numsala == Numsala &&
                ((Salas)obj).enfermeiroresponsavel == enfermeiroresponsavel)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "Tipo de Sala: "+nomesala+
                "\nNº de Sala: "+numsala+
                "\nEnfermeiro/a Responsável: "+enfermeiroresponsavel;
        }
    }
}
