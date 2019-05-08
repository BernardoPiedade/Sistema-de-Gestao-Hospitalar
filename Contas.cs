using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Contas
    {

        string user;
        string pass;
        List<Contas> lcontas;
        

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public List<Contas> Lcontas { get => lcontas; set => lcontas = value; }

        public Contas()
        {
            user = "";
            pass = "";
            lcontas = new List<Contas>();
        }

        public Contas(Contas c)
        {
            user = c.user;
            pass = c.pass;
            lcontas = c.lcontas;
        }

        public Contas(string user, string pass, List<Contas> lcontas)
        {
            this.user = user;
            this.pass = pass;
            this.lcontas = lcontas;
        }

        public override bool Equals(object obj)
        {
            if (((Contas)obj).user == user &&
                ((Contas)obj).pass == pass &&
                ((Contas)obj).lcontas == lcontas)
                return true;
            return false;
        }
    }
}
