namespace TechMed.WebAPI;
public class Medico
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Especialidade { get; set; }
    public string Salario { get; set; }

    public Medico()
    {
        Id = Guid.NewGuid();
    }
}
