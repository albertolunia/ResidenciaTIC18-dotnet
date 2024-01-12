using TechMed.Infrastructure;

var context = new TechMedContext();

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
