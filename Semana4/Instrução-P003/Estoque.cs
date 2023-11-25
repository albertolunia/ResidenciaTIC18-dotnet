
namespace Instrução_P003
{
    class Estoque {
        private List<Produto> Produtos { get; set; } = new List<Produto>();

        public Estoque(List<Produto> produtos){
            Produtos = produtos;
        }

        public Estoque(){
            Produtos = new List<Produto>();
        }

        public void EncherEstoque(List<Produto> produtos){
            Produtos.AddRange(produtos);
        }

        public void EncherEstoque((string, int, double) tupla)
        {
            var produto = new Produto(tupla.Item1, tupla.Item2, tupla.Item3);
            Produtos.Add(produto);
        }

        public void ListarProdutos(){
            if(Produtos.Count == 0){
                Console.WriteLine("\nEstoque vazio!");
            }
            else{
                foreach(Produto produto in Produtos){
                    Console.WriteLine($"Código: {produto.GetCodigo()} \t| Nome: {produto.GetNome()} \t| Quantidade: {produto.GetQuantidade()} \t| Preço: R${produto.GetPreco()}");
                }
            }
        }

        public void BuscaProduto(int codigo){
            try{
                Produto produto = Produtos.Find(p => p.GetCodigo() == codigo);
                Console.WriteLine($"Código: {produto.GetCodigo()} \t| Nome: {produto.GetNome()} \t| Quantidade: {produto.GetQuantidade()} \t| Preço: R${produto.GetPreco()}");
            }catch{
                Console.WriteLine("\nProduto não encontrado!");
            }            
        }
        public List<Produto> GetProdutos(){
            return Produtos;
        }
    }
}