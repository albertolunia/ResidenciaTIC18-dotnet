

class Veiculo{
    string modelo;
    DateTime ano;
    string cor;

    public Veiculo()
    {
    }

    public Veiculo(string modelo, DateTime ano, string cor){
        this.modelo = modelo;
        this.ano = ano;
        this.cor = cor;
    }

    public void toString(){
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Ano: " + ano);
        Console.WriteLine("Cor: " + cor);
    }

    public static void Main(string[] args)
    {
        Veiculo tesla = new();

        tesla.modelo = "Model S";
        tesla.ano = new DateTime(2021, 1, 1);
        tesla.cor = "Branco";

        tesla.toString();
    }
}