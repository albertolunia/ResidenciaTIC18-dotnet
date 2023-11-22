#region Tuple Exemples

var tuple1 = (id: 1, name: "Everaldina", born: new DateTime(2001, 7, 12));

List<(int id, string name, DateTime born)> list = new();
list.Add(tuple1);
list.Add((2, "Alberto", new DateTime(1999, 2, 14)));
list.ForEach(x => Console.WriteLine($"Tuple 2: {x.id} - {x.name} - {x.born.ToShortDateString()}"));

#endregion

#region LambdaExpression Exemples

string[] people = { "Alberto", "Everaldina", "João", "Maria", "José" };
char letter = 'A';
Console.WriteLine($"\nPeople that the name contains '{letter}': {string.Join(", ", people.Where(x => x.Contains(letter)))}");

#endregion