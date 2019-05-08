using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    public class Admin
    {

        public static void VerTrabalhadores(List<Trabalhadores> lista)
        {
            try
            {
                int op = 1;
                while(op != 0)
                {
                    Console.Clear();

                    Console.Title = "Hospital Hestel - Ver Trabalhadores";

                    Console.WriteLine("[1] - Ver Médicos");
                    Console.WriteLine("[2] - Ver Enfermeiros");
                    Console.WriteLine("[3] - Ver Funcionários");
                    Console.WriteLine("[0] - Voltar atrás");
                    Console.WriteLine("\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Title = "Hospital HESTEL - Ver Médicos";
                            Console.Clear();
                            for (int i = 0; i < lista.Count; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Medicos"))
                                Console.WriteLine(lista[i].ToString());
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("-----------------------------------------");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Prima qualquer tecla");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Title = "Hospital HESTEL - Ver Enfermeiros";
                            Console.Clear();
                            for (int i = 0; i < lista.Count; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Enfermeiros"))
                                Console.WriteLine(lista[i].ToString());
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("-----------------------------------------");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Prima qualquer tecla");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Title = "Hospital HESTEL - Ver Funcionários";
                            Console.Clear();

                            for (int i = 0; i < lista.Count; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Funcionarios"))
                                Console.WriteLine(lista[i].ToString());
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("-----------------------------------------");
                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("\n\n");
                            Console.WriteLine("Prima qualquer tecla");
                            Console.ReadKey();
                            break;
                        case 0:
                            break;
                    }
                }
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

        //-----------------------------------------------------------\\

        internal static void EditarTrabalhadores(List<Trabalhadores> lista)
        {
            try
            {
                Console.Title = "Hospital Hestel - Editar Trabalhadores";
                Console.Clear();
                Console.WriteLine("[1] - Editar Médico");
                Console.WriteLine("[2] - Editar Enfermeiro");
                Console.WriteLine("[3] - Editar Funcionário");
                Console.WriteLine("[0] - Voltar atrás");
                Console.WriteLine("\n");
                Console.Write("->");
                int op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        EditarMedico(lista);
                        break;
                    case 2:
                        EditarEnfermeiro(lista);
                        break;
                    case 3:
                        EditarFuncionario(lista);
                        break;
                }
            }catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private static void EditarMedico(List<Trabalhadores> lista)
        {
            try
            {
                Console.Title = "Hospital HESTEL - Editar Médico";
                Console.Clear();

                int pos = ApresentarMedicos(lista);

                if(pos >= 0)
                {
                    Console.Clear();

                    Console.Write("Insira o Pº Nome: ");
                    lista[pos].Pnome = Console.ReadLine();
                    Console.Write("\nInsira o Uº Nome: ");
                    lista[pos].Unome = Console.ReadLine();
                    Console.Write("\nInsira a Data de Nasc.: ");
                    Console.Write("\n\tDia: ");
                    int dia = Int32.Parse(Console.ReadLine());
                    Console.Write("\n\tMês: ");
                    int mes = Int32.Parse(Console.ReadLine());
                    Console.Write("\n\tAno: ");
                    int ano = Int32.Parse(Console.ReadLine());
                    lista[pos].Datanascimento = new DateTime(ano, mes, dia);
                    Console.Write("\nIdade: ");
                    lista[pos].Idade = Int32.Parse(Console.ReadLine());
                    Console.Write("\nMorada: ");
                    lista[pos].Morada = Console.ReadLine();
                    Console.Write("\nHorário: ");
                    lista[pos].Horario = Console.ReadLine();
                    Console.Write("\nSalários: ");
                    lista[pos].Salario = Int32.Parse(Console.ReadLine());
                    Console.Write("\nturnos: ");
                    lista[pos].Turno = Console.ReadLine();
                    Console.Write("\nEspecialização: ");
                    ((Medicos)lista[pos]).Especializacao = Console.ReadLine();
                    Console.Write("\nGabinete: ");
                    ((Medicos)lista[pos]).Gabinete = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Médico editado com sucesso!");
                    Thread.Sleep(1020);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ocurreu um erro na selecção de trabalhador, por favor tente mais tarde.");
                    Thread.Sleep(1020);
                }

            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private static int ApresentarMedicos(List<Trabalhadores> lista)
        {
            try
            {
                Console.Title = "Hospital HESTEL - Escolher Médico";
                Console.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Medicos"))
                    Console.WriteLine("[" + i + "] - " + lista[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Escolha um funcionário");
                Console.Write("-> ");
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

            return Int32.Parse(Console.ReadLine());
        }

        private static void EditarEnfermeiro(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarEnfermeiros(lista);

                if (pos >= 0)
                {
                    Console.Title = "Hospital HESTEL - Editar Enfermeiro";
                    Console.Clear();

                    Console.Write("Insira o Pº Nome: ");
                    lista[pos].Pnome = Console.ReadLine();
                    Console.Write("\nInsira o Uº Nome: ");
                    lista[pos].Unome = Console.ReadLine();
                    Console.Write("\nInsira a Data de Nasc.: ");
                    Console.Write("\n\tDia: ");
                    int dia = Int32.Parse(Console.ReadLine());
                    Console.Write("\n\tMês: ");
                    int mes = Int32.Parse(Console.ReadLine());
                    Console.Write("\n\tAno: ");
                    int ano = Int32.Parse(Console.ReadLine());
                    lista[pos].Datanascimento = new DateTime(ano, mes, dia);
                    Console.Write("\nIdade: ");
                    lista[pos].Idade = Int32.Parse(Console.ReadLine());
                    Console.Write("\nMorada: ");
                    lista[pos].Morada = Console.ReadLine();
                    Console.Write("\nHorário: ");
                    lista[pos].Horario = Console.ReadLine();
                    Console.Write("\nSalários: ");
                    lista[pos].Salario = Int32.Parse(Console.ReadLine());
                    Console.Write("\nturnos: ");
                    lista[pos].Turno = Console.ReadLine();
                    Console.Write("\nCargo: ");
                    ((Enfermeiros)lista[pos]).Cargo = Console.ReadLine();
                    Console.Write("\nSala: ");
                    ((Enfermeiros)lista[pos]).Sala = Int32.Parse(Console.ReadLine());

                    Console.Clear();

                    Console.WriteLine("Enfermeiro editado com sucesso!");
                    Thread.Sleep(1020);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ocurreu um erro na selecção de trabalhador, por favor tente mais tarde.");
                    Thread.Sleep(1020);
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private static int ApresentarEnfermeiros(List<Trabalhadores> lista)
        {
            try
            {
                Console.Title = "Hospital HESTEL - Escolher Enfermeiro";
                Console.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Enfermeiros"))
                    Console.WriteLine("[" + i + "] - " + lista[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Escolha um funcionário");
                Console.Write("-> ");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
            return Int32.Parse(Console.ReadLine());

        }

        private static void EditarFuncionario(List<Trabalhadores> lista)
        {
            try
            {
                Console.Title = "Hospital HESTEL - Editar Funcionário";
                Console.Clear();

                int pos = ApresentarFuncionarios(lista);

                if(pos >= 0)
                {
                    Console.Clear();

                    Console.Write("Insira o Pº Nome: ");
                    lista[pos].Pnome = Console.ReadLine();
                    Console.Write("\nInsira o Uº Nome: ");
                    lista[pos].Unome = Console.ReadLine();
                    Console.Write("\nInsira a Data de Nasc.: ");
                    Console.Write("\n\tDia: ");
                    int dia = Int32.Parse(Console.ReadLine());
                    Console.Write("\n\tMês: ");
                    int mes = Int32.Parse(Console.ReadLine());
                    Console.Write("\n\tAno: ");
                    int ano = Int32.Parse(Console.ReadLine());
                    lista[pos].Datanascimento = new DateTime(ano, mes, dia);
                    Console.Write("\nIdade: ");
                    lista[pos].Idade = Int32.Parse(Console.ReadLine());
                    Console.Write("\nMorada: ");
                    lista[pos].Morada = Console.ReadLine();
                    Console.Write("\nHorário: ");
                    lista[pos].Horario = Console.ReadLine();
                    Console.Write("\nSalários: ");
                    lista[pos].Salario = Int32.Parse(Console.ReadLine());
                    Console.Write("\nturnos: ");
                    lista[pos].Turno = Console.ReadLine();
                    Console.Write("\nCargo: ");
                    ((Funcionarios)lista[pos]).Cargo = Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("Funcionário editado com sucesso!");
                    Thread.Sleep(1020);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ocurreu um erro na selecção de trabalhador, por favor tente mais tarde.");
                    Thread.Sleep(1020);
                }


            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("Opção não existe.");
                Thread.Sleep(1020);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }

        private static int ApresentarFuncionarios(List<Trabalhadores> lista)
        {
            try
            {
                Console.Title = "Hospital HESTEL - Apresentar Funcionário";
                Console.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Funcionarios"))
                    Console.WriteLine("[" + i + "] - " + lista[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Escolha um funcionário");
                Console.Write("-> ");
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

            return Int32.Parse(Console.ReadLine());
        }

        //------------------------------------------------\\

        internal static void VerHorarioTrabalhadores(List<Trabalhadores> lista)
        {
            Console.Title = "Hospital HESTEL - Ver Horario de Trabalhadores";
            Console.Clear();
            int op = 1;

            while(op != 0)
            {
                try
                {
                    Console.WriteLine("[1] - Horários de médicos");
                    Console.WriteLine("[2] - Horários de enfermeiros");
                    Console.WriteLine("[3] - Horário de funcionários");
                    Console.WriteLine("[0] - Sair\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            VerHorarioMedicos(lista);
                            break;
                        case 2:
                            VerHorarioEnfermeiros(lista);
                            break;
                        case 3:
                            VerHorarioFuncionarios(lista);
                            break;
                        case 0:
                            break;
                    }
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

        private static void VerHorarioMedicos(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarMedicos(lista);

                Console.Clear();

                Console.WriteLine("Horário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lista[pos].Horario);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Clique em qualquer tecla");
                Console.ReadKey();
                Console.Clear();
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

        private static void VerHorarioEnfermeiros(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarEnfermeiros(lista);

                Console.Clear();

                Console.WriteLine("Horário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lista[pos].Horario);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Clique em qualquer tecla");
                Console.ReadKey();
                Console.Clear();
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

        private static void VerHorarioFuncionarios(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarFuncionarios(lista);

                Console.Clear();

                Console.WriteLine("Horário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lista[pos].Horario);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Clique em qualquer tecla");
                Console.ReadKey();
                Console.Clear();
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

        //-----------------------------------------------------\\

        internal static void EditarEliminarHorariosTrabalhadores(List<Trabalhadores> lista)
        {
            try
            {
                int op = 1;
                while(op != 0)
                {
                    Console.Clear();
                    Console.WriteLine("[1] - Editar horario");
                    Console.WriteLine("[2] - Eliminar horario");
                    Console.WriteLine("[0] - Voltar atrás\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("[1] - Editar horário de médicos");
                            Console.WriteLine("[2] - Editar horário de enfermeiros");
                            Console.WriteLine("[3] - Editar horário de funcionários");
                            Console.WriteLine("[0] - Voltar a trás\n");
                            Console.Write("-> ");
                            int op1 = Int32.Parse(Console.ReadLine());

                            switch (op1)
                            {
                                case 1:
                                    EditarHorarioMedico(lista);
                                    break;
                                case 2:
                                    EditarHorarioEnfermeiro(lista);
                                    break;
                                case 3:
                                    EditarHorarioFuncionario(lista);
                                    break;
                                case 0:
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("[1] - Eliminar horário de médicos");
                            Console.WriteLine("[2] - Eliminar horário de enfermeiros");
                            Console.WriteLine("[3] - Eliminar horário de funcionários");
                            Console.WriteLine("[0] - Voltar a trás\n");
                            Console.Write("-> ");
                            int op2 = Int32.Parse(Console.ReadLine());

                            switch (op2)
                            {
                                case 1:
                                    EliminarHorarioMedico(lista);
                                    break;
                                case 2:
                                    EliminarHorarioEnfermeiro(lista);
                                    break;
                                case 3:
                                    EliminarHorarioFuncionario(lista);
                                    break;
                                case 0:
                                    break;
                            }
                            break;
                        case 0:
                            break;
                    }
                }
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

        // Editar Horarios

        internal static void EditarHorarioMedico(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarMedicos(lista);
            try
            {
                Console.Clear();
                Console.WriteLine("Editar horário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("Horário: ");
                lista[pos].Horario = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Horário editado com sucesso!");
                Thread.Sleep(1020);
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

        internal static void EditarHorarioEnfermeiro(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarEnfermeiros(lista);
            try
            {
                Console.Clear();
                Console.WriteLine("Editar horário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("Horário: ");
                lista[pos].Horario = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Horário editado com sucesso!");
                Thread.Sleep(1020);
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

        internal static void EditarHorarioFuncionario(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarFuncionarios(lista);
            try
            {
                Console.Clear();
                Console.WriteLine("Editar horário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("Horário: ");
                lista[pos].Horario = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Horário editado com sucesso!");
                Thread.Sleep(1020);
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

        // Fim Editar Horarios


        // Eliminar Horarios

        internal static void EliminarHorarioMedico(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarMedicos(lista);
            try
            {
                Console.Clear();
                lista[pos].Horario = "";
                Console.WriteLine("Horário de" +lista[pos].Pnome+ " "+lista[pos].Unome+ " removido com sucesso!");
                Thread.Sleep(1020);
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

        internal static void EliminarHorarioEnfermeiro(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarEnfermeiros(lista);
            try
            {
                Console.Clear();
                lista[pos].Horario = "";
                Console.WriteLine("Horário de" + lista[pos].Pnome + " " + lista[pos].Unome + " removido com sucesso!");
                Thread.Sleep(1020);
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

        internal static void EliminarHorarioFuncionario(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarFuncionarios(lista);
            try
            {
                Console.Clear();
                lista[pos].Horario = "";
                Console.WriteLine("Horário de" + lista[pos].Pnome + " " + lista[pos].Unome + " removido com sucesso!");
                Thread.Sleep(1020);
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

        // Fim Eliminar Horarios 

        //------------------------------------------------------\\

        internal static void VerTurnosTrabalhadores(List<Trabalhadores> lista)
        {
            Console.Clear();
            try
            {
                int op = 1;
                while(op != 0)
                {
                    Console.WriteLine("[1] - Ver turnos de médicos");
                    Console.WriteLine("[2] - Ver turnos de enfermeiros");
                    Console.WriteLine("[3] - Ver turnos de funcionários");
                    Console.WriteLine("[0] - Voltar atrás\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            VerTurnosMedicos(lista);
                            break;
                        case 2:
                            VerTurnosEnfermeiros(lista);
                            break;
                        case 3:
                            VerTurnosFuncionarios(lista);
                            break;
                        case 0:
                            break;
                    }
                }
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

        private static void VerTurnosMedicos(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarMedicos(lista);

                Console.Clear();

                Console.WriteLine("Turno de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lista[pos].Turno);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Clique em qualquer tecla");
                Console.ReadKey();
                Console.Clear();
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

        private static void VerTurnosEnfermeiros(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarEnfermeiros(lista);

                Console.Clear();

                Console.WriteLine("Turno de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lista[pos].Turno);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Clique em qualquer tecla");
                Console.ReadKey();
                Console.Clear();
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

        private static void VerTurnosFuncionarios(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarFuncionarios(lista);

                Console.Clear();

                Console.WriteLine("Turno de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(lista[pos].Turno);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------");
                Console.WriteLine("Clique em qualquer tecla");
                Console.ReadKey();
                Console.Clear();
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

        //------------------------------------------------------\\

        internal static void EditarEliminarTurnosTrabalhadores(List<Trabalhadores> lista)
        {
            Console.Clear();
            try
            {
                int op = 1;
                while(op != 0)
                {
                    Console.Clear();
                    Console.WriteLine("[1] - Editar turnos");
                    Console.WriteLine("[2] - Eliminar turnos");
                    Console.WriteLine("[0] - Voltar atrás\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("[1] - Editar turno de médicos");
                            Console.WriteLine("[2] - Editar turno de enfermeiros");
                            Console.WriteLine("[3] - Editar turno de funcionários");
                            Console.WriteLine("[0] - Voltar a trás\n");
                            Console.Write("-> ");
                            int op1 = Int32.Parse(Console.ReadLine());

                            switch (op1)
                            {
                                case 1:
                                    EditarTurnoMedico(lista);
                                    break;
                                case 2:
                                    EditarTurnoEnfermeiro(lista);
                                    break;
                                case 3:
                                    EditarTurnoFuncionario(lista);
                                    break;
                                case 0:
                                    break;
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("[1] - Eliminar turno de médicos");
                            Console.WriteLine("[2] - Eliminar turno de enfermeiros");
                            Console.WriteLine("[3] - Eliminar turno de funcionários");
                            Console.WriteLine("[0] - Voltar a trás\n");
                            Console.Write("-> ");
                            int op2 = Int32.Parse(Console.ReadLine());

                            switch (op2)
                            {
                                case 1:
                                    EliminarTurnoMedico(lista);
                                    break;
                                case 2:
                                    EliminarTurnoEnfermeiro(lista);
                                    break;
                                case 3:
                                    EliminarTurnoFuncionario(lista);
                                    break;
                                case 0:
                                    break;
                            }
                            break;
                        case 0:
                            break;
                    }
                }
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

        // Editar Turnos

        private static void EditarTurnoMedico(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarMedicos(lista);
                Console.Clear();
                Console.WriteLine("A editar turno de "+lista[pos].Pnome+" "+lista[pos].Unome);
                Console.Write("turnos: ");
                lista[pos].Turno = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Turno editado com sucesso!");
                Thread.Sleep(1020);
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

        private static void EditarTurnoEnfermeiro(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarEnfermeiros(lista);
                Console.Clear();
                Console.WriteLine("A editar turno de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("turnos: ");
                lista[pos].Turno = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Turno editado com sucesso!");
                Thread.Sleep(1020);
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

        private static void EditarTurnoFuncionario(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarFuncionarios(lista);
                Console.Clear();
                Console.WriteLine("A editar turno de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("turnos: ");
                lista[pos].Turno = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Turno editado com sucesso!");
                Thread.Sleep(1020);
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

        // Fim Editar Turnos

        // Eliminar Turnos

        private static void EliminarTurnoMedico(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarMedicos(lista);
            try
            {
                Console.Clear();
                lista[pos].Turno = "";
                Console.WriteLine("Turno de" + lista[pos].Pnome + " " + lista[pos].Unome + " removido com sucesso!");
                Thread.Sleep(1020);
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

        private static void EliminarTurnoEnfermeiro(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarEnfermeiros(lista);
            try
            {
                Console.Clear();
                lista[pos].Turno = "";
                Console.WriteLine("Turno de" + lista[pos].Pnome + " " + lista[pos].Unome + " removido com sucesso!");
                Thread.Sleep(1020);
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

        private static void EliminarTurnoFuncionario(List<Trabalhadores> lista)
        {
            Console.Clear();
            int pos = ApresentarFuncionarios(lista);
            try
            {
                Console.Clear();
                lista[pos].Turno = "";
                Console.WriteLine("Turno de" + lista[pos].Pnome + " " + lista[pos].Unome + " removido com sucesso!");
                Thread.Sleep(1020);
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

        // Fim Eliminar Turnos

        //------------------------------------------------------\\

        internal static void VerPacientes(List<Pacientes> lista)
        {
            try
            {
                Console.Clear();
                for(int i = 0;i < lista.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(lista[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("clique em qualquer tecla..");
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

        //------------------------------------------------------\\

        internal static void EditarEliminarPacientes(List<Pacientes> lista)
        {
            try
            {
                Console.Clear();
                int op = 1;
                while(op != 0)
                {
                    Console.WriteLine("[1] - Editar Paciente");
                    Console.WriteLine("[2] - Eliminar Paciente");
                    Console.WriteLine("[0] - Voltar atrás\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            EditarPaciente(lista);
                            break;
                        case 2:
                            EliminarPaciente(lista);
                            break;
                        case 0:
                            break;
                    }
                }
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

        // Editar Paciente

        private static void EditarPaciente(List<Pacientes> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarPacientes(lista);
                Console.Clear();
                Console.Write("Insira o Pº Nome: ");
                lista[pos].Pnome = Console.ReadLine();
                Console.Write("\nInsira o Uº Nome: ");
                lista[pos].Unome = Console.ReadLine();
                Console.WriteLine("D. Nascimento: ");
                Console.Write("\t\nDia: ");
                int dia = Int32.Parse(Console.ReadLine());
                Console.Write("\t\nMês: ");
                int mes = Int32.Parse(Console.ReadLine());
                Console.Write("\t\nAno: ");
                int ano = Int32.Parse(Console.ReadLine());
                lista[pos].Dnascimento = new DateTime(ano,mes,dia);
                Console.Write("\nIdade: ");
                lista[pos].Idade = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nMorada: ");
                lista[pos].Morada = Console.ReadLine();
                Console.Write("\nMarcações: ");
                lista[pos].Nummarcacoes = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Paciente editado com sucesso!");
                Thread.Sleep(1020);
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

        private static int ApresentarPacientes(List<Pacientes> lista)
        {
            Console.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Pacientes"))
                Console.WriteLine("[" + i + "] - " + lista[i].ToString());
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----------------------------------------");
            }
            Console.ForegroundColor = ConsoleColor.White;
            return Int32.Parse(Console.ReadLine());
        }

        // Fim editar Paciente

        // Eliminar Paciente
        private static void EliminarPaciente(List<Pacientes> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarPacientes(lista);
                Console.Clear();
                lista.RemoveAt(pos);
                Console.WriteLine("Paciente Eliminado..");
                Thread.Sleep(1020);
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

        //Fim Eliminar Paciente

        //------------------------------------------------------\\

        internal static void VerGabinetesSalas(List<Gabinetes> listaG,List<Salas>listaS)
        {
            try
            {
                Console.Clear();
                int op = 1;
                while(op != 0)
                {
                    Console.WriteLine("[1] - Ver Gabinetes");
                    Console.WriteLine("[2] - Ver Salas");
                    Console.WriteLine("[0] - Voltar atrás\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            VerGabines(listaG);
                            break;
                        case 2:
                            VerSalas(listaS);
                            break;
                        case 0:
                            break;
                    }

                }
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

        //Ver Gabinetes
        private static void VerGabines(List<Gabinetes> listaG)
        {
            try
            {
                Console.Clear();
                for(int i = 0; i < listaG.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(listaG[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Clique em qualquer tecla..");
                Console.ReadKey();
                Console.Clear();
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

        //Fim ver gabinetes

        // Ver Salas
        private static void VerSalas(List<Salas> listaS)
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < listaS.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(listaS[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Clique em qualquer tecla..");
                Console.ReadKey();
                Console.Clear();
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

        //Fim ver salas

        //------------------------------------------------------\\

        internal static void MudarSalario(List<Trabalhadores> lista)
        {
            try
            {
                int op = 1;
                while(op != 0)
                {
                    Console.Clear();
                    Console.WriteLine("[1] - Mudar salarios de médicos");
                    Console.WriteLine("[2] - Mudar salarios de enfermeiros");
                    Console.WriteLine("[3] - Mudar salarios de funcionários");
                    Console.WriteLine("[0] - Voltar atrás\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            MudarSalarioMedico(lista);
                            break;
                        case 2:
                            MudarSalarioEnfermeiro(lista);
                            break;
                        case 3:
                            MudarSalarioFuncionario(lista);
                            break;
                        case 0:
                            break;
                    }
                }
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

        private static void MudarSalarioMedico(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarMedicos(lista);
                Console.Clear();

                Console.WriteLine("A mudar salário de "+lista[pos].Pnome+" "+lista[pos].Unome);
                Console.Write("\nNovo salário: ");
                lista[pos].Salario = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Salário editado com sucesso!");
                Thread.Sleep(1020);
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

        private static void MudarSalarioEnfermeiro(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarEnfermeiros(lista);
                Console.Clear();

                Console.WriteLine("A mudar salário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("\nNovo salário: ");
                lista[pos].Salario = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Salário editado com sucesso!");
                Thread.Sleep(1020);
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

        private static void MudarSalarioFuncionario(List<Trabalhadores> lista)
        {
            try
            {
                Console.Clear();
                int pos = ApresentarFuncionarios(lista);
                Console.Clear();

                Console.WriteLine("A mudar salário de " + lista[pos].Pnome + " " + lista[pos].Unome);
                Console.Write("\nNovo salário: ");
                lista[pos].Salario = Int32.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Salário editado com sucesso!");
                Thread.Sleep(1020);
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

        //------------------------------------------------------\\

        internal static void MudarSalas(List<Salas> lista)
        {
            try
            {
                Console.Clear();
                int sala = ApresentarSalas(lista);

                Console.WriteLine("A mudar o médico da sala " + lista[sala].Numsala);
                Console.Write("\nNovo enfermeiro/a responsável: ");
                lista[sala].Enfermeiroresponsavel = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enfermeiro Responsável trocado com sucesso para "+lista[sala].Enfermeiroresponsavel);
                Thread.Sleep(1020);
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

        private static int ApresentarSalas(List<Salas> lista)
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Salas"))
                    Console.WriteLine("[" + i + "] - " + lista[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;

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
            return Int32.Parse(Console.ReadLine());
        }

        //------------------------------------------------------\\

        internal static void MudarGabinetes(List<Gabinetes> lista)
        {
            try
            {
                Console.Clear();
                int sala = ApresentarGabinetes(lista);

                Console.WriteLine("A mudar o médico da sala " + lista[sala].Numgabinete);
                Console.Write("\nNovo enfermeiro/a responsável: ");
                lista[sala].Medicoresponsavel = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enfermeiro Responsável trocado com sucesso para " + lista[sala].Medicoresponsavel);
                Thread.Sleep(1020);
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

        private static int ApresentarGabinetes(List<Gabinetes> lista)
        {
            try
            {
                Console.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    if (lista[i].GetType().ToString().Equals("TP_M11_Bernardo_Patrícia.Gabinetes"))
                    Console.WriteLine("[" + i + "] - " + lista[i].ToString());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ForegroundColor = ConsoleColor.White;

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
            return Int32.Parse(Console.ReadLine());
        }
    }
}