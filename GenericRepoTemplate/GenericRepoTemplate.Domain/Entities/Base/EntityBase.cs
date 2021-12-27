using GenericRepoTemplate.Domain.Entities.Base.Interfaces;

namespace GenericRepoTemplate.Domain.Entities.Base
{
    public abstract class EntityBase<TId> : IEntityBase<TId>
    {
        public TId Id { get; set; }
    }
}
