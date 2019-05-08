using System;
namespace TP_M11_Bernardo_Patrícia
{
    public class Pacientes
    {
        string pnome;
        string unome;
        int idade;
        DateTime dnascimento = new DateTime();
        int nummarcacoes;
        string morada;

        public string Pnome { get => pnome; set => pnome = value; }
        public string Unome { get => unome; set => unome = value; }
        public int Idade { get => idade; set => idade = value; }
        public DateTime Dnascimento { get => dnascimento; set => dnascimento = value; }
        public int Nummarcacoes { get => nummarcacoes; set => nummarcacoes = value; }
        public string Morada { get => morada; set => morada = value; }

        public Pacientes()
        {
            Pnome = "";
            Unome = "";
            Idade = 0;
            Dnascimento = new DateTime();
            Nummarcacoes = 0;
            Morada = "";
        }

        public Pacientes(Pacientes p)
        {
            Pnome = p.pnome;
            Unome = p.unome;
            Idade = p.idade;
            Dnascimento = p.dnascimento;
            Nummarcacoes = p.nummarcacoes;
            Morada = p.morada;
        }

        public Pacientes(string pnome, string unome, int idade, DateTime dnascimento, int nummarcacoes, string morada)
        {
            this.pnome = pnome;
            this.unome = unome;
            this.idade = idade;
            this.dnascimento = dnascimento;
            this.nummarcacoes = nummarcacoes;
            this.morada = morada;
        }

        public override bool Equals(object obj)
        {
            if (((Pacientes)obj).pnome == pnome &&
                ((Pacientes)obj).unome == unome &&
                ((Pacientes)obj).idade == idade &&
                ((Pacientes)obj).dnascimento == dnascimento &&
                ((Pacientes)obj).nummarcacoes == nummarcacoes &&
                ((Pacientes)obj).morada == morada)
                    return true;
                return false;
        }

        public override string ToString()
        {
            return "Pº Nome: " + pnome + "\tUº Nome: " + unome +
                "\nD. Nascimento: " + dnascimento.ToShortDateString() + "\tIdade: "+idade+
                "\nMorada: "+morada+
                "\nNº Marcações: "+nummarcacoes;
        }
    }
}
