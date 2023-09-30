using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_test.Entities
{
    public class Notebook
    {
        public int Id { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int MyProperty { get; private set; }
        public int Ano { get; private set; }
    }
}