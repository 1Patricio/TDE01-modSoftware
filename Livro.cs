public class Livro{
    public string titulo;
    public string livro;
    public int anoPublicacao;

    public Livro(string titulo, string livro, int anoPublicacao){
        this.titulo = titulo;
        this.livro = livro;
        this.anoPublicacao = anoPublicacao;
    }

    public void exibirInformacoes(){
        Console.WriteLine("Titulo: " + titulo);
        Console.WriteLine("Livro: " + livro);
        Console.WriteLine("Ano de Publicação: " + anoPublicacao);
    }
}
