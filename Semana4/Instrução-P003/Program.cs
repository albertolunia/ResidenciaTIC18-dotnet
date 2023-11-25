using Instrução_P003;

int opcao, codigo, quantidade;

Estoque estoque = new Estoque();

do{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Adicionar produto");
    Console.WriteLine("2 - Buscar produto");
    Console.WriteLine("3 - Remover produto");
    Console.WriteLine("4 - Editar produto");
    Console.WriteLine("5 - Listar produtos");
    Console.WriteLine("6 - Sair");
    opcao = int.Parse(Console.ReadLine()!);

    switch(opcao){
        case 1:
            List<Produto> produtos = App.AddProdutos();
            estoque.EncherEstoque(produtos);
            break;
        case 2:
            Console.WriteLine("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            estoque.BuscaProduto(codigo);
            break;
        case 3:
            Console.WriteLine("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite a quantidade do produto: ");
            quantidade = int.Parse(Console.ReadLine()!);
            App.RemoverProduto(estoque.GetProdutos(), codigo, quantidade);
            break;
        case 4:
            Console.WriteLine("Digite o código do produto: ");
            codigo = int.Parse(Console.ReadLine()!);
            App.EditarProduto(estoque.GetProdutos(), codigo);
            break;
        case 5:
            estoque.ListarProdutos();
            break;
        case 6:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
} while(opcao != 6);