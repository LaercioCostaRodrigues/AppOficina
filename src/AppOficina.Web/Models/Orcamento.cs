using System;

namespace AppOficina.Web.Models
{
    public class Orcamento : Entidade
    {
        public Guid VeiculoId { get; set; }

        public DateTime Data { get; set; }

        public DateTime Hora { get; set; }


        /* EF Relations*/
        public Veiculo Veiculo { get; set; }
    }
}
