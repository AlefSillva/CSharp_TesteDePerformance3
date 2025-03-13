namespace meuTp3
{
    // Declaração da classe Carro
    class Carro
    {
        public string marca;
        public string cor;
        public int velocidade;

        // Construtor
        public Carro(string marca, string cor, int velocidade)
        {
            this.marca = marca;
            this.cor = cor;
            this.velocidade = velocidade;
        }

        // Criação do método para acelerar o carro
        public void Acelerar(int incremento)
        {
            velocidade += incremento;

            Console.WriteLine($"O carro de cor {cor} da marca {marca}, acelerou para {velocidade} km/h.");
        }
    }

}
