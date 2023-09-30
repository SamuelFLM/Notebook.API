using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_test.Models
{
    public record AddNotebook(
        string Marca,
        string Modelo,
        int Ano,
        double Preco
    )
    {
        
    }
}