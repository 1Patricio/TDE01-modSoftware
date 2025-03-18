namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954);
            livro.exibirInformacoes();

            Praia praia = new Praia("Copacabana", "Rio de Janeiro", 30, true);
            praia.exibirInformacoes();

            Voo voo = new Voo("123", "Gol", "São Paulo", "Rio de Janeiro", new DateTime(2021, 12, 31, 23, 59, 59));
            voo.exibirInformacoes();
        }
    }
}
