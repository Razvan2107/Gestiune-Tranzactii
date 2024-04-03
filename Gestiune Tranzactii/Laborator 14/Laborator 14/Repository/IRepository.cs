using Laborator_14.Domain;

namespace Laborator_14.Repository;

public interface IRepository <TId, TE> where TE : Entity<TId>
{
    IEnumerable<TE> FindAll();
}