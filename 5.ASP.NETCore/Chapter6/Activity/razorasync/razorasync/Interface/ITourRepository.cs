using razorasync.Model;

namespace razorasync.Interface
{
    public interface ITourRepository
    {
        Task<IEnumerable<Tour>> GetAllAsync();
        Task<Tour> GetByIdAsync(int id);
        Task AddAsync(Tour tour);
        Task UpdateAsync(Tour tour);
        Task DeleteAsync(int id);
    }
}
