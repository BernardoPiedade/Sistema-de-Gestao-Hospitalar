using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Enfermeiros : Trabalhadores
    {
        string cargo;
        int sala;

        public string Cargo { get => cargo; set => cargo = value; }
        public int Sala { get => sala; set => sala = value; }

        public Enfermeiros()
        {
            Cargo = "";
            Sala = 0;
        }

        public Enfermeiros(Enfermeiros e)
        {
            Cargo = e.cargo;
            Sala = e.sala;
        }

        public Enfermeiros(string cargo, int sala, string pnome, string unome, DateTime datanascimento, int idade, string morada, string horario, int salario, string turno) : base(pnome,unome,datanascimento,idade,morada,horario,salario,turno)
        {
            this.cargo = cargo;
            this.sala = sala;
        }

        public override bool Equals(object obj)
        {
            if (((Enfermeiros)obj).cargo == cargo &&
            ((Enfermeiros)obj).sala == sala)
                return true;
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "\nCargo: "+cargo+"\nSala: "+sala;
        }
    }
}
