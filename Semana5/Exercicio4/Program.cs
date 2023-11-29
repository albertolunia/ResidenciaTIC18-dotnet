class Aluno{

    private string _nome;
    private int _idade;
    public string Nome { 
        get{
            return _nome;
        }
        set{
            _nome = "Valor padrão";
        }
    }
    public int Idade {
        get{
            return _idade;
        } 
        set{
            _idade = 0;
        }
    }

    public Aluno(){
    }

    public static void Main(string[] args)
    {
        Aluno aluno = new();
        Console.WriteLine("\nNome: " + aluno.Nome);
        Console.WriteLine("Idade: " + aluno.Idade);
    }
}