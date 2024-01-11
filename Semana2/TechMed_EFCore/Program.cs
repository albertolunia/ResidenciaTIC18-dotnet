using TechMed_EFCore.Models;

var context = new TechMedContext();

/*Console.WriteLine("Lendo todos os medicos do banco");
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

context.Atendimentos.Add(new Atendimento{
    DataHora = DateTime.Now,
    Medico = context.Medicos.FirstOrDefault(),
    Paciente = context.Pacientes.FirstOrDefault()
});

context.SaveChanges();

context.Exames.Add(new Exame{
    Nome = "Hemograma",
    Descricao = "Exame de sangue",
    Atendimento = context.Atendimentos.FirstOrDefault()
});

var atendimento = context.Atendimentos.FirstOrDefault(a => a.Id == 1);
if (atendimento != null)
{
    var exame = new Exame
    {
        Nome = "Exame Novo",
        Descricao = "Descrição do exame novo",
        Atendimento = atendimento
    };

    context.Exames.Add(exame);
    context.SaveChanges();
}


context.SaveChanges();

var atendimento2 = context.Atendimentos.FirstOrDefault(a => a.Id == 1);
if (atendimento2 != null)
{
    var exame = new Exame
    {
        Nome = "Exame Ocular",
        Descricao = "Exame nos olhos",
        Atendimento = atendimento2
    };

    context.Exames.Add(exame);
    context.SaveChanges();
}

if (atendimento2 != null)
{
    var exame = new Exame
    {
        Nome = "Exame de coração",
        Descricao = "Auto descritivo",
        Atendimento = atendimento2
    };

    context.Exames.Add(exame);
    context.SaveChanges();
}


context.SaveChanges();
*/


Console.WriteLine("\nLendo todos os medicos do banco\n");
foreach(var medico in context.Medicos.OrderBy(m => m.Nome)){
    Console.WriteLine($"Id: {medico.Id} - Nome: {medico.Nome} - CRM: {medico.CRM}");
}

Console.WriteLine("\nLendo todos os pacientes do banco\n");
foreach(var paciente in context.Pacientes.OrderBy(p => p.Nome)){
    Console.WriteLine($"Id: {paciente.Id} - Nome: {paciente.Nome} - CPF: {paciente.CPF}");
}

Console.WriteLine("\nLendo todos os atendimentos do banco\n");
foreach(var atendimento in context.Atendimentos){
    Console.WriteLine($"Atendimento: {atendimento.Id} - Data: {atendimento.DataHora} - Médico: {atendimento.Medico.Nome} - Paciente: {atendimento.Paciente.Nome}");
}

Console.WriteLine("\nLendo todos os exames do banco\n");
foreach(var exame in context.Exames){
    Console.WriteLine($"Exame: {exame.Id} - Nome: {exame.Nome} - Descrição: {exame.Descricao}");
}

/*var valber = contet.Pacientes.Where(p => p.Nome == "Valber").FirstOrDefault();

valber_Atendimentos.ToList().ForEach(a => a.Exames.ToList().ForEach(e => Console.WriteLine($"Exame: {e.Local} - {e.DataHora}")));*/
