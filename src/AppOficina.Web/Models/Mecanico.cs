using System;

namespace AppOficina.Web.Models
{
    public class Mecanico : Entidade
    {
        public Guid OrdemServicoId { get; set; }

        public string Nome { get; set; }


        /* EF Relations*/
        public OrdemServico OrdemServico { get; set; }
    }
}
