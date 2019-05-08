using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Trabalhadores
    {
        string pnome;
        string unome;
        DateTime datanascimento = new DateTime();
        int idade;
        string morada;
        string horario;
        int salario;
        string turno;

        public string Pnome { get => pnome; set => pnome = value; }
        public string Unome { get => unome; set => unome = value; }
        public DateTime Datanascimento { get => datanascimento; set => datanascimento = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Morada { get => morada; set => morada = value; }
        public string Horario { get => horario; set => horario = value; }
        public int Salario { get => salario; set => salario = value; }
        public string Turno { get => turno; set => turno = value; }

        public Trabalhadores()
        {
            pnome = "";
            unome = "";
            datanascimento = new DateTime();
            idade = 0;
            morada = "";
            horario = "";
            salario = 0;
            turno = "";
        }

        public Trabalhadores(Trabalhadores t)
        {
            pnome = t.pnome;
            unome = t.unome;
            datanascimento = t.datanascimento;
            idade = t.idade;
            morada = t.morada;
            horario = t.horario;
            salario = t.salario;
            turno = t.turno;
        }

        public Trabalhadores(string pnome, string unome, DateTime datanascimento, int idade, string morada, string horario, int salario, string turno)
        {
            this.Pnome = pnome;
            this.Unome = unome;
            this.Datanascimento = datanascimento;
            this.Idade = idade;
            this.Morada = morada;
            this.Horario = horario;
            this.Salario = salario;
            this.Turno = turno;
        }

        public override bool Equals(object obj)
        {
            if (((Trabalhadores)obj).pnome == pnome &&
                ((Trabalhadores)obj).unome == unome &&
                ((Trabalhadores)obj).datanascimento == datanascimento &&
                ((Trabalhadores)obj).idade == idade &&
                ((Trabalhadores)obj).morada == morada &&
                ((Trabalhadores)obj).horario == horario &&
                ((Trabalhadores)obj).salario == salario &&
                ((Trabalhadores)obj).turno == turno)
                return true;
            return false;
        }

        public override string ToString()
        {
            return "P. Nome: "+pnome+"\tU. Nome: "+unome+
                   "\nD. Nascimento: "+datanascimento.ToShortDateString()+"\tIdade: "+idade+
                   "\nMorada: "+morada+
                   "\nHorário: "+horario+
                   "\nSalário: "+salario+
                   "\nTurnos: "+turno;
        }
    }
}
