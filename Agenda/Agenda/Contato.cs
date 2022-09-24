using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {


        public string email { get; set; }
        public string nome { get; set; }
        public DateTime dtNasc { get; set; }
        public List<Telefone> Telefones { get; set; } = new List<Telefone>();


        public Contato(string email, string nome, DateTime dtNasc, List<Telefone> telefones)
        {
            this.email = email;
            this.nome = nome;
            this.dtNasc = dtNasc;
            Telefones = telefones;
        }

        public int getIdade()
        {
            DateTime datanascimento = dtNasc;//data de nascimento
            DateTime hoje = DateTime.Now;//hoje

            TimeSpan ts = hoje.Subtract(datanascimento);
            DateTime periodo = new DateTime(ts.Ticks);
            return periodo.Year - 1;
        }


        public void AdicionarTelefone(Telefone t)
        {

            
            

        }

        public string getTelefonePrincipal()
        {
            return "";
        }

        public string ListaTelefonesDoContato()
        {
            string tels = "";
            foreach (Telefone telefone in Telefones)
            {
                tels += telefone.numero + "\n";

            }

            return tels;
        }

        public override string ToString()
        {
            return "Nome: " + nome + "\n" +
            "Email: " + email + "\n\n" +
            "Telefones: " + "\n" +  ListaTelefonesDoContato() + "\n" +
            "idade: " + getIdade() + "\n";
        }

        
    }
}
