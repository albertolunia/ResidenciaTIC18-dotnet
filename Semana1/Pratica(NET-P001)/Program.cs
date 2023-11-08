#region tipos de dados

sbyte valorSByte = 25;
byte valorByte = 10;
short valorShort = 30000;
ushort valorUShort= 60000;
int valorInt = 50000;
uint valorUint= 100000;
long valorLong = 7800000000;
ulong valorULong = 15600000000;
float valorFloat = 4.5f;
double valorDouble= 4.5;
decimal valorDecimal = 4.5m;

Console.WriteLine("Valor SByte: " + valorSByte);
Console.WriteLine("Valor Byte: " + valorByte);
Console.WriteLine("Valor Short: " + valorShort);
Console.WriteLine("Valor UShort: " + valorUShort);
Console.WriteLine("Valor Int: " + valorInt);
Console.WriteLine("Valor UInt: " + valorUint);
Console.WriteLine("Valor Long: " + valorLong);
Console.WriteLine("Valor ULong: " + valorULong);
Console.WriteLine("Valor Float: " + valorFloat);
Console.WriteLine("Valor Double: " + valorDouble);
Console.WriteLine("Valor Decimal: " + valorDecimal);

#endregion

#region conversão de tipos de dados

//A solução que imaginei foi separar a parte inteira da parte decimal e guardar em duas variaveis, pois a conversão direta perde a o valor da casa decimal
int parteInteira;
double parteDecimal;

valorDouble = 4.5;

parteInteira = (int)Math.Truncate(valorDouble);
parteDecimal = valorDouble - parteInteira;

Console.WriteLine("Parte inteira: " + parteInteira);
Console.WriteLine("Parte decimal: " + parteDecimal);

#endregion