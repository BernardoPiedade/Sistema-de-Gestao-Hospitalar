using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Hospital
    {
        List<Trabalhadores> listaTrabalhadores;
        List<Gabinetes> listaGabinetes;
        List<Salas> listaSala;

        public List<Trabalhadores> ListaTrabalhadores { get => listaTrabalhadores; set => listaTrabalhadores = value; }
        public List<Gabinetes> ListaGabinetes { get => listaGabinetes; set => listaGabinetes = value; }
        public List<Salas> ListaSala { get => listaSala; set => listaSala = value; }

        public Hospital()
        {
            listaTrabalhadores = new List<Trabalhadores>();
            listaGabinetes = new List<Gabinetes>();
            listaSala = new List<Salas>();
        }

        public Hospital(Hospital h)
        {
            listaTrabalhadores = h.listaTrabalhadores;
            listaGabinetes = h.listaGabinetes;
            listaSala = h.listaSala;
        }


        public Hospital(List<Trabalhadores> listaTrabalhadores, List<Gabinetes> listaGabinetes, List<Salas> listaSala)
        {
            this.listaTrabalhadores = listaTrabalhadores;
            this.listaGabinetes = listaGabinetes;
            this.listaSala = listaSala;
        }

        public override bool Equals(object obj)
        {
            if (((Hospital)obj).listaTrabalhadores == listaTrabalhadores &&
                ((Hospital)obj).listaGabinetes == listaGabinetes &&
                ((Hospital)obj).listaSala == listaSala)
                return true;
            return false;
        }

        //------------------------------------------------------------------\\

    }
}
