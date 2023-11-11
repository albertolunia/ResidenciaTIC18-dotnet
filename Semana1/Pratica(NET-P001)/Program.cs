#region 2 - tipos de dados

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

Console.WriteLine("---Tipos de dados----");

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

#region 3 - conversão de tipos de dados

//A solução que imaginei foi separar a parte inteira da parte decimal e guardar em duas variaveis,
//pois a conversão direta perde a o valor da casa decimal

int parteInteira;
double parteDecimal;

Console.WriteLine("\n---Conversão de tipos de dados----");

valorDouble = 4.5;

parteInteira = (int)Math.Truncate(valorDouble);
parteDecimal = valorDouble - parteInteira;

Console.WriteLine("Valor Double: " + valorDouble);
Console.WriteLine("Parte inteira: " + parteInteira);
Console.WriteLine("Parte decimal: " + parteDecimal);

#endregion

#region 4 - operadores aritméticos

int x = 10, y = 3;

Console.WriteLine("\n---Operadores aritméticos----");

Console.WriteLine("Soma: " + (x + y));
Console.WriteLine("Subtração: " + (x - y));
Console.WriteLine("Multiplicação: " + (x * y));
Console.WriteLine("Divisão: " + (x / y));

#endregion

#region 5 - operadores de comparação

int a = 5, b = 8;

Console.WriteLine("\n---Operadores de comparação----");

if (a > b)
{
    Console.WriteLine("A é maior que B");
}
else if (a < b)
{
    Console.WriteLine("A é menor que B");
}
else
{
    Console.WriteLine("A é igual a B");
}

#endregion

#region 6 - operadores de igualdade

string str = "Hello", str2 = "World";

Console.WriteLine("\n---Operadores de igualdade----");

if (str == str2)
{
    Console.WriteLine("As strings são iguais");
}
else
{
    Console.WriteLine("As strings são diferentes");
}

#endregion

#region 7 - operadores lógicos

bool condicao1 = true, condicao2 = false;

Console.WriteLine("\n---Operadores lógicos----");

if (condicao1 && condicao2)
{
    Console.WriteLine("As duas condições são verdadeiras");
}
else
{
    Console.WriteLine("Nenhuma das condições é verdadeira");
}

#endregion

#region 8 - desafio de mistura de operadores

int num1 = 7, num2 = 3, num3 = 10;

Console.WriteLine("\n---Desafio de mistura de operadores----");

if (num1 > num2 && num3 == (num1 + num2))
{
    Console.WriteLine("num1 é maior que num2 e num3 é igual a soma de num1 e num2");
}
else
{
    Console.WriteLine("A condição é falsa");
}

#endregion