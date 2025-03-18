public class Voo{
    public string numeroVoo;
    public string companhia;
    public string origem;
    public string destino;
    public DateTime HoraSaida;

public Voo(string numeroVoo, string companhia, string origem, string destino, DateTime HoraSaida){
    this.numeroVoo = numeroVoo;
    this.companhia = companhia;
    this.origem = origem;
    this.destino = destino;
    this.HoraSaida = HoraSaida;
}

public void exibirInformacoes(){
    console.WriteLine("Numero do Voo: " + numeroVoo);
    console.WriteLine("Companhia: " + companhia);
    console.WriteLine("Origem: " + origem);
    console.WriteLine("Destino: " + destino);
    console.WriteLine("Hora de Saída: " + HoraSaida);
}