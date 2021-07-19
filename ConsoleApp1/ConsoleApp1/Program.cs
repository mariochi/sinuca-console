using System;
using ConsoleApp1.Classes;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Time.LoadTimes();
            Tabela.Iniciar();
            bool done = false;
            while(!done)
            {
                Menu();
                done = Decisao();
            }

            //Console.WriteLine("Hello World!");
        }

        static void Menu()
        {
            Console.WriteLine("Escolha o que deseja fazer:");
            Console.WriteLine("1- Criar nova tabela");
            Console.WriteLine("2- Adicionar time já existente a uma tabela");
            Console.WriteLine("3- Criar novo time para uma tabela");
            Console.WriteLine("4- Listar tabela e placar");
            Console.WriteLine("5- Listar times");
            Console.WriteLine("0- Encerrar programa");
        }
        static bool Decisao()
        {
            string option = Console.ReadLine();
            bool returnValue = false;
            try
            {
                switch (Int32.Parse(option))
                {
                    case 0:
                        returnValue = true;
                        break;
                    case 1:
                        CriarTabela();
                        break;
                    case 2:
                        AdicionaTimeTabela();
                        break;
                    case 3:
                        CriarTimeTabela();
                        break;
                    case 4:
                        ListarTabela();
                        break;
                    case 5:
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return returnValue;
        }
        static void CriarTabela()
        {
            string[] tmp = new string[3];
            Console.WriteLine("Digite a descrição da tabela");
            tmp[0] = Console.ReadLine();
            Console.WriteLine("Digite o prêmio");
            tmp[1] = Console.ReadLine();
            Console.WriteLine("Digite a pontuação da tabela");
            tmp[2] = Console.ReadLine();
            int points = 0;
            try
            {
                points = Int32.Parse(tmp[2]);
            }
            catch
            {
                points = 0;
            }
            Tabela t = new Tabela(tmp[0], tmp[1], points);
            if (t == null)
                Console.WriteLine("t é nulo");
            else
            {
                Console.WriteLine(t.ToString());
                Tabela.tabelas.Add(t);
            }



            
        }
        static void AdicionaTimeTabela()
        {
            Tabela tab = SelecionaTabela();
            Time time = SelecionaTime();
            tab.AdicionaTime(time);

        }
        static Tabela SelecionaTabela()
        {
            Console.WriteLine("Selecione qual tabela você deseja");
            for (int i = 0; i < Tabela.tabelas.Count ; i++) //Time t in Time.timesDisponiveis)
            {
                Console.WriteLine(i.ToString() + " - " + Tabela.tabelas[i].descricaoTabela);
            }
            var input = Console.ReadLine();
            try
            {
                int tab = Int32.Parse(input);
                if (tab < 0 || tab > Tabela.tabelas.Count)
                {
                    throw new Exception("Tabela fora do limite");
                }
                else
                {
                    return Tabela.tabelas[tab];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static Time SelecionaTime()
        {
            Console.WriteLine("Selecione qual time você deseja");
            for (int i = 0; i < Time.timesDisponiveis.Count; i++) //Time t in Time.timesDisponiveis)
            {
                Console.WriteLine(i.ToString() + " - " + Time.timesDisponiveis[i].nome);
            }
            var input = Console.ReadLine();
            try
            {
                int time = Int32.Parse(input);
                if (time < 0 || time > Time.timesDisponiveis.Count)
                {
                    throw new Exception("Time fora do limite");
                }
                else
                {
                    return Time.timesDisponiveis[time];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static void CriarTimeTabela()
        {
            Tabela tab = SelecionaTabela();
            tab.AdicionaTime(CriarTime());

        }
        static Time CriarTime()
        {
            string[] timeParams = new string[3];
            Console.WriteLine("Digite o nome do time:");
            timeParams[0] = Console.ReadLine();
            Console.WriteLine("Digite o nome do primeiro jogador:");
            timeParams[1] = Console.ReadLine();
            Console.WriteLine("Digite o nome do segundo jogador:");
            timeParams[2] = Console.ReadLine();

            Time t = new Time(timeParams[0], timeParams[1], timeParams[2]);
            Time.timesDisponiveis.Add(t);
            return t;

        }
        static void ListarTabela()
        {
            Tabela t = SelecionaTabela();

            t.Listar();
        }

    }
}
