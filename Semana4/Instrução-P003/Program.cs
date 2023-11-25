using Instrução_P003;

int opcao, codigo, quantidade;

Estoque estoque = new Estoque();

#region Exercicio1 usando uma tupla
/*
Tuple<string, int, double> tupla = new Tuple<string, int, double>("Uva", 10, 10.0);

estoque.TEncherEstoque(tupla);

estoque.ListarProdutos();

Console. ReadKey(true);
*/
#endregion

#region Restante dos exercicios
do{

    Console.Clear();
    Console.WriteLine("Escolha uma opção: \n");
    Console.WriteLine("1 - Adicionar produtos");
    Console.WriteLine("2 - Buscar produto");
    Console.WriteLine("3 - Dar saida em um produto");
    Console.WriteLine("4 - Dar entrada em um produto");
    Console.WriteLine("5 - Editar produto");
    Console.WriteLine("6 - Listar produtos");
    Console.WriteLine("7 - Sair\n");
    try{
        Console.Write("Opção: ");
        opcao = int.Parse(Console.ReadLine()!);
    }catch{
        opcao = 0;
    }
    switch(opcao){
        case 1:
            List<Produto> produtos = App.AddProdutos();
            estoque.EncherEstoque(produtos);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 2:
            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            estoque.BuscaProduto(codigo);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 3:
            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            Console.Write("Digite a quantidade do produto: ");
            quantidade = int.Parse(Console.ReadLine()!);
            App.RemoverProduto(estoque.GetProdutos(), codigo, quantidade);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 4:
            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            Console.Write("Digite a quantidade do produto: ");
            quantidade = int.Parse(Console.ReadLine()!);
            App.AdicionarProduto(estoque.GetProdutos(), codigo, quantidade);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 5:
            Console.Write("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            App.EditarProduto(estoque.GetProdutos(), codigo);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 6:
            estoque.ListarProdutos();
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 7:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
    }
} while(opcao != 7);

#endregion