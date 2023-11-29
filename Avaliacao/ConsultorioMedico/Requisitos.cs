namespace ConsultorioMedico{
    class Requisitos{
        List<Paciente> pacientes = new();
        List<Medico> medicos = new();

        public Requisitos(){
            Paciente paciente = new();
            Medico medico = new();
        }

        public void CadastrarPaciente(Paciente paciente){
            if (!pacientes.Any(p => p.Cpf == paciente.Cpf))
                pacientes.Add(paciente);
            else
                Console.WriteLine("\nPaciente já cadastrado!!!");
        }

        public void CadastrarMedico(Medico medico){
            if (!medicos.Any(m => m.Cpf == medico.Cpf) && !medicos.Any(m => m.Crm == medico.Crm))
                medicos.Add(medico);
            else
                Console.WriteLine("\nMédico já cadastrado!!!");
        }

        public void ListarPacientes(){
            Console.WriteLine("\nLista de pacientes:\n");
            foreach (Paciente paciente in pacientes)
                Console.WriteLine($"Nome: {paciente.Nome} | CPF: {FormatarCPF(paciente.Cpf)} | Data de Nascimento: {FormatarData(paciente.DataNascimento)} | Sexo: {paciente.Sexo} | Sintomas: {paciente.Sintomas}");
        }

        public void ListarMedicos(){
            Console.WriteLine("\nLista de medicos:\n");
            foreach (Medico medico in medicos)
                Console.WriteLine($"Nome: {medico.Nome} | CPF: {FormatarCPF(medico.Cpf)} | Data de Nascimento: {FormatarData(medico.DataNascimento)} | CRM: {medico.Crm}");
        }

        private string FormatarCPF(string cpf){
            return cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
        }

        private string FormatarData(string data){
            return data.Insert(2, "/").Insert(5, "/");
        }
    }
}