using Conta_Bancária.Model;
using Conta_Bancária.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public void Cadastrar(Conta conta)
        {
            ListaContas.Add(conta);
            Console.WriteLine($"Sua conta {conta.GetNumero()} foi cadastrada com sucesso !");
        }

        public void Deletar(int numero)
        {
            throw new NotImplementedException();
        }
        public void ListarTodas()
        {
            foreach(var conta in ListaContas)
                { conta.Visualizar(); }
        }
        public void ProcurarPorNumero(int numero)
        {
            throw new NotImplementedException();
        }

        // Métodos Bancários
        public void Sacar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Depositar(int numero, decimal valor)
        {
            throw new NotImplementedException();
        }

        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor)
        {
            throw new NotImplementedException();
        }

        // Métodos Auxiliares
        public int GerarNumero()
        {
            return ++numero;
        }


    }
}
