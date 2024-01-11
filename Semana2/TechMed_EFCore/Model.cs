using Microsoft.EntityFrameworkCore;

namespace TechMed_EFCore.Models;
public class TechMedContext : DbContext
{
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Exame> Exames{ get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connectionString = "server=localhost;user=techmed;password=Beto@1402;database=techmed";
        var serverVersion = ServerVersion.AutoDetect(connectionString);
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Medico>().ToTable("Medicos").HasKey(m => m.Id);
        modelBuilder.Entity<Paciente>().ToTable("Pacientes").HasKey(p => p.Id);
        modelBuilder.Entity<Atendimento>().ToTable("Atendimentos").HasKey(a => a.Id);
        modelBuilder.Entity<Exame>().ToTable("Exames").HasKey(e => e.Id);

        modelBuilder.Entity<Atendimento>()
            .HasOne(a => a.Medico)
            .WithMany(m => m.Atendimentos)
            .HasForeignKey(a => a.MedicoId);
        
        modelBuilder.Entity<Atendimento>()
            .HasOne(a => a.Paciente)
            .WithMany(p => p.Atendimentos)
            .HasForeignKey(a => a.PacienteId);

        modelBuilder.Entity<Exame>()
            .HasMany(e => e.Atendimentos)
            .WithMany(a => a.Exames);
    }
}

public abstract class Pessoa{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string CPF { get; set; }
    
}

public class Medico : Pessoa{
    public required string CRM { get; set; }
    public string? Especialidade { get; set; }
    public string? Salario { get; set; }

    public ICollection<Atendimento> Atendimentos { get; }
}

public class Paciente : Pessoa{
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public ICollection<Atendimento> Atendimentos { get; }
}

public class Atendimento{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public required Medico Medico { get; set; }
    public int MedicoId { get; set; }

    public required Paciente Paciente { get; set; }

    public int PacienteId { get; set; }

    public ICollection<Exame> Exames { get; }

}

public class Exame{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }
    public DateTime Data { get; set; }
    public ICollection<Atendimento> Atendimentos { get; set; }
    public int AtendimentoId { get; set; }
}
