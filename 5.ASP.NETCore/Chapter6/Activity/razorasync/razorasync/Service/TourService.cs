using AutoMapper;
using razorasync.Dtos;
using razorasync.Interface;
using razorasync.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace razorasync.Service
{
 
        public class TourService : ITourService
        {
            private readonly ITourRepository _repository;
            private readonly IMapper _mapper;

            public TourService(ITourRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<TourDto>> GetAllToursAsync()
            {
                var tours = await _repository.GetAllAsync();
                return _mapper.Map<IEnumerable<TourDto>>(tours);
            }

            public async Task<TourDto> GetTourByIdAsync(int id)
            {
                var tour = await _repository.GetByIdAsync(id);
                return _mapper.Map<TourDto>(tour);
            }

            public async Task AddTourAsync(TourDto tourDto)
            {
                var tour = _mapper.Map<Tour>(tourDto);
                await _repository.AddAsync(tour);
            }

            public async Task UpdateTourAsync(TourDto tourDto)
            {
                var tour = _mapper.Map<Tour>(tourDto);
                await _repository.UpdateAsync(tour);
            }

            public async Task DeleteTourAsync(int id) =>
                await _repository.DeleteAsync(id);
        }
    }


