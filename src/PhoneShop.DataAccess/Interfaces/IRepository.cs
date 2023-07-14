namespace PhoneShop.DataAccess.Interfaces;

public interface IRepository<TEntity,TViewModels>
{
    public Task<int> CreateAsync(TEntity entity);


    public Task<int> UpdateAsync(int id, TEntity entity);

    public Task<int> DeleteAsync(int id);

    public Task<TViewModels> GetByIdAsync(int id);

    public Task<long> CountAsync();
}
