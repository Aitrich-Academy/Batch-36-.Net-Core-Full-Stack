using AutoMapper;
using JobPortalManagment.DTO;
using JobPortalManagment.Interface;
using JobPortalManagment.Migrations.Model;

namespace JobPortalManagment.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task AddJob(JobDTO jobDTO)
        {
            var job = _mapper.Map<Job>(jobDTO);

            await _jobRepository.AddJob(job);
        }

        public async Task<List<JobDTO>> GetAllJobs()
        {
            var jobs = await _jobRepository.GetAllJobs();

            return _mapper.Map<List<JobDTO>>(jobs);
        }
        public async Task<JobDTO> GetJobById(int id)
        {
            var job = await _jobRepository.GetJobById(id);

            return _mapper.Map<JobDTO>(job);
        }

        public async Task UpdateJob(JobDTO dto)
        {
            var job = _mapper.Map<Job>(dto);

            await _jobRepository.UpdateJob(job);
        }

        public async Task DeleteJob(int id)
        {
            await _jobRepository.DeleteJob(id);
        }
    }
}