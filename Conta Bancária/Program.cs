﻿using Conta_Bancária.Controller;
using Conta_Bancária.Model;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Conta_Bancária
{
    public class Program
    {
        static void Menu()
        {
            int opcao = 1;
            string sn, titular;
            int agencia = 0, tipo, aniversario;
            decimal saldo, limite;

            ContaController contas = new();


            ContaCorrente cc1 = new ContaCorrente(contas.GerarNumero(), 123, 1, "Bucéfalo", 1000000.00M, 1000.00M);
            contas.Cadastrar(cc1);

            ContaPoupanca cp2 = new ContaPoupanca(contas.GerarNumero(), 123, 2, "Bucéfalo", 1000000.00M, 25);
            contas.Cadastrar(cp2);


            while (opcao != 9)
            {
            
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                                                                                       ");
                Console.WriteLine("                           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                           $                                                          $");
                Console.WriteLine("                           $     *****            Banco Dawn Yarn           *****     $");
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
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
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
                        break;

                    case 2:

                        Console.WriteLine("Listar todas as contas: ");
                        contas.ListarTodas();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
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
                            Console.WriteLine("                          +<><>            Obrigado por usar nosso banco!         <><>+");
                            Console.WriteLine("                          +<><>                                                   <><>+");
                            Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                            Console.ReadKey();
                            Sobre();
                        }
                        break;

                    default:
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
                        Console.ReadKey();
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
        
    }
}