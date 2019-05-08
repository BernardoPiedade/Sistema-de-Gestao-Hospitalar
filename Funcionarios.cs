using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Funcionarios : Trabalhadores
    {
        string cargo;

        public string Cargo { get => cargo; set => cargo = value; }

        public Funcionarios()
        {
            Cargo = "";
        }

        public Funcionarios(Funcionarios f)
        {
            Cargo = f.cargo;
        }

        public Funcionarios(string cargo, string pnome, string unome, DateTime datanascimento, int idade, string morada, string horario, int salario, string turno) : base(pnome, unome, datanascimento, idade, morada, horario, salario, turno)
        {
            this.cargo = cargo;
        }

        public override bool Equals(object obj)
        {
            if (((Funcionarios)obj).cargo == cargo)
                return true;
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + "\nCargo: "+cargo;
        }
    }
}
