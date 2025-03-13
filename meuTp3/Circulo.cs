

namespace meuTp3
{
    class Circulo
    {
        // Atributos
        double raio;

        //----------------------------------
        // Construtor
        public Circulo(double raio)
        {
            this.raio = raio;
        }

        //----------------------------------
        // Métodos
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(raio, 2);
        }
    }
}
