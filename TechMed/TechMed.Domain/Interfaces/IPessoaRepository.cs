using TechMed.Domain.Entities;

namespace TechMed.Domain.Interfaces;
public interface IPessoaRepository : IBaseRepository<Pessoa>
{
    Task<Pessoa?> GetByEmail(string email, CancellationToken cancellationToken);
}
