namespace PlanningBet.Core.Interfaces.Repositories;

public interface ICrudRepository<TEntity, TResponse>
{
    public IEnumerable<TResponse> FindAll();
    public TResponse FindById(Guid id);
    public TResponse Create(TEntity modelEntity);
    public TResponse Update(TEntity modelEntity);
    public bool Delete(Guid id);
}

