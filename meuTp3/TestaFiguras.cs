namespace meuTp3
{
    class TestaFiguras
    {
        public static void Executar()
        {
            // Instanciando objetos
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("    TESTE DAS CLASSES DE FIGURAS");
            Console.WriteLine("=================================");

            // Criando um círculo com raio 3.0
            Circulo circulo = new Circulo(3.0);
            double areaCirculo = circulo.CalcularArea();
            Console.WriteLine($"Área do Círculo com raio 3.0: {areaCirculo:F2}");

            // Criando uma esfera com raio 5.0
            Esfera esfera = new Esfera(5.0);
            double volumeEsfera = esfera.CalcularVolume();
            Console.WriteLine($"Volume da Esfera com raio 5.0: {volumeEsfera:F2}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
