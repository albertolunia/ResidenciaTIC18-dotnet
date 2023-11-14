#region Exercicio 1

Console.WriteLine("Exercicio 1\n");

for(var i = 0; i <= 30; i++){
    if(i % 3 == 0 || i % 4 == 0){
        Console.WriteLine(i);
    }
}

#endregion

#region Exercicio 2

Console.WriteLine("\nExercicio 2\n");

int n1 = 0, n2 = 1, n3 = 0;

while(n1 + n2 < 100)
{
    n3 = n1 + n2;
    Console.WriteLine(n3);
    n1 = n2;
    n2 = n3;
}

#endregion

#region Exercicio 3

Console.WriteLine("\nExercicio 3");

for(var i = 1; i <= 8; i++){
    Console.Write(i + ". ");
    for(var j = 1; j <= i; j++){
        Console.Write(i * j + " ");
    }
    Console.WriteLine();
}

#endregion