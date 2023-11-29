

class Veiculo{
    public string Modelo {get; set;}
    public DateTime Ano {get; set;}
    public string Cor {get; set;}

    public Veiculo()
    {
    }

    public Veiculo(string modelo, DateTime ano, string cor){
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
    }

    public void ToString(){
        Console.WriteLine("\nModelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano.ToString("dd/MM/yyyy"));
        Console.WriteLine("Cor: " + Cor);
    }

    public int IdadeVeiculo => DateTime.Now.Year - Ano.Year;

    public static void Main(string[] args)
    {
        Veiculo tesla = new();

        tesla.Modelo = "Model S";
        tesla.Ano = new DateTime(2021, 1, 1);
        tesla.Cor = "Branco";

        tesla.ToString();

        Console.WriteLine("Idade do veículo: " + tesla.IdadeVeiculo + " anos\n");
    }
}