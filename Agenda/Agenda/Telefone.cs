using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Telefone
    {

        public string tipo { get; set; }
        public string numero { get; set; }
        public bool principal { get; set; }

        public Telefone()
        {
        }

        public Telefone(string tipo, string numero, bool principal)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.principal = principal;
        }

     
    }
}
