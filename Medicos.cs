using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Medicos : Trabalhadores
    {
        string especializacao;
        int gabinete;

        public string Especializacao { get => especializacao; set => especializacao = value; }
        public int Gabinete { get => gabinete; set => gabinete = value; }

        public Medicos()
        {
            especializacao = "";
            gabinete = 0;
        }

        public Medicos(Medicos m)
        {
            especializacao = m.especializacao;
            gabinete = m.gabinete;
        }

        public Medicos(string especializacao, int gabinete, string pnome, string unome, DateTime datanascimento, int idade, string morada, string horario, int salario, string turno) : base(pnome,unome,datanascimento,idade,morada,horario,salario,turno)
        {
            this.Especializacao = especializacao;
            this.Gabinete = gabinete;
        }

        public override bool Equals(object obj)
        {
            if (((Medicos)obj).especializacao == especializacao &&
            ((Medicos)obj).gabinete == Gabinete)
                return true;
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEspecialização: "+especializacao+"\nGabinete: "+gabinete;
        }
    }
}
