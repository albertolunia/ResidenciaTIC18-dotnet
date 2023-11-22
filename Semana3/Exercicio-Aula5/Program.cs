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
char letter2 = 'a';
Console.WriteLine($"\nPeople that the name contains '{letter}': {string.Join(", ", people.Where(x => x.Contains(letter) || x.Contains(letter2)))}");

#endregion

#region LINQ Exemples

Console.WriteLine("\nLINQ Exemples: \n");

var students = new List<Student>{
   new Student(1, "Alberto Henrique", "123456789", new DateTime(1999, 2, 14), new List<string>{"123456789", "73988342986"}),
   new Student(2, "Andreia Miranda", "987654321", new DateTime(1981, 9, 1), new List<string>{"123456789", "73987654321"}),
   new Student(3, "Alberto Jesus", "123456789", new DateTime(1974, 10, 2), new List<string>{"123456789", "77988237086"})
};

var any = students.Any();
var anyHelder = students.Any(x => x.FullName.Contains("Helder"));
//var single = students.Single(x => x.Id == 10);
//throw exception
var singleOrDefault = students.SingleOrDefault(x => x.Id == 10);

var select = students.Select(x => x.PhoneNumbers);
var selectMany = students.SelectMany(x => x.PhoneNumbers);

var legalAge = students.Where(x => x.BirthDate <= DateTime.Today.AddYears(-18)).Select(x => x.FullName);
Console.WriteLine($"Legal age people: {string.Join(", ", legalAge)}");

#endregion
 public class Student{
   public Student(int id, string fullName, string document, DateTime birthDate, List<string> phoneNumbers)
   {
      Id = id;
      FullName = fullName;
      Document = document;
      BirthDate = birthDate;
      PhoneNumbers = new List<string>(phoneNumbers);
   }

   public int Id { get; set; }
   public string FullName { get; set; }
   public string Document { get; set; }
   public DateTime BirthDate { get; set; }
   public List<string> PhoneNumbers { get; set; }
}