using ConsultorioMedico;

class Programa{
    public static void Main(string[] args)
    {
        Requisitos requisitos = new();
        Paciente paciente = new();
        Medico medico = new();

        paciente.Nome = "João";
        paciente.DataNascimento = "29111999";
        paciente.Cpf = "99999999999";
        paciente.Sexo = "M";
        paciente.Sintomas = "Dor de cabeça";

        medico.Nome = "José";
        medico.DataNascimento = "29112010";
        medico.Cpf = "12345678910";
        medico.Crm = "123456";

        requisitos.CadastrarPaciente(paciente);
        requisitos.CadastrarMedico(medico);

        requisitos.ListarPacientes();
        requisitos.ListarMedicos();

        //Testando se insere pacientes com o mesmo CPF

        requisitos.CadastrarPaciente(paciente);

        //Testando se insere medicos com o mesmo CPF e CRM

        requisitos.CadastrarMedico(medico);

    }
}