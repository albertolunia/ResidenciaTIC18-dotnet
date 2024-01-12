namespace TechMed.Domain.Entities;
public class Exame{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }
    public DateTime Data { get; set; }
    public ICollection<Atendimento> Atendimentos { get; set; }
    public int AtendimentoId { get; set; }
}
