public class Praia{
    public string nome;
    public string localicazao;
    public float temperaturaMedia;
    public Boolean temQuiosque;


    public Praia(string nome, string localicazao, float temperaturaMedia, Boolean temQuiosque){
        this.nome = nome;
        this.localicazao = localicazao;
        this.temperaturaMedia = temperaturaMedia;
        this.temQuiosque = temQuiosque;
    }

    public void exibirInformacoes(){
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Localicazao: " + localicazao);
        Console.WriteLine("Temperatura Média: " + temperaturaMedia);
        Console.WriteLine("Tem Quiosque: " + temQuiosque);
    }
}