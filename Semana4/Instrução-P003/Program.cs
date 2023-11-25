using Instrução_P003;

int opcao, codigo, quantidade, limit;
double minimo, maximo;

Estoque estoque = new Estoque();

#region Exercicio1 usando uma tupla
/*
var tupla = ("Uva", 10, 10.0);

estoque.EncherEstoque(tupla);

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
    Console.WriteLine("7 - Relatorio - Listar produtos com estoque abaixo de um limite");
    Console.WriteLine("8 - Relatorio - Listar produtos com valor entre um mínimo e um máximo informados");
    Console.WriteLine("9 - Relatorio - Informar o valor total do estoque e o valor total de cada produto de acordo com seu estoque");
    Console.WriteLine("10 - Sair\n");
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
            try{
                codigo = int.Parse(Console.ReadLine()!);
            }catch{
                codigo = 0;
            }
            if(codigo <= 0){
                throw new Exception("\nCódigo inválido!");
            }
            estoque.BuscaProduto(codigo);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 3:
            Console.Write("Digite o código do produto: ");
            try{
                codigo = int.Parse(Console.ReadLine()!);
            }catch{
                codigo = 0;
            }
            if(codigo <= 0){
                throw new Exception("\nCódigo inválido!");
            }
            Console.Write("Digite a quantidade do produto: ");
            try{
                quantidade = int.Parse(Console.ReadLine()!);
            }
            catch{
                quantidade = 0;
            }
            if(quantidade <= 0){
                throw new Exception("\nQuantidade inválida!");
            }
            App.RemoverProduto(estoque.GetProdutos(), codigo, quantidade);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 4:
            Console.Write("Digite o código do produto: ");
            try{
                codigo = int.Parse(Console.ReadLine()!);
            }catch{
                codigo = 0;
            }
            if(codigo <= 0){
                throw new Exception("\nCódigo inválido!");
            }
            codigo = int.Parse(Console.ReadLine()!);
            Console.Write("Digite a quantidade do produto: ");
            try{
                quantidade = int.Parse(Console.ReadLine()!);
            }
            catch{
                quantidade = 0;
            }
            if(quantidade <= 0){
                throw new Exception("\nQuantidade inválida!");
            }
            App.AdicionarProduto(estoque.GetProdutos(), codigo, quantidade);
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 5:
            Console.Write("Digite o código do produto: ");
            try{
                codigo = int.Parse(Console.ReadLine()!);
            }
            catch{
                codigo = 0;
            }
            if(codigo <= 0){
                throw new Exception("\nCódigo inválido!");
            }
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
            Console.Write("Digite o limite de produtos: ");
            try{
                limit = int.Parse(Console.ReadLine()!);
            }
            catch{
                limit = 0;
            }
            if(limit <= 0){
                throw new Exception("\nLimite inválido!");
            }
            var limitesFiltrados = estoque.GetProdutos().Where(p => p.GetQuantidade() < limit).ToList();
            foreach (var produto in limitesFiltrados)
            {
                Console.WriteLine($"Código: {produto.GetCodigo()} \t| Nome: {produto.GetNome()} \t| Quantidade: {produto.GetQuantidade()} \t| Preço: {produto.GetPreco()}");
            }
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
        case 8:
            Console.Write("Digite o valor mínimo: ");
            try{
                minimo = double.Parse(Console.ReadLine()!);
            }
            catch{
                minimo = 0;
            }
            if(minimo <= 0){
                throw new Exception("\nValor mínimo inválido!");
            }
            Console.Write("Digite o valor máximo: ");
            try{
                maximo = double.Parse(Console.ReadLine()!);
            }
            catch{
                maximo = 0;
            }
            if(maximo <= 0){
                throw new Exception("\nValor máximo inválido!");
            }
            var produtosFiltrados = estoque.GetProdutos().Where(p => p.GetPreco() >= minimo && p.GetPreco() <= maximo).ToList();
            foreach (var produto in produtosFiltrados)
            {
                Console.WriteLine($"Código: {produto.GetCodigo()} \t| Nome: {produto.GetNome()} \t| Quantidade: {produto.GetQuantidade()} \t| Preço: {produto.GetPreco()}");
            }
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console.ReadKey(true);
            break;
        case 9:
            Func<Produto, double> valorProduto = p => p.GetQuantidade() * p.GetPreco();
            Func<Produto, double> valorTotalEstoque = p => estoque.GetProdutos().Sum(p => p.GetQuantidade() * p.GetPreco());

            foreach (var produto in estoque.GetProdutos())
            {
                Console.WriteLine($"Código: {produto.GetCodigo()} \t| Nome: {produto.GetNome()} \t| Quantidade: {produto.GetQuantidade()} \t| Preço: R${produto.GetPreco()} \t| Valor Total: R${valorProduto(produto)}");
            }

            Console.WriteLine($"\nValor Total do Estoque: R${valorTotalEstoque(estoque.GetProdutos().First())}");
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console.ReadKey(true);
            break;
        case 10:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Console.WriteLine("\n --- Aperte enter para continuar ---");
            Console. ReadKey(true);
            break;
    }
} while(opcao != 10);

#endregion