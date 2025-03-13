namespace meuTp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            do {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("       MENU DE EXERCÍCIOS");
                Console.WriteLine("================================");

                Console.WriteLine("1 - Testar Classe Carro");
                Console.WriteLine("2 - Testar Classe Ingresso");
                Console.WriteLine("3 - Testar Classe Matrícula");
                Console.WriteLine("4 - Testar Classe Figuras");
                Console.WriteLine("0 - Sair");

                //--------------------------------------------
                Console.Write("\nDigite o número do exercício que deseja testar: ");
                string opcao = Console.ReadLine();

                if (int.TryParse(opcao, out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            CarroTeste.Executar();
                            break;
                        case 2:
                            AppIngresso.Executar();
                            break;
                        case 3:
                            MatriculaTeste.Executar();
                            break;
                        case 4:
                            TestaFiguras.Executar();
                            break;
                        case 0:
                            Console.WriteLine("\nSaindo...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida. Digite um número de 0 a 4");
                            break;
                    }
                }
                else {
                    Console.WriteLine("\nOpção inválida. Digite um número de 0 a 4.");
                }


            } while (escolha != 0);

        }
    }
}