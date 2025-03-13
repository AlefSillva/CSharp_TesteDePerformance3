
namespace meuTp3
{
    class CarroTeste
    {
        public static void Executar() 
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("    Instanciando objeto da classe Carro");
            Console.WriteLine("================================");

            // Instanciando um objeto da classe Carro
            Carro carro1 = new Carro("Hyundai", "Vermelho Chilli", 0);

            //--------------------------------------------

            // Exibindo informações do carro criado
            Console.WriteLine("\nInformações do carro criado:\n");

            Console.WriteLine("Marca: " + carro1.marca);
            Console.WriteLine("Cor: " + carro1.cor);
            Console.WriteLine("Velocidade: " + carro1.velocidade);
            Console.WriteLine("---------------------------------------------");

            //--------------------------------------------
            
            // Executando o método Acelerar()
            Console.WriteLine("\nExecutando o método de acelerar()...");
            Console.WriteLine("\nAcelerando o carro em 20 km/h...\n");
            carro1.Acelerar(20);

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Pressione qualquer tecla para voltar ao Menu Principal.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
