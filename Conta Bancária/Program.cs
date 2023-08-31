using Conta_Bancária.Model;

namespace Conta_Bancária
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcao = 0;
            string sn;

            Conta conta1 = new Conta(1, 123, 1, "Galhardo", 1000000.00M);

            conta1.Visualizar();
            conta1.SetNumero(345);
            Console.WriteLine(conta1.GetNumero());

            conta1.Sacar(1000);

            conta1.Visualizar();

            conta1.Depositar(5000); 
            
            conta1.Visualizar();

        
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            inicio:
            while (opcao != 9)
            {
            
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
                
            }
            
            
            
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Criar Conta: ");
                        Console.ReadKey();
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
                        Console.WriteLine("                          +<><>      [Sim]              ||              [Não]     <><>+");
                        Console.WriteLine("                          +<><>                                                   <><>+");
                        Console.WriteLine("                          +<><><><><><><><><><><><><*******><><><><><><><><><><><><><>+");
                        sn = (Console.ReadLine())!.ToLower();

                        if (sn.Equals("nao") || sn.Equals("não") || sn.Equals("n"))
                        {
                         goto inicio;
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
        }
    }
}