public class Livro{
    public string titulo;
    public string livro;
    public int anoPublicacao;

    public Livro(string titulo, string livro, int anoPublicacao){
        this.titulo = titulo;
        this.livro = livro;
        this.anoPublicacao = anoPublicacao;
    }

    public void exibirInformações(){
        console.WriteLine("Titulo: " + titulo);
        console.WriteLine("Livro: " + livro);
        console.WriteLine("Ano de Publicação: " + anoPublicacao);
    }
}
