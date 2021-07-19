using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ConsoleApp1.Classes
{
    class Time
    {
        public static List<Time> timesDisponiveis;
        public string nome;
        public string jogador1;
        public string jogador2;
        public static string fileName = "times.json";

        public static void LoadTimes()
        {
            timesDisponiveis = new List<Time>();
            //Para fins de demonstração, times iniciais serão hardcode
            Time t1 = new Time("Time1", "João", "Alberto");
            Time t2 = new Time("Auto Glória", "Bene", "Roberto");
            timesDisponiveis.Add(t1);
            timesDisponiveis.Add(t2);

        }


        public Time(string _nome, string _jogador1, string _jogador2)
        {
            nome = _nome;
            jogador1 = _jogador1;
            jogador2 = _jogador2;
        }
    }
}
