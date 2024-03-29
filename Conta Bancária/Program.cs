﻿using Conta_Bancária.Controller;
using Conta_Bancária.Model;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Conta_Bancária
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Menu()
        {
            int opcao = 1;
            string sn, titular;
            int agencia = 0, tipo, aniversario, numero, numeroDestino;
            decimal saldo, limite, valor;

            ContaController contas = new();

            while (opcao != 9)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           $     *****           Banco Dawn Yarn            *****     $");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           $             1   Criar Conta                              $");
                Console.WriteLine("                           $             2   Listar Todas as Contas                   $");
                Console.WriteLine("                           $             3   Buscar Conta por Número                  $");
                Console.WriteLine("                           $             4   Atualizar Dados da Conta                 $");
                Console.WriteLine("                           $             5   Apagar Conta                             $");
                Console.WriteLine("                           $             6   Sacar                                    $");
                Console.WriteLine("                           $             7   Depositar                                $");
                Console.WriteLine("                           $             8   Transferir Valores Entre Contas          $");
                Console.WriteLine("                           $             9   Sair                                     $");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           $          Informe a Operação Que Deseja Realizar          $");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

                Console.ResetColor();

                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
                catch (FormatException)
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("Digite o número da agência: ");
                        agencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o nome do titular: ");
                        titular = Console.ReadLine()!;

                        Console.WriteLine("Digite o saldo da conta: ");
                        saldo = Convert.ToDecimal(Console.ReadLine());

                        do
                        {
                            Console.WriteLine("Digite o tipo da conta: ");
                            tipo = Convert.ToInt32(Console.ReadLine());
                        } while (tipo != 1 && tipo != 2);


                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite o limite da conta: ");
                                limite = Convert.ToDecimal(Console.ReadLine());

                                contas.Cadastrar(new ContaCorrente(contas.GerarNumero(), agencia, tipo, titular, saldo, limite));
                                break;

                            case 2:
                                Console.WriteLine("Digite o aniversario da conta: ");
                                aniversario = Convert.ToInt32(Console.ReadLine());

                                contas.Cadastrar(new ContaPoupanca(contas.GerarNumero(), agencia, tipo, titular, saldo, aniversario));
                                break;
                        }
                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 2:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("Listar todas as contas: ");
                        contas.ListarTodas();

                        KeyPress();
                        Console.ResetColor();
                        break;

                    case 3:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("Consultar a conta por número");
                        Console.Write("Digite o número: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        contas.ProcurarPorNumero(numero);

                        KeyPress();

                        Console.ResetColor();
                        break;

                    case 4:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        var conta = contas.BuscarNaCollection(numero);
                        if (conta is not null)
                        {

                            Console.WriteLine("Digite o número da agência: ");
                            agencia = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite o nome do titular: ");
                            titular = Console.ReadLine()!;

                            Console.WriteLine("Digite o saldo da conta: ");
                            saldo = Convert.ToDecimal(Console.ReadLine());

                            tipo = conta.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite o limite da conta: ");
                                    limite = Convert.ToDecimal(Console.ReadLine());

                                    contas.Atualizar(new ContaCorrente(numero, agencia, tipo, titular, saldo, limite));
                                    break;

                                case 2:
                                    Console.WriteLine("Digite o aniversario da conta: ");
                                    aniversario = Convert.ToInt32(Console.ReadLine());

                                    contas.Atualizar(new ContaPoupanca(numero, agencia, tipo, titular, saldo, aniversario));
                                    break;
                            }
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

                        KeyPress();

                        Console.ResetColor();
                        break;

                    case 5:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("Deletar uma conta");
                        Console.Write("Digite o número: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        contas.Deletar(numero);
                        KeyPress();

                        Console.ResetColor();
                        break;

                    case 6:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Digite o valor do saque: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        contas.Sacar(numero, valor);

                        KeyPress();

                        Console.ResetColor();
                        break;

                    case 7:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Digite o número da conta: ");
                        numero = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Digite o valor do depósito: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        contas.Depositar(numero, valor);
                        KeyPress();

                        Console.ResetColor();
                        break;

                    case 8:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.Write("Digite o número da conta de origem: ");
                        numero = Convert.ToInt32(Console.ReadLine());


                        Console.Write("Digite o número da conta de destino: ");
                        numeroDestino = Convert.ToInt32(Console.ReadLine());


                        Console.WriteLine("Digite o valor da tranferência: ");
                        valor = Convert.ToDecimal(Console.ReadLine());

                        contas.Transferir(numero, numeroDestino, valor);
                        KeyPress();

                        Console.ResetColor();
                        break;

                    case 9:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                        Console.WriteLine("                          +<><>                                                   <><>+");
                        Console.WriteLine("                          +<><>      Você deseja realmente sair do programa ?     <><>+");
                        Console.WriteLine("                          +<><>      [S]                ||                [N]     <><>+");
                        Console.WriteLine("                          +<><>                                                   <><>+");
                        Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                        sn = (Console.ReadLine())!.ToLower();

                        if (sn.Equals("n"))
                        {
                            Menu();
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                            Console.WriteLine("                          +<><>                                                   <><>+");
                            Console.WriteLine("                          +<><>        Obrigade por escolher o Dawn Yarn!º        <><>+");
                            Console.WriteLine("                          +<><>                                                   <><>+");
                            Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            Console.WriteLine("                                                                                       ");
                            KeyPress();
                            Sobre();
                            Console.ResetColor();
                        }
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                        Console.WriteLine("                          +<><>                                                   <><>+");
                        Console.WriteLine("                          +<><>             Essa opção não existe amigue!         <><>+");
                        Console.WriteLine("                          +<><>                                                   <><>+");
                        Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        Console.WriteLine("                                                                                       ");
                        KeyPress();
                        Console.ResetColor();
                        break;



                }

            }
        }

        static void Sobre()
        {
            Console.Clear();
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                       §<><><><><><><><><><><><><>*******<><><><><><><><><><><><><><><§");
            Console.WriteLine("                       § +                                                          + §");
            Console.WriteLine("                       § +       Projeto Desenvolvido por: Fernando Dias Costa      + §");
            Console.WriteLine("                       § +                                                          + §");
            Console.WriteLine("                       § +           github.com/Fertilesoil/ContaBancaria           + §");
            Console.WriteLine("                       § +                                                          + §");
            Console.WriteLine("                       §><><><><><><><><><><><><><*******><><><><><><><><><><><><><><>§");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("                                                                                       ");
        }

        static void Main(string[] args)
        {
            Menu();
        }

        static void KeyPress()
        {
            do
            {
                Console.Write("Pressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);

        }
    }
}

