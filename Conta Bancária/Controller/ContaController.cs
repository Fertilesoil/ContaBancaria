using Conta_Bancária.Model;
using Conta_Bancária.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancária.Controller
{
    public class ContaController : IContarepository
    {
        private readonly List<Conta> ListaContas = new();
        int numero = 0;


        // Métodos Crud
        public void Atualizar(Conta conta)
        {
            var buscaConta = BuscarNaCollection(conta.GetNumero());
            if (buscaConta != null)
            {
                var index = ListaContas.IndexOf(buscaConta);
                ListaContas[index] = conta;
                Console.WriteLine($"A conta {conta.GetNumero()} foi atualizada com sucesso !!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #><---          A conta {0} não foi encontrada!          ---><#", numero);
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.ResetColor();
            }
        }

        public void Cadastrar(Conta conta)
        {
            ListaContas.Add(conta);
            Console.WriteLine($"Sua conta {conta.GetNumero()} foi cadastrada com sucesso !");
        }

        public void Deletar(int numero)
        {

            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (ListaContas.Remove(conta) == true)
                    Console.WriteLine($"A conta {numero} foi apagada com sucesso");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #><---          A conta {0} não foi encontrada!          ---><#", numero);
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
            }
        }
        public void ListarTodas()
        {
            foreach (var conta in ListaContas)
            { conta.Visualizar(); }
        }
        public void ProcurarPorNumero(int numero)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
                conta.Visualizar();
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #><---          A conta {0} não foi encontrada!          ---><#", numero);
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
            }
        }

        // Métodos Bancários
        public void Sacar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                if (conta.Sacar(valor) == true)
                    Console.WriteLine($"O saque na conta {numero} foi efetuado com sucesso!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #><---          A conta {0} não foi encontrada!          ---><#", numero);
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
            }
        }

        public void Depositar(int numero, decimal valor)
        {
            var conta = BuscarNaCollection(numero);

            if (conta is not null)
            {
                conta.Depositar(valor);
                Console.WriteLine($"O depósito na conta {numero} foi efetuado com sucesso!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #><---          A conta {0} não foi encontrada!         ---><#", numero);
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
            }
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            var contaOrigem = BuscarNaCollection(numeroOrigem);
            var contaDestino = BuscarNaCollection(numeroDestino);

            if (contaOrigem is not null && contaDestino is not null)
            {
                if (contaOrigem.Sacar(valor) == true) 
                {
                    contaDestino.Depositar(valor);
                }
                    Console.WriteLine($"A transferencia na conta foi efetuado com sucesso!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #><----        Uma ou mais contas não existem !        ---><#");
                Console.WriteLine("                           #<><>                                                   <><>#");
                Console.WriteLine("                           #############################################################");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
            }
        }

        // Métodos Auxiliares
        public int GerarNumero()
        {
            return ++numero;
        }

        // Método para buscar um objeto Conta através do número da conta
        public Conta? BuscarNaCollection(int numero)
        {
            foreach (var conta in ListaContas)
            {
                if (conta.GetNumero() == numero)
                    return conta;
            }
            return null;
        }

    }
}
