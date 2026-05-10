using razorasync.Dtos;

namespace razorasync.Interface
{
    public interface ITourService
    {
        Task<IEnumerable<TourDto>> GetAllToursAsync();
        Task<TourDto> GetTourByIdAsync(int id);
        Task AddTourAsync(TourDto tourDto);
        Task UpdateTourAsync(TourDto tourDto);
        Task DeleteTourAsync(int id);
    }
}
