namespace Roomie_API.Interfaces.Services.Base;

public interface IServiceBase<T, U> : IDisposable where T : class where U : class
{
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T> GetByIdAsync(int id);
    public Task CreateAsync(T entity);
    public Task UpdateAsync(T entity);
    public Task DeleteAsync(int id);
}