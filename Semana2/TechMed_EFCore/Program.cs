using TechMed_EFCore.Models;

var context = new TechMedContext();

Console.WriteLine("Lendo todos os medicos do banco");
foreach(var medico in context.Medicos.OrderBy(m => m.Nome)){
    Console.WriteLine($"Id: {medico.Id} - Nome: {medico.Nome} - CRM: {medico.CRM}");
}

Console.WriteLine("Lendo todos os pacientes do banco");
foreach(var paciente in context.Pacientes.OrderBy(p => p.Nome)){
    Console.WriteLine($"Id: {paciente.Id} - Nome: {paciente.Nome} - CPF: {paciente.CPF}");
}

Console.WriteLine("Inserindo um médico no banco");

context.Medicos.Add(new Medico{
    Nome = "Dr. Dexter",
    CPF = "123.456.789-00",
    CRM = "123456",
    Especialidade = "Clínico Geral",
    Salario = "R$ 10.000,00"
});

Console.WriteLine("Inserindo um paciente no banco");

context.Pacientes.Add(new Paciente{
    Nome = "Paciente 1",
    CPF = "123.456.789-00",
    Endereco = "Rua 1, 123",
    Telefone = "(11) 1234-5678"
});

context.SaveChanges();

Console.WriteLine("Atualizando o nome de um paciente no banco");
var doente = context.Pacientes.Where(p => p.Nome == "Paciente 1").FirstOrDefault();
doente.Nome = "Paciente Doente";
context.Pacientes.Update(doente);

context.SaveChanges();

Console.WriteLine("Removendo o primeiro médico do banco");
var medicoRemovido = context.Medicos.FirstOrDefault();
context.Medicos.Remove(medicoRemovido);

context.SaveChanges();

Console.WriteLine("Finalizando o programa");
