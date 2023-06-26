using System.Collections;
using System.Collections.Generic;

namespace AppOficina.Web.Models
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }

        public string TelefoneFixo { get; set; }

        public string TelefoneMovel { get; set; }

        public string Email { get; set; }

        public TipoCliente TipoCliente { get; set; }

        public string CPF_CNPJ { get; set; }

        public Endereco Endereco { get; set; }

        /* EF Relations*/
        public IEnumerable<Veiculo> Veiculos { get; set; }
    }


}

