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
            Produtos = produtos;
        }

        public void ListarProdutos(){
            foreach(Produto produto in Produtos){
                Console.WriteLine($"Código: {produto.GetCodigo()} | Nome: {produto.GetNome()} | Quantidade: {produto.GetQuantidade()} | Preço: {produto.GetPreco()}");
            }
        }

        public void BuscaProduto(int codigo){
            Produto produto = App.BuscarProduto(Produtos, codigo);
            Console.WriteLine($"Código: {produto.GetCodigo()} | Nome: {produto.GetNome()} | Quantidade: {produto.GetQuantidade()} | Preço: {produto.GetPreco()}");
            
        }
        public List<Produto> GetProdutos(){
            return Produtos;
        }
    }
}