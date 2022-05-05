using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemadeVendasCsharp.BLL
{
    public class DadosCliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string usuario{ get; set; }
        public char PasswordChar { get; set; }
        public string contato { get; set; }
        public string endereco{ get; set; }
        public string sexo { get; set; }
        public string usuario_tipo { get; set; }
        public DateTime add_data { get; set; }
        public int add_porquem { get; set; }
    }
}
