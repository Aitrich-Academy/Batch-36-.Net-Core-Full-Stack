using AutoMapper;
using JobPortal.DTO;
using JobPortal.Interface;
using JobPortal.Model;
using Microsoft.EntityFrameworkCore;


using System.Collections.Generic;

namespace JobPortal.Service
{
    public class JobService:IJobService
    {
        private readonly AppDbContext _context;
        private readonly IJobRepository _repository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<JobDTO>> GetAllJobsAsync() 
        {
            var jobs = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<JobDTO>>(jobs);
        }
        public async Task<JobDTO> GetJobByIdAsync(int id) 
        {
            var job = await _repository.GetByIdAsync(id);
            return _mapper.Map<JobDTO>(job);
        }
        public async Task AddJobAsync(JobDTO jobDto) 
        {
            var job = _mapper.Map<Job>(jobDto);
            await _repository.AddAsync(job);
        }
        public async Task UpdateJobAsync(JobDTO jobDto) 
        {
            var job = _mapper.Map<Job>(jobDto);
            await _repository.UpdateAsync(job);
        }

        public async Task DeleteJobAsync(int id) =>
                await _repository.DeleteAsync(id);
    }
}
