namespace Conta_Bancária
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 1;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Clear();    
                Console.WriteLine("                     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     $                         Banco                        $");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     $             1 - Criar Conta                          $");
                Console.WriteLine("                     $             2  - Listar Todas as Contas              $");
                Console.WriteLine("                     $             3 - Buscar Conta por Número              $");
                Console.WriteLine("                     $             4 - Atualizar Dados da Conta             $");
                Console.WriteLine("                     $             5 - Apagar Conta                         $");
                Console.WriteLine("                     $             6 - Sacar                                $");
                Console.WriteLine("                     $             7 - Depositar                            $");
                Console.WriteLine("                     $             8 - Transferir Valores Entre Contas      $");
                Console.WriteLine("                     $             9 - Sair                                 $");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     $              Entre com a opção desejada              $");
                Console.WriteLine("                     $                                                      $");
                Console.WriteLine("                     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;

                    case 2:
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
                        Console.WriteLine("Obrigado por usar nosso banco.");
                        Sobre();
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Essa opção não existe amigue!");
                        break;
                }

            } while (true);

            static void Sobre()
            {
                Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+       Projeto Desenvolvido por: Fernando Dias Costa       +");
                Console.WriteLine("+                                                           +");
                Console.WriteLine("+           github.com/Fertilesoil/ContaBancaria            +");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
        }
    }
}