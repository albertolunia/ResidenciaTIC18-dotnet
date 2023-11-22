namespace Exercicio5_Aula5
{
    public class App
    {
        public static void Main()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("Alberto", 2.00));
            pessoas.Add(new Pessoa("Everaldina", 1.50));

            var mediaAlturas = pessoas.Average(x => x.Altura).ToString("N2");

            Console.WriteLine($"Média das alturas: {mediaAlturas}");
        }
    }
};