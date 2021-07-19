using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Classes
{
    class Tabela
    {
        public static List<Tabela> tabelas;
        public List<TabelaTime> timesNaTabela;
        public string descricaoTabela;
        public string premioTabela;
        public int pontuacaoTabela;

        public Tabela(string descricao, string premio, int pontos)
        {
            descricaoTabela = descricao;
            premioTabela = premio;
            pontuacaoTabela = pontos;
            timesNaTabela = new List<TabelaTime>();
        }
        public static void Iniciar()
        {
            tabelas = new List<Tabela>();
        }
        public void AdicionaTime(Time t)
        {
            if(t == null)
            {
                Console.WriteLine("Time nulo, retorne");
            }
            TabelaTime tb = new TabelaTime();
            tb.pontos = 0;
            tb.time = t;
            if (!timesNaTabela.Contains(tb))
            {
                Console.WriteLine("Time adicionado com sucesso a tabela");
                timesNaTabela.Add(tb);
            }
            else
            {
                Console.WriteLine("Time já está na tabela, retornando");
            }
        }

        public void Listar()
        {
            timesNaTabela.Sort();
            Console.WriteLine("Descrição:");
            Console.WriteLine(descricaoTabela);
            Console.WriteLine("Prêmio:");
            Console.WriteLine(premioTabela);
            Console.WriteLine("Pontuação Maior da Tabela:");
            Console.WriteLine(pontuacaoTabela);
            Console.WriteLine();
            foreach(TabelaTime tt in timesNaTabela)
            {
                Console.WriteLine("Nome do time: " + tt.time.nome);
                Console.WriteLine("Pontuação: " + tt.pontos);
                Console.WriteLine();
            }

        }
    }
}
