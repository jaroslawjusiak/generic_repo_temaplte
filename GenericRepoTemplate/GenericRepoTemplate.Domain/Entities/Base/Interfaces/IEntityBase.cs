namespace GenericRepoTemplate.Domain.Entities.Base.Interfaces
{
    public interface IEntityBase<TId>
    {
        public TId Id { get; }
    }
}
