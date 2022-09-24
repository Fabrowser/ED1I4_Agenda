


using Agenda;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {

        Contatos contatos = new Contatos();

        string opcao = "";


        while (opcao != "0")
        {

            Console.WriteLine("Digite a Opção Desejada" + "\n\n" +
                "0.Sair " + "\n" + "1.Adicionar contato" + "\n" + "2.Pesquisar contato" + "\n" + "3.Alterar contato " +
                "\n" + "4.Remover contato" + "\n" + "5.Listar contatos");

            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    {

                        break;
                    }
                case "1":
                    {
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Data Nascimento[DD/MMM/YYY]: ");
                        DateTime dtNasc = DateTime.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade de telefones: ");
                        int qt = int.Parse(Console.ReadLine());

                        List<Telefone> telefones = new List<Telefone>();

                        for (int i = 0; i < qt; i++)
                        {

                            Console.Write("Tipo: ");
                            string tip = Console.ReadLine();

                            Console.Write("Telefone " + i + 1 + ":");
                            string numero = Console.ReadLine();

                            Console.Write("Telefone Principal ? [S/N]: ");

                            string principal = "";
                            principal = Console.ReadLine();
                            bool princ;

                            if (principal == "s" | principal == "S")
                            {
                                princ = true;
                            }
                            else
                            {
                                princ = false;
                            }
                            Telefone tel = new Telefone(tip, numero, princ);
                            telefones.Add(tel);
                        }

                        Console.WriteLine(contatos.adicionar(new Contato(email, nome, dtNasc, telefones)) ? "Adicionou" : "Não adicionou");
                        break;
                    }

                case "2":
                    {
                        Console.WriteLine("Digite o email: ");
                        string email = Console.ReadLine();
                        Contato contatoEncontrato;
                        contatoEncontrato = contatos.pesquisar(email);

                        if (contatoEncontrato != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("TELEFONES ENCONTRADOS: ");
                            Console.WriteLine("---------------------");
                            Console.WriteLine();
                            Console.WriteLine(contatoEncontrato.ListaTelefonesDoContato());
                        }
                        else
                        {
                            Console.WriteLine("CONTATO NÃO ENCONTRADO");
                        }
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Digite o email: ");
                        string email = Console.ReadLine();
                        Contato contatoEncontrado = contatos.pesquisar(email);
                        if (contatoEncontrado != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Contato Encontrato: " + contatos.ToString());
                            Console.WriteLine("Add Telefone: ");
                        }



                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Digite o email: ");
                        string email = Console.ReadLine();
                        if (contatos.remover(contatos.pesquisar(email)))
                        {
                            Console.WriteLine("REMOVIDO COM SUCESSO " + "\n");
                        }
                        else
                        {
                            Console.WriteLine("CONTATO NÃO ENCONTRADO");
                        }

                        break;
                    }
                case "5":
                    {
                        Console.WriteLine(contatos.ListaContatos());
                        break;
                    }

                default:
                    {
                        break;
                    }
            }

        }



    }
}