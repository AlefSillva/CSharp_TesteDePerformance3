

namespace meuTp3
{
    class Matricula
    {
        // Atributos
        public string nomeDoAluno;
        public string curso;
        public int numeroMatricula;
        public string situacao;
        public string dataInicial;

        //--------------------------------------------
        // Construtor
        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            this.nomeDoAluno = nomeDoAluno;
            this.curso = curso;
            this.numeroMatricula = numeroMatricula;
            this.situacao = situacao;
            this.dataInicial = dataInicial;
        }

        //--------------------------------------------
        // Métodos
        public void Trancar()
        {
            situacao = "Trancada";
        }

        public void Reativar()
        {
            situacao = "Ativa";
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Nome do aluno: " + nomeDoAluno);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Situação atual: " + situacao);
            Console.WriteLine("Data de início: " + dataInicial);
        }
    }
}
