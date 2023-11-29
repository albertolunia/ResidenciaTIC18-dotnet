using System.Xml.Serialization;

class Agenda{
    public List<Contato> Contatos { get; set; }

    public Agenda(){
        Contatos = new();
    }

    public void AdicionarContato(Contato contato){
        if(!Contatos.Any(c => c.Codigo == contato.Codigo)) 
            Contatos.Add(contato);
    }

    public static void Main(string[] args)
    {
        Agenda agenda = new();
        agenda.AdicionarContato(new Contato("João", "1234-5678"));
        agenda.AdicionarContato(new Contato("Maria", "8765-4321"));
        agenda.AdicionarContato(new Contato("José", "4321-8765"));
        foreach (Contato contato in agenda.Contatos){
            Console.WriteLine("\nNome: " + contato.Nome);
            Console.WriteLine("Telefone: " + contato.Telefone);
        }
    }
}

class Contato{

    public int Codigo { get; private set; } = 0;
    public string Nome { get; set; }
    public string Telefone { get; set; }

    public Contato(string nome, string telefone){
        Codigo++;
        Nome = nome;
        Telefone = telefone;
    }
}