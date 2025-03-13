using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace meuTp3
{
    class AppIngresso
    {
        public static void Executar()
        {
            Console.Clear();
            
            Console.WriteLine("=================================================");
            Console.WriteLine("      Criando um objeto da classe Ingresso...    ");
            Console.WriteLine("=================================================\n");

            // Instanciando um objeto da classe Ingresso
            Ingresso showA7X = new Ingresso("Show do Avenged Sevenfold", 180, 1000);

            Console.WriteLine("Informações do ingresso criado:\n");
            Console.WriteLine("Nome do Show: " + showA7X.nomeDoShow);
            Console.WriteLine("Preço: R$ " + showA7X.preco);
            Console.WriteLine("Quantidade disponível: " + showA7X.quantidadeDisponivel);
            Console.WriteLine("-------------------------------------------------");
            //--------------------------------------------

            // Executando o método ExibirInformacoes()
            Console.WriteLine("\nExecutando o método ExibirInformacoes()...\n");
            Console.WriteLine("Informações do ingresso antes das alterações:\n");
                        
            showA7X.ExibirInformacoes();

            //--------------------------------------------

            int escolha;
            bool voltarAoMenuPrincipal = false;

            do {
                Console.WriteLine("\n=================================================");
                Console.WriteLine("       ALTERAR INFORMAÇÕES DO INGRESSO     ");
                Console.WriteLine("=================================================\n");

                Console.WriteLine("*** Escolha método de alteração que deseja visualizar ***\n");
                Console.WriteLine("1 - Visualizar AlterarPreco() e AlterarQuantidade()");
                Console.WriteLine("2 - Visualizar Getters e Setters");
                Console.WriteLine("3 - Voltar ao Menu Principal");
                Console.WriteLine("0 - Sair");

                Console.Write("\nDigite o número da opção desejada: ");
                string opcao = Console.ReadLine();

                if (!int.TryParse(opcao, out escolha))
                {
                    Console.WriteLine("\nOpção inválida. Digite 1, 2 ou 3.");
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        alterarComum();
                        break;
                    case 2:
                        alterarGeteSet();
                        break;
                    case 3:
                        Console.WriteLine("Retornando ao menu principal...");
                        voltarAoMenuPrincipal = true;
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Digite 1 ou 2");
                        break;
                }

                if (escolha == 3)
                {
                    return;
                }
            } while (escolha != 0);


            //-------------------------------------------------

            // Função para executar os métodos AlterarPreco() e AlterarQuantidade()
            void alterarComum()
            {
                Console.Clear();
                Console.WriteLine("\n==================================================================");
                Console.WriteLine("     Executando os métodos AlterarPreco() e AlterarQuantidade()");
                Console.WriteLine("==================================================================");

                // Alterando o preço e a quantidade de ingressos
                Console.WriteLine("\nAlterando o preço do ingresso para 200...");
                Console.WriteLine("Alterando a quantidade de ingressos para 500...");

                showA7X.AlterarPreco(200);
                showA7X.AlterarQuantidade(500);
                Console.WriteLine("---------------------------------------------------------\n");

                //--------------------------------------------

                // Executando o método ExibirInformacoes() após as alterações

                Console.WriteLine("*** Informações do ingresso após as alterações ***\n");
                showA7X.ExibirInformacoes();

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu anterior");
                Console.ReadKey();
                Console.Clear();
            }

            //-------------------------------------------------

            // Função para executar os métodos Getters e Setters
            void alterarGeteSet() 
            {
                Console.Clear();
                Console.WriteLine("\n====================================================");
                Console.WriteLine("     Executando os métodos Getters e Setters...    ");
                Console.WriteLine("====================================================");

                // Exibindo informações do ingresso usando os métodos Getters
                Console.WriteLine("\n*** Informações do ingresso usando os métodos GETTERS - Antes das alterações ***\n");

                Console.WriteLine("Nome do Show: " + showA7X.GetNomeDoShow());
                Console.WriteLine("Preço: R$ " + showA7X.GetPreco());
                Console.WriteLine("Quantidade disponível: " + showA7X.GetQuantidadeDisponivel());

                Console.WriteLine("---------------------------------------------");

                //--------------------------------------------

                Console.WriteLine("\n*** Alterando as informações usando os métodos SETTERS ***");
                
                Console.WriteLine("\nAlterando o nome do show para 'Show do Avenged Sevenfold - 2025'...");
                Console.WriteLine("Alterando o preço do ingresso para 300...");
                Console.WriteLine("Alterando a quantidade de ingressos para 300...");

                // Alterando as informações do ingresso usando os métodos Setters
                showA7X.SetNomeDoShow("Show do Avenged Sevenfold - 2025");
                showA7X.AlterarPreco(300);
                showA7X.AlterarQuantidade(300);

                Console.WriteLine("---------------------------------------------");

                //--------------------------------------------

                // Exibindo as informações do ingresso após as alterações
                Console.WriteLine("\n*** Informações do ingresso após as alterações ***\n");

                Console.WriteLine("Nome do Show: " + showA7X.GetNomeDoShow());
                Console.WriteLine("Preço: R$ " + showA7X.GetPreco());
                Console.WriteLine("Quantidade disponível: " + showA7X.GetQuantidadeDisponivel());

                Console.WriteLine("\nPressione um tecla para voltar ao menu anterior");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
