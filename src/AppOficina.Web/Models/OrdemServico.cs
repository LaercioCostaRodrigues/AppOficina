using System;

namespace AppOficina.Web.Models
{
    public class OrdemServico : Entidade
    {
        public Guid VeiculoId { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataPrevisaoFim { get; set; }

        public string Descricao { get; set; }

        public Decimal Valor { get; set; }


        /* EF Relations*/
        public Veiculo Veiculo { get; set; }

        public Mecanico Mecanico { get; set; }
    }
}
