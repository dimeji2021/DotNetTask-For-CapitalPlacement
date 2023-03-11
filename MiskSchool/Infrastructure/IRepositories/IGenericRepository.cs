namespace MiskSchool.Infrastructure.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T person);
        Task DeleteAsync(string id);
        Task<T> GetAsync(string id);
        Task<List<T>> GetAsync();
        Task<T> UpdateAsync(string id, T person);
    }
}