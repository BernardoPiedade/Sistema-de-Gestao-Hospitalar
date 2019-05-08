using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Medico
    {
        internal static void VerMedicos(List<Trabalhadores> listaTrabalhadores)
        {
            try
            {
                Console.Clear();
                for(int i = 0; i < listaTrabalhadores.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (listaTrabalhadores[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Medicos"))
                    Console.WriteLine(listaTrabalhadores[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Prima qualquer tecla..");
                Console.ReadKey();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        internal static void VerHorario(List<Trabalhadores> listaTrabalhadores)
        {
            try
            {
                Console.Clear();
                for(int i = 0; i < listaTrabalhadores.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (listaTrabalhadores[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Medicos"))
                    Console.WriteLine("Horário de: " + listaTrabalhadores[i].Pnome + " " + listaTrabalhadores[i].Unome + "\n" +listaTrabalhadores[i].Horario.ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Prima qualquer tecla..");
                Console.ReadKey();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        internal static void MarcarConsultas(List<Trabalhadores> listaTrabalhadores)
        {
            throw new NotImplementedException();
        }

        internal static void PassarReceitas(List<Trabalhadores> listaTrabalhadores)
        {
            throw new NotImplementedException();
        }

        internal static void VerTurnos(List<Trabalhadores> listaTrabalhadores)
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < listaTrabalhadores.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (listaTrabalhadores[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Medicos"))
                    Console.WriteLine("Turno de: " + listaTrabalhadores[i].Pnome + " " + listaTrabalhadores[i].Unome + "\n" +listaTrabalhadores[i].Turno.ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Prima qualquer tecla..");
                Console.ReadKey();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        internal static void ImprimirReceitas(List<Trabalhadores> listaTrabalhadores)
        {
            throw new NotImplementedException();
        }
    }
}