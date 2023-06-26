using System;
using System.Collections.Generic;

namespace AppOficina.Web.Models
{
    public class Veiculo : Entidade
    {
        public Guid ClienteId { get; set; }

        public string Matricula { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }


        /* EF Relations*/
        public Cliente Cliente { get; set; }
    
        public IEnumerable<Orcamento> Orcamentos { get; set; }

        public IEnumerable<OrdemServico> OrdensServicos { get; set; }
    }
}
