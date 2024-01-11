using TechMed_EFCore.Models;

var context = new TechMedContext();

// context.Medicos.Add(new Medico{
//     Nome = "Dr. House",
//     CPF = "123.456.789-00",
//     CRM = "123456",
//     Especialidade = "Clínico Geral",
//     Salario = "R$ 10.000,00"
// });

// context.SaveChanges();

context.Medicos.ToList().ForEach(m => Console.WriteLine($"{m.Id} - {m.Nome} - {m.CRM} - {m.Especialidade} - {m.Salario}"));
