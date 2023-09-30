using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_test.Entities
{
    public class Notebook
    {
        public Notebook(string marca, string modelo, int ano, decimal preco)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
        }
        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public decimal Preco { get; private set; }
    }
}