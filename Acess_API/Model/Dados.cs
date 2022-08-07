using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Esta classe é o modelo da nossa base de dados.

namespace Acess_API.Model
{
    public class Dados
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Clientes Tclientes { get; set; }
        public string Sexo { get; set; }
        public Clientes Sclientes { get; set; }

    }
}
