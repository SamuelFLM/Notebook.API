using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_test.Models
{
    public record UpdateNotebook(
        string Marca,
        string Modelo,
        int Ano,
        decimal Preco
    )
    {
        
    }
}