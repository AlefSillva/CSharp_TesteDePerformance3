namespace meuTp3
{
    class Esfera
    {
        // Atributo
        double raio;

        //----------------------------------
        // Construtor
        public Esfera(double raio)
        {
            this.raio = raio;
        }

        //----------------------------------
        // Métodos
        public double CalcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
        }

    }
}
