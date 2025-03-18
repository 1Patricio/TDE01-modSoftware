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
    Console.WriteLine("Numero do Voo: " + numeroVoo);
    Console.WriteLine("Companhia: " + companhia);
    Console.WriteLine("Origem: " + origem);
    Console.WriteLine("Destino: " + destino);
    Console.WriteLine("Hora de Saída: " + HoraSaida);
}
}