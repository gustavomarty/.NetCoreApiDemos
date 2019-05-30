using System;
using System.Collections.Generic;

namespace Demo.Data
{
    public class Pessoa
    {
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public static List<Pessoa> _pessoas = new List<Pessoa>();

        public int Id { get; set; }
        public string Nome { get; set; }

        public static void generate(int quantidade)
        {
            for(int i = 0; i < quantidade;  i++)
                _pessoas.Add(new Pessoa(_pessoas.Count + 1, $"Nome da pessoa {_pessoas.Count + 1}"));
        }
    }
}
