using System;

namespace AppOficina.Web.Models
{
    public class Endereco : Entidade
    {
        public Guid ClienteId { get; set; }

        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }


        /* EF Relations*/
        public Cliente Cliente { get; set; }
    }
}
