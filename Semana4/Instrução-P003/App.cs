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
                    Console.Write("Digite o nome do produto: ");
                    try{
                        nome = Console.ReadLine()!;
                    }catch{
                        nome = "";
                    }
                    if(nome == ""){
                        throw new Exception("\nNome inválido!");
                    }

                    Console.Write("Digite a quantidade do produto: ");
                    try{
                        quantidade = int.Parse(Console.ReadLine()!);
                    }catch{
                        quantidade = 0;
                    }
                    if(quantidade <= 0){
                        throw new Exception("\nQuantidade inválida!");
                    }

                    Console.Write("Digite o preço do produto: ");

                    try{
                        preco = double.Parse(Console.ReadLine()!);
                    }catch{
                        preco = 0;
                    }
                    if(preco <= 0){
                        throw new Exception("\nPreço inválido!");
                    }
                    
                    Produto produto = new Produto(nome, quantidade, preco);

                    produtos.Add(produto);

                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
                finally{
                    Console.WriteLine("\nDeseja adicionar mais um produto? (S/N): ");
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
                Console.WriteLine("\nProduto não encontrado!");
                return null;
            }
        }

        public static void RemoverProduto(List<Produto> produtos, int codigo, int quantidade){
            try{
                Produto produto = BuscarProduto(produtos, codigo);

                if(produto.GetQuantidade() < quantidade){
                    throw new Exception("\nQuantidade maior do que o estoque!");
                }

                produto.SetQuantidade(produto.GetQuantidade() - quantidade);
                Console.WriteLine($"\nProduto removido! Nova quantidade de {produto.GetNome()} em estoque: {produto.GetQuantidade()}\n");

            }catch{
                Console.WriteLine("\nProduto não encontrado!");
            }
        }

        public static void EditarProduto(List<Produto> produtos, int codigo){
            string nome;
            int quantidade;
            double preco;
            
            try{
                Produto produto = BuscarProduto(produtos, codigo);
                Console.Write("Digite o novo nome do produto: ");
                try{
                    nome = Console.ReadLine()!;
                }
                catch{
                    nome = "";
                }
                if(nome == ""){
                    throw new Exception("\nNome inválido!");
                }
                
                produto.SetNome(nome);

                Console.Write("Digite a nova quantidade do produto: ");
                try{
                    quantidade = int.Parse(Console.ReadLine()!);
                }
                catch{
                    quantidade = 0;
                }
                if(quantidade <= 0){
                    throw new Exception("\nQuantidade inválida!");
                }

                produto.SetQuantidade(quantidade);


                Console.Write("Digite o novo preço do produto: ");
                try{
                    preco = double.Parse(Console.ReadLine()!);
                }
                catch{
                    preco = 0;
                }
                if(preco <= 0){
                    throw new Exception("\nPreço inválido!");
                }
                produto.SetPreco(preco);

                Console.WriteLine("\nProduto editado com sucesso!");
            }catch{
                Console.WriteLine("\nProduto não encontrado!");
            }
        }

        public static void AdicionarProduto(List<Produto> produtos, int codigo, int quantidade){
            try{
                Produto produto = BuscarProduto(produtos, codigo);

                produto.SetQuantidade(produto.GetQuantidade() + quantidade);
                Console.WriteLine($"\nProduto adicionado! Nova quantidade de {produto.GetNome()} em estoque: {produto.GetQuantidade()}\n");

            }catch{
                Console.WriteLine("\nProduto não encontrado!");
            }
        }
    }
}