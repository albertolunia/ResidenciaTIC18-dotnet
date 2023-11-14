#region Exercicio 1

Console.WriteLine("Exercicio 1\n");

string data = "14/11/2023";
int dia, mes, ano;

string[] Sdata = data.Split('/');

dia = int.Parse(Sdata[0]);
mes = int.Parse(Sdata[1]);
ano = int.Parse(Sdata[2]);

Console.WriteLine("Dia: " + dia);
Console.WriteLine("Mes: " + mes);
Console.WriteLine("Ano: " + ano);

#endregion

#region Exercicio 2

Console.WriteLine("\nExercicio 2\n");

int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

foreach (int numero in numeros)
{
    if (numero % 2 == 0)
        Console.WriteLine(numero);
}

#endregion

#region Exercicio 3

Console.WriteLine("\nExercicio 3\n");

List<string> cidades = new List<string>();

cidades.Add("São Paulo");
cidades.Add("Rio de Janeiro");
cidades.Add("Belo Horizonte");
cidades.Add("Curitiba");
cidades.Add("Porto Alegre");

foreach (string cidade in cidades)
{
    if(cidade.StartsWith("S"))
        Console.WriteLine(cidade);
}

#endregion

#region Exercicio 4

Console.WriteLine("\nExercicio 4\n");

string dataHoraAtual, dataHoraFuturo;

dataHoraAtual = "01/01/2024 12:00";
dataHoraFuturo = "02/01/2024 12:00";



#endregion