namespace Instrução_P003
{
    class App
    {
        public static List<Produto> AddProdutos(){
            List<Produto> produtos = new List<Produto>();
            string resposta = "S", nome;
            double preco;
            int quantidade;

            do{
                try{
                    Console.WriteLine("Digite o nome do produto: ");
                    nome = Console.ReadLine()!;
                    if(nome == ""){
                        throw new Exception("Nome inválido!");
                    }

                    Console.WriteLine("Digite a quantidade do produto: ");
                    quantidade = int.Parse(Console.ReadLine()!);
                    if(quantidade <= 0){
                        throw new Exception("Quantidade inválida!");
                    }

                    Console.WriteLine("Digite o preço do produto: ");
                    preco = double.Parse(Console.ReadLine()!);
                    if(preco <= 0){
                        throw new Exception("Preço inválido!");
                    }

                    Produto produto = new Produto(nome, quantidade, preco);

                    produtos.Add(produto);

                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                finally{
                    Console.WriteLine("Deseja adicionar mais um produto? (S/N)");
                    resposta = Console.ReadLine()!;
                }
            } while(resposta.ToUpper() == "S");

            return produtos;
        }

        public static Produto BuscarProduto(List<Produto> produtos, int codigo){
            try{
                Produto produto = produtos.Find(p => p.GetCodigo() == codigo);
                return produto;
            }catch{
                Console.WriteLine("Produto não encontrado!");
                return null;
            }
        }

        public static void RemoverProduto(List<Produto> produtos, int codigo, int quantidade){
            try{
                Produto produto = BuscarProduto(produtos, codigo);

                if(produto.GetQuantidade() < quantidade){
                    throw new Exception("Quantidade maior do que o estoque!");
                }

                produto.SetQuantidade(produto.GetQuantidade() - quantidade);

            }catch{
                Console.WriteLine("Produto não encontrado!");
            }
        }

        public static void EditarProduto(List<Produto> produtos, int codigo){
            try{
                Produto produto = BuscarProduto(produtos, codigo);
                Console.WriteLine("Digite o novo nome do produto: ");
                produto.SetNome(Console.ReadLine()!);
                if(produto.GetNome() == ""){
                    throw new Exception("Nome inválido!");
                }

                Console.WriteLine("Digite a nova quantidade do produto: ");
                produto.SetQuantidade(int.Parse(Console.ReadLine()!));
                if(produto.GetQuantidade() <= 0){
                    throw new Exception("Quantidade inválida!");
                }

                Console.WriteLine("Digite o novo preço do produto: ");
                produto.SetPreco(double.Parse(Console.ReadLine()!));
                if(produto.GetPreco() <= 0){
                    throw new Exception("Preço inválido!");
                }

                Console.WriteLine("Produto editado com sucesso!");
            }catch{
                Console.WriteLine("Produto não encontrado!");
            }
        }
    }
}