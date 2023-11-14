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