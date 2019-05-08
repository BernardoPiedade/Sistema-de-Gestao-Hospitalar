using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Funcionario
    {
        internal static void VerFuncionarios(List<Trabalhadores> listaTrabalhadores)
        {
            Console.Clear();

            for (int i = 0; i < listaTrabalhadores.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (listaTrabalhadores[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Funcionarios"))
                Console.WriteLine(listaTrabalhadores[i].ToString());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n\n");
            Console.WriteLine("Prima qualquer tecla");
            Console.ReadKey();
        }

        internal static void VerHorarioFuncionarios(List<Trabalhadores> listaTrabalhadores)
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < listaTrabalhadores.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (listaTrabalhadores[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Funcionarios"))
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

        internal static void VerTrabalhoProposto(List<Trabalhadores> listaTrabalhadores)
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < listaTrabalhadores.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (listaTrabalhadores[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Funcionarios"))
                    Console.WriteLine("Cargo de: "+listaTrabalhadores[i].Pnome+" " + listaTrabalhadores[i].Unome + "\n" +((Funcionarios)listaTrabalhadores[i]).Cargo.ToString());
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
    }
}
