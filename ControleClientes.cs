using System;
using System.Collections.Generic;
using System.Text;

class Cliente
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public Cliente(string nome, string endereco, string telefone)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
    }

    public virtual void PagarImposto()
    {
        Console.WriteLine("Imposto pago pelo cliente com CPF/CNPJ.");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Endereço: {Endereco}, Telefone: {Telefone}";
    }
}

class PessoaFisica : Cliente
{
    public string CPF { get; set; }

    public PessoaFisica(string nome, string endereco, string telefone, string cpf)
        : base(nome, endereco, telefone)
    {
        CPF = cpf;
    }

    public override void PagarImposto()
    {
        Console.WriteLine($"Imposto pago pela pessoa física com CPF {CPF}.");
    }
}

class PessoaJuridica : Cliente
{
    public string CNPJ { get; set; }

    public PessoaJuridica(string nome, string endereco, string telefone, string cnpj)
        : base(nome, endereco, telefone)
    {
        CNPJ = cnpj;
    }

    public override void PagarImposto()
    {
        Console.WriteLine($"Imposto pago pela pessoa jurídica com CNPJ {CNPJ}.");
    }
}

class Program
{
    static void Main()
    {
        // Configurar a codificação do console para Unicode (UTF-8)
        Console.OutputEncoding = Encoding.UTF8;

        List<Cliente> listaDeClientes = new List<Cliente>();

        while (true)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Cadastrar Pessoa Física");
            Console.WriteLine("2. Cadastrar Pessoa Jurídica");
            Console.WriteLine("3. Listar Clientes");
            Console.WriteLine("4. Pagar Impostos");
            Console.WriteLine("5. Sair");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informe o nome da pessoa física:");
                    string nomePF = Console.ReadLine();

                    Console.WriteLine("Informe o endereço da pessoa física:");
                    string enderecoPF = Console.ReadLine();

                    Console.WriteLine("Informe o telefone da pessoa física:");
                    string telefonePF = Console.ReadLine();

                    Console.WriteLine("Informe o CPF da pessoa física:");
                    string cpf = Console.ReadLine();

                    Cliente pessoaFisica = new PessoaFisica(nomePF, enderecoPF, telefonePF, cpf);
                    listaDeClientes.Add(pessoaFisica);
                    Console.WriteLine("Pessoa física cadastrada com sucesso!");
                    break;

                case "2":
                    Console.WriteLine("Informe o nome da pessoa jurídica:");
                    string nomePJ = Console.ReadLine();

                    Console.WriteLine("Informe o endereço da pessoa jurídica:");
                    string enderecoPJ = Console.ReadLine();

                    Console.WriteLine("Informe o telefone da pessoa jurídica:");
                    string telefonePJ = Console.ReadLine();

                    Console.WriteLine("Informe o CNPJ da pessoa jurídica:");
                    string cnpj = Console.ReadLine();

                    Cliente pessoaJuridica = new PessoaJuridica(nomePJ, enderecoPJ, telefonePJ, cnpj);
                    listaDeClientes.Add(pessoaJuridica);
                    Console.WriteLine("Pessoa jurídica cadastrada com sucesso!");
                    break;

                case "3":
                    Console.WriteLine("Lista de Clientes:");
                    foreach (Cliente cliente in listaDeClientes)
                    {
                        Console.WriteLine(cliente);
                    }
                    break;

                case "4":
                    Console.WriteLine("Pagar Impostos:");

                    foreach (Cliente cliente in listaDeClientes)
                    {
                        cliente.PagarImposto();
                    }
                    break;

                case "5":
                    Console.WriteLine("Saindo do programa.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
