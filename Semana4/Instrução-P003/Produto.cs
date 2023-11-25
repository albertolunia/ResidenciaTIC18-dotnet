namespace Instrução_P003{
    class Produto
    {
        public Produto(string nome, int quantidade, double preco)
        {
            Codigo = ++CodigoProduto;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        private static int CodigoProduto { get; set; } = 1;
        private int Codigo { get; }
        private string Nome { get; set; }
        private int Quantidade { get; set; }
        private double Preco { get; set; }

        public void SetNome(string nome){
            Nome = nome;
        }

        public string GetNome(){
            return Nome;
        }

        public void SetQuantidade(int quantidade){
            Quantidade = quantidade;
        }

        public int GetQuantidade(){
            return Quantidade;
        }

        public void SetPreco(double preco){
            Preco = preco;
        }

        public double GetPreco(){
            return Preco;
        }

        public int GetCodigo(){
            return Codigo;
        }
    }
}