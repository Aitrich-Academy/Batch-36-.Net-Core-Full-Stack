using AutoMapper;
using JobPortal_Activity2_API.DTOs;
using JobPortal_Activity2_API.Interface;
using JobPortal_Activity2_API.Interfaces;
using JobPortal_Activity2_API.Models;
using JobPortal_Activity2_API.Repository;
using Microsoft.VisualBasic;

namespace JobPortal_Activity2_API.Services
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _repository;
        private readonly IMapper _mapper;
        public JobService(IJobRepository repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<JobDTO>> GetJobsAsync()
        {
            var jobs = await _repository.GetJobsAsync();
            return _mapper.Map<IEnumerable<JobDTO>>(jobs);
        }
        public async Task<JobDTO> GetJobByIdAsync(int id)
        {
            var job = await _repository.GetJobByIdAsync(id);
            return _mapper.Map<JobDTO>(job);
        }
        public async Task<JobDTO> AddJobAsync(JobDTO jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            job= await _repository.AddJobAsync(job);
            return _mapper.Map<JobDTO>(job);
        }
        public async Task<JobDTO> UpdateJobAsync(int id, JobDTO jobDto)
        {
            var job = await _repository.GetJobByIdAsync(id);
            if (job == null)
                return null;
            _mapper.Map<Job>(jobDto);
            await _repository.UpdateJobAsync(job);
            return _mapper.Map<JobDTO>(job);
        }
        public async Task<bool> DeleteJobAsync(int id)
        {
            var jobs = await _repository.GetJobByIdAsync(id);
            if (jobs == null)
                return false;
            return await _repository.DeleteJobAsync(id);
        }
    }
}
