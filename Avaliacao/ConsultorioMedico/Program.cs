using ConsultorioMedico;

class Programa{
    public static void Main(string[] args)
    {
        //Instanciando os objetos
        Requisitos requisitos = new();
        Paciente paciente = new();
        Medico medico = new();

        //Testando se insere pacientes e medicos
        paciente.Nome = "João";
        paciente.DataNascimento = "29111999";
        paciente.Cpf = "99999999999";
        paciente.Sexo = "M";
        paciente.Sintomas = "Dor de cabeça";

        Console.WriteLine(paciente.Nome);
        requisitos.CadastrarPaciente(paciente);

        paciente.Nome = "Maria";
        paciente.DataNascimento = "21022001";
        paciente.Cpf = "99993999999";
        paciente.Sexo = "F";
        paciente.Sintomas = "Colica";

        requisitos.CadastrarPaciente(paciente);

        paciente.Nome = "Pedro";
        paciente.DataNascimento = "30012013";
        paciente.Cpf = "99999999991";
        paciente.Sexo = "M";
        paciente.Sintomas = "Dor de barriga";

        requisitos.CadastrarPaciente(paciente);

        medico.Nome = "José";
        medico.DataNascimento = "29111980";
        medico.Cpf = "12345678910";
        medico.Crm = "123456";

        requisitos.CadastrarMedico(medico);

        medico.Nome = "Ana";
        medico.DataNascimento = "21022001";
        medico.Cpf = "12345678911";
        medico.Crm = "123457";

        requisitos.CadastrarMedico(medico);

        requisitos.ListarPacientes();
        requisitos.ListarMedicos();

        //Testando se insere pacientes com o mesmo CPF

        requisitos.CadastrarPaciente(paciente);

        //Testando se insere medicos com o mesmo CPF

        requisitos.CadastrarMedico(medico);

        //Testando se insere medicos com o mesmo CRM

        medico.Cpf = "12312312312";
        requisitos.CadastrarMedico(medico);

    }
}