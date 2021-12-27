using GenericRepoTemplate.Domain.Entities.Base;

namespace GenericRepoTemplate.Domain.Repositories.Base
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : EntityBase<TPrimaryKey>
    {
    }
}
