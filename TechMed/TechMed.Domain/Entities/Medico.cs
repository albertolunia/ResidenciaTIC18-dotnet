namespace TechMed.Domain.Entities;
public class Medico : Pessoa{
    public required string CRM { get; set; }
    public string? Especialidade { get; set; }
    public string? Salario { get; set; }

    public ICollection<Atendimento> Atendimentos { get; }
}
