class Tarefa
{
    private int Id { get; set; }
    private string Titulo { get; set; }
    private string Descricao { get; set; }
    private DateTime DataVencimento { get; set; }
    private bool Status { get; set; }

    public Tarefa(int id, string titulo, string descricao, DateTime dataVencimento, bool status)
    {
        Id = id;
        Titulo = titulo;
        Descricao = descricao;
        DataVencimento = dataVencimento;
        Status = status;
    }

    public int GetId()
    {
        return Id;
    }

    public string GetTitulo()
    {
        return Titulo;
    }

    public string GetDescricao()
    {
        return Descricao;
    }

    public DateTime GetDataVencimento()
    {
        return DataVencimento;
    }

    public bool GetStatus()
    {
        return Status;
    }

    public void SetStatus(bool status)
    {
        Status = status;
    }
}

class Gestor
{
    private List<Tarefa> ArrayTarefas = new List<Tarefa>();

    public void CriarTarefa(int id, string titulo, string descricao, DateTime dataVencimento, bool status)
    {
        ArrayTarefas.Add(new Tarefa(id, titulo, descricao, dataVencimento, status));
        Console.WriteLine("\nTarefa adicionada com sucesso!");
    }

    public void MarcarTarefaConcluida(int id)
    {
        Tarefa tarefa = ArrayTarefas.Find(t => t.GetId() == id);
        if (tarefa != null)
        {
            tarefa.SetStatus(true);
            Console.WriteLine("\nTarefa concluída com sucesso!");
        }
        else
        {
            Console.WriteLine("\nNenhuma tarefa encontrada com o ID informado.");
        }
    }

    public void ExcluirTarefa(int id)
    {
        Tarefa tarefa = ArrayTarefas.Find(t => t.GetId() == id);
        if (tarefa != null)
        {
            ArrayTarefas.Remove(tarefa);
            Console.WriteLine("\nTarefa excluída com sucesso!");
        }
        else
        {
            Console.WriteLine("\nNenhuma tarefa encontrada com o ID informado.");
        }
    }

    public void PesquisarTarefa(string palavraChave)
    {
        List<Tarefa> tarefasEncontradas = ArrayTarefas.FindAll(t => t.GetTitulo().Contains(palavraChave) || t.GetDescricao().Contains(palavraChave));
        if (tarefasEncontradas.Count > 0)
        {
            Console.WriteLine("\nTarefas encontradas:");
            foreach (Tarefa tarefa in tarefasEncontradas)
            {
                Console.WriteLine(tarefa.GetTitulo());
                Console.WriteLine(tarefa.GetDescricao());
                Console.WriteLine(tarefa.GetDataVencimento());
                Console.WriteLine(tarefa.GetStatus());
            }
        }
        else
        {
            Console.WriteLine("\nNenhuma tarefa encontrada com a palavra-chave informada.");
        }
    }

    public void ExibirEstatisticas()
    {
        int tarefasConcluidas = ArrayTarefas.Count(t => t.GetStatus());
        int tarefasPendentes = ArrayTarefas.Count(t => !t.GetStatus());
        DateTime tarefaMaisAntiga = ArrayTarefas.Min(t => t.GetDataVencimento());
        DateTime tarefaMaisRecente = ArrayTarefas.Max(t => t.GetDataVencimento());

        Console.WriteLine($"\nNúmero de tarefas concluídas: {tarefasConcluidas}");
        Console.WriteLine($"Número de tarefas pendentes: {tarefasPendentes}");
        Console.WriteLine($"Tarefa mais antiga: {tarefaMaisAntiga}");
        Console.WriteLine($"Tarefa mais recente: {tarefaMaisRecente}");
    }

    public void ListarTarefas()
    {
        foreach (Tarefa tarefa in ArrayTarefas)
        {
            Console.WriteLine($"\nTitulo: {tarefa.GetTitulo()}");
            Console.WriteLine($"Descrição: {tarefa.GetDescricao()}");
            Console.WriteLine($"Data de vencimento: {tarefa.GetDataVencimento()}");
            Console.WriteLine($"Concluida: {tarefa.GetStatus()}");
        }
    }

    public Tarefa[] GetArrayTarefas()
    {
        return ArrayTarefas.ToArray();
    }
}

class Programa{
    static void Main(string[] args)
    {
        Gestor gestor = new Gestor();
        int opcao = 0;
        while (opcao != 7)
        {
            Console.WriteLine("\nSelecione uma opção:");
            Console.WriteLine("1 - Criar tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("3 - Excluir tarefa");
            Console.WriteLine("4 - Pesquisar tarefa");
            Console.WriteLine("5 - Exibir estatísticas");
            Console.WriteLine("6 - Listar Tarefas");
            Console.WriteLine("7 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Insira o título da tarefa");
                    string titulo = Console.ReadLine();

                    Console.WriteLine("Insira a descrição da tarefa");
                    string descricao = Console.ReadLine();

                    Console.WriteLine("Insira a data de vencimento da tarefa");
                    DateTime dataVencimento = DateTime.Parse(Console.ReadLine());

                    gestor.CriarTarefa(gestor.GetArrayTarefas().Length + 1, titulo, descricao, dataVencimento, false);

                    break;
                case 2:
                    Console.WriteLine("Insira o ID da tarefa");
                    int id = int.Parse(Console.ReadLine());

                    gestor.MarcarTarefaConcluida(id);
                    break;
                case 3:
                    Console.WriteLine("Insira o ID da tarefa");
                    id = int.Parse(Console.ReadLine());

                    gestor.ExcluirTarefa(id);
                    break;
                case 4:
                    Console.WriteLine("Insira a palavra-chave");
                    string palavraChave = Console.ReadLine();

                    gestor.PesquisarTarefa(palavraChave);
                    break;
                case 5:
                    gestor.ExibirEstatisticas();
                    break;
                case 6:
                    gestor.ListarTarefas();
                    break;
                case 7:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}