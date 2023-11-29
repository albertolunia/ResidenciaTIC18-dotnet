class ContaBancaria{

    private double _saldo;
    public double Saldo {
        get { return _saldo; }
        set{
            if (value > 0){
                _saldo = value;
            }
            else{
                throw new ArgumentException("Saldo não pode ser negativo");
            }
        }
    }

    public static void Main(string[] args)
    {
        ContaBancaria conta = new();
        conta.Saldo = 1000;
        Console.WriteLine("\nSaldo: " + conta.Saldo);
        conta.Saldo = -1000;
        Console.WriteLine("\nSaldo: " + conta.Saldo);
    }

}