
namespace meuTp3
{
    class Ingresso
    {
        public string nomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        // Construtor
        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel) {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }
        //-----------------------------------------

        // Criação de métodos
        public void AlterarPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void AlterarQuantidade(int novaQuantidade)
        {
            quantidadeDisponivel = novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Show: {nomeDoShow}");
            Console.WriteLine($"Preço: R$ {preco}");
            Console.WriteLine($"Quantidade disponível: {quantidadeDisponivel}");
        }

        //-----------------------------------------

        // ==== Criação de métodos Getters e Setters ====

        // Getters
        public string GetNomeDoShow()
        {
            return nomeDoShow;
        }

        public double GetPreco()
        {
            return preco;
        }

        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        // Setters
        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
        }

        public void SetPreco(double novoPreco)
        {
            preco = novoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQtd)
        {
            quantidadeDisponivel = novaQtd;
        }
    }
}
