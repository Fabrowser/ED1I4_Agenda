using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contatos
    {

        public List<Contato> contatos { get; set; } = new List<Contato>();


        public bool adicionar(Contato c)
        {
            contatos.Add(c);
            return true;
            
        }

        public bool alterar(Contato c)
        {
            return false;
        }

        public bool remover(Contato c)
        {
            contatos.Remove(c);
            return true;
        }

        public string ListaContatos()
        {
            string lista = "";

            Console.WriteLine("---------------");
            Console.WriteLine("LISTA DE CONTATOS");
            Console.WriteLine("---------------");



            foreach (Contato contatos in contatos)
            {
              
                lista += contatos + "---------------" + "\n";

            }
            
            return lista; 
        }

        public Contato pesquisar(string email)
        {
            Contato contatoRetornado=null;

            foreach (Contato contato in contatos)
            {
                if(contato.email == email)
                {
                    contatoRetornado = contato;
                }
            }
            return contatoRetornado;
        }


    }
}
