using Acess_API.Dao;
using Acess_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Nesta classe chamaremos os métodos da classe Dao para retornar para controllers.


namespace Acess_API.Repositorio
{
    public class DadosRepositorio
    {
        private readonly DaoDados _daoDados;

        public DadosRepositorio()
        {
            _daoDados = new DaoDados();
        }

        public List<Dados> GetDados
        {
            get
            {
                return _daoDados.GetDados();
            }
        }

        public void InserirDados(Dados dados)
        {
            _daoDados.InserDados(dados);

        }

        
    }
}
