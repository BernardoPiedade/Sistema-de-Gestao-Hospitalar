using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace TP_M11_Bernardo_Patrícia
{
    class MainClass
    {
        static List<Trabalhadores> listaTrabalhadores = new List<Trabalhadores>();
        static List<Gabinetes> listaGabinetes = new List<Gabinetes>();
        static List<Salas> listaSala = new List<Salas>();
        static List<Pacientes> listaPacientes = new List<Pacientes>();

        public static void Main(string[] args)
        {
            //Lista Trabalhadores

            //Médicos -> Especialização, Gabinete, pnome, unome, datanascimento, idade, morada, horario, salario, turno
            listaTrabalhadores.Add(new Medicos("Neurocirugião",3,"Emanuel","Tulipa",new DateTime(1976,08,10),43,"Rua do morro, 12","09:00-14:00,15:30-21:00",12000,"Diurno"));

            //Enfermeiros -> cargo, sala, pnome, unome, datanascimento,idade,morada,horario,salario,turno
            //listaTrabalhadores.Add(new Enfermeiros("", ,"","", new DateTime, ,"","", ,""));

            //Funcionário -> cargo, pnome, unome, datanascimento,idade,morada,horario,salario,turno
            //listaTrabalhadores.Add(new Funcionarios("","","",new DateTime, ,"","", ,""));


            //Fim Lista Trabalhadores

            //Lista Gabinetes

            listaGabinetes.Add(new Gabinetes(3,"Emanuel Tulipa","Médico"));

            //Fim Lista Gabinetes

            //Lista Sala

            listaSala.Add(new Salas("Sala de Tratamentos",1,""));

            //Fim Lista Sala

            //Lista Pacientes

            //Pacientes -> pnome, unome, idade, dnascimento, nummarcacoes, morada
            listaPacientes.Add(new Pacientes("Bernardo", "Piedade", 18, new DateTime(2000, 04, 15), 0, "Rua Alta do Moinho"));

            //Fim lista 


            Console.Title = "Hospital HESTEL - Bem-vindo";

            Console.WriteLine("A ligar a sistema..");
            Thread.Sleep(1020);
            Console.WriteLine("A carregar dados..");
            Thread.Sleep(1050);
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\tBem vindo");
            Thread.Sleep(1000);
            PainelLogin();
        }

        //-----------------------------------------------------------------\\

        //Painel Login

        public static void PainelLogin()
        {
            Console.Title = "Hospital HESTEL - Login";

            try
            {
                Console.Clear();
                Console.WriteLine("Quem está a visitar a base de dados?");
                Console.WriteLine("[1] - Admin");
                Console.WriteLine("[2] - Médico");
                Console.WriteLine("[3] - Enfermeiro");
                Console.WriteLine("[4] - Funcionário");
                Console.WriteLine("[5] - Paciente - Consultas");
                Console.WriteLine("[0] - Sair\n");
                Console.Write("-> ");
                int op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        PainelAdmin();
                        break;
                    case 2:
                        PainelMedico();
                        break;
                    case 3:
                        PainelEnfermeiro();
                        break;
                    case 4:
                        PainelFuncionario();
                        break;
                    case 5:
                        PainelPaciente();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
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

        //Fim painel login

        //Painel Admin
        public static void PainelAdmin()
        {
            Console.Title = "Hospital HESTEL - Painel Admin";
            Console.Clear();
            Console.WriteLine("Bem-vindo Admin..");
            Thread.Sleep(1020);

            int op = 1;

            while (op != 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("[1]  - Ver trabalhadores");
                    Console.WriteLine("[2]  - Editar trabalhadores");
                    Console.WriteLine("[3]  - Ver horários de trabalhadores");
                    Console.WriteLine("[4]  - Editar/Eliminar horários de trabalhadores");
                    Console.WriteLine("[5]  - Ver turnos de trabalhadores");
                    Console.WriteLine("[6]  - Editar/Eliminar turnos de trabalhadores");
                    Console.WriteLine("[7]  - Ver pacientes");
                    Console.WriteLine("[8]  - Editar/Eliminar pacientes");
                    Console.WriteLine("[9]  - Gabinetes/Salas");
                    Console.WriteLine("[10] - Mudar salario");
                    Console.WriteLine("[11] - Mudar salas");
                    Console.WriteLine("[12] - Mudar gabinetes");
                    Console.WriteLine("[0] - Terminar sessão\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Admin.VerTrabalhadores(listaTrabalhadores);
                            break;
                        case 2:
                            Admin.EditarTrabalhadores(listaTrabalhadores);
                            break;
                        case 3:
                            Admin.VerHorarioTrabalhadores(listaTrabalhadores);
                            break;
                        case 4:
                            Admin.EditarEliminarHorariosTrabalhadores(listaTrabalhadores);
                            break;
                        case 5:
                            Admin.VerTurnosTrabalhadores(listaTrabalhadores);
                            break;
                        case 6:
                            Admin.EditarEliminarTurnosTrabalhadores(listaTrabalhadores);
                            break;
                        case 7:
                            Admin.VerPacientes(listaPacientes);
                            break;
                        case 8:
                            Admin.EditarEliminarPacientes(listaPacientes);
                            break;
                        case 9:
                            Admin.VerGabinetesSalas(listaGabinetes,listaSala);
                            break;
                        case 10:
                            Admin.MudarSalario(listaTrabalhadores);
                            break;
                        case 11:
                            Admin.MudarSalas(listaSala);
                            break;
                        case 12:
                            Admin.MudarGabinetes(listaGabinetes);
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("A terminar sessão..");
                            Thread.Sleep(1000);
                            PainelLogin();
                            break;

                    }

                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção não existe.");
                    Thread.Sleep(1020);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
        }
        //Fim do painel Admin

        //Painel Médico
        public static void PainelMedico()
        {
            Console.Title = "Hospital HESTEL - Painel Médico";
            Console.Clear();
            Console.WriteLine("Bem-vindo Médico..");
            Thread.Sleep(1020);

            int op = 1;

            while (op != 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("[1]  - Ver médicos");
                    Console.WriteLine("[2]  - Ver horário");
                    Console.WriteLine("[3]  - Marcar consultas");
                    Console.WriteLine("[4]  - Passar receitas");
                    Console.WriteLine("[5]  - Ver turnos");
                    Console.WriteLine("[6]  - Ver pacientes");
                    Console.WriteLine("[7]  - Ver Gabinetes / Salas");
                    Console.WriteLine("[8]  - Imprimir receitas");
                    Console.WriteLine("[0] - Terminar sessão\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Medico.VerMedicos(listaTrabalhadores);
                            break;
                        case 2:
                            Medico.VerHorario(listaTrabalhadores);
                            break;
                        case 3:
                           //Medico.MarcarConsultas(listaTrabalhadores);
                            break;
                        case 4:
                            //Medico.PassarReceitas(listaTrabalhadores);
                            break;
                        case 5:
                            Medico.VerTurnos(listaTrabalhadores);
                            break;
                        case 6:
                            Admin.VerPacientes(listaPacientes);
                            break;
                        case 7:
                            Admin.VerGabinetesSalas(listaGabinetes, listaSala);
                            break;
                        case 8:
                            //Medico.ImprimirReceitas(listaTrabalhadores);
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("A terminar sessão..");
                            Thread.Sleep(1000);
                            PainelLogin();
                            break;


                    }

                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção não existe.");
                    Thread.Sleep(1020);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
        }

        //Fim Painel Médico


        //Painel Enfermeiro
        public static void PainelEnfermeiro()
        {
            Console.Title = "Hospital HESTEL - Painel Enfermeiro";
            Console.Clear();
            Console.WriteLine("Bem-vindo Enfermeiro..");
            Thread.Sleep(1020);

            int op = 1;

            while (op != 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("[1]  - Ver enfermeiros");
                    Console.WriteLine("[2]  - Ver horário");
                    Console.WriteLine("[3]  - Marcar consultas");
                    Console.WriteLine("[4]  - Passar receitas");
                    Console.WriteLine("[5]  - Ver turnos");
                    Console.WriteLine("[6]  - Ver pacientes");
                    Console.WriteLine("[7]  - Ver Gabinetes / Salas");
                    Console.WriteLine("[8]  - Imprimir receitas");
                    Console.WriteLine("[0] - Terminar sessão\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Enfermeiro.VerEnfermeiros(listaTrabalhadores);
                            break;
                        case 2:
                            Enfermeiro.VerHorario(listaTrabalhadores);
                            break;
                        case 3:
                            //Enfermeiro.MarcarConsultas(listaTrabalhadores);
                            break;
                        case 4:
                            //Enfermeiro.PassarReceitas(listaTrabalhadores);
                            break;
                        case 5:
                            Enfermeiro.VerTurnos(listaTrabalhadores);
                            break;
                        case 6:
                            Admin.VerPacientes(listaPacientes);
                            break;
                        case 7:
                            Admin.VerGabinetesSalas(listaGabinetes, listaSala);
                            break;
                        case 8:
                            //Enfermeiro.ImprimirReceitas(listaTrabalhadores);
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("A terminar sessão..");
                            Thread.Sleep(1000);
                            PainelLogin();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção não existe.");
                    Thread.Sleep(1020);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
        }

        //Fim Painel Enfermeiro

        //Painel Funcionário
        public static void PainelFuncionario()
        {
            Console.Title = "Hospital HESTEL - Painel Funcionário";
            Console.Clear();
            Console.WriteLine("Bem-vindo Funcionário..");
            Thread.Sleep(1020);

            int op = 1;
            while(op != 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("[1] - Ver funcionários");
                    Console.WriteLine("[2] - Ver horario de funconários");
                    Console.WriteLine("[3] - Ver trabalho proposto");
                    Console.WriteLine("[0] - Terminar sessão\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Funcionario.VerFuncionarios(listaTrabalhadores);
                            break;
                        case 2:
                            Funcionario.VerHorarioFuncionarios(listaTrabalhadores);
                            break;
                        case 3:
                            Funcionario.VerTrabalhoProposto(listaTrabalhadores);
                            break;
                        case 0:
                            PainelLogin();
                            break;
                    }
                }
                catch(Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção não existe.");
                    Thread.Sleep(1020);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
        }

        //Fim Painel Funcionário

        //Painel Paciente

        public static void PainelPaciente()
        {
            Console.Title = "Hospital HESTEL - Painel Paciente";
            Console.Clear();
            Console.WriteLine("Bem-vindo Paciente..");
            Thread.Sleep(1020);

            int op = 1;

            while (op != 0)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("[1] - Marcar consulta");
                    Console.WriteLine("[0] - Terminar sessão\n");
                    Console.Write("-> ");
                    op = Int32.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            //Paciente.MarcarConsulta(listaTrabalhadores);
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine("A terminar sessão..");
                            Thread.Sleep(1000);
                            PainelLogin();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção não existe.");
                    Thread.Sleep(1020);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
        }

        //Fim painel paciente
    }
}
