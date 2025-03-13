

namespace meuTp3
{
    class MatriculaTeste
    {
        public static void Executar()
        {
            Console.Clear();
            // Instanciando um objeto da classe Matricula
            Matricula matricula = new Matricula("Alef", "ADS", 123, "Ativa", "29/01/2024");

            Console.WriteLine("=================================================");
            Console.WriteLine("   INSTANCIANDO UM OBJETO DA CLASSE MATRÍCULA");
            Console.WriteLine("=================================================");

            // Exibindo as informações do objeto antes das alterações
            Console.WriteLine("\nInformações do objeto instanciado:\n");
            matricula.ExibirInformacoes();

            Console.WriteLine("-------------------------------------------------\n");


            // Trancando a matrícula
            Console.WriteLine("Trancando a matrícula...");
            matricula.Trancar();
            matricula.ExibirInformacoes();

            Console.WriteLine("-------------------------------------------------\n");

            // Reativando a matrícula
            Console.WriteLine("Reativando a matrícula...");
            matricula.Reativar();
            matricula.ExibirInformacoes();

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }
}
