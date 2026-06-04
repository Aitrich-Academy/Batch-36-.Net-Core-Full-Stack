using Login_Exercise_1_Blazor.DTO;
using Login_Exercise_1_Blazor.Interface;
using Login_Exercise_1_Blazor.Model;

namespace Login_Exercise_1_Blazor.Service
{
    //public class JobService : IJobService
    //{
    //    private readonly IJobRepository _repository;

    //    public JobService(IJobRepository repository)
    //    {
    //        _repository = repository;
    //    }

    //    public async Task<List<Job>> GetAllJobsAsync()
    //    {
    //        return await _repository.GetAllJobsAsync();
    //    }
    //}
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await _jobRepository.GetAllJobsAsync();
        }

        public async Task AddJobAsync(JobDTO dto)
        {
            var job = new Job
            {
                Title = dto.Title,
                Description = dto.Description,
                Location = dto.Location,
                Salary = dto.Salary,
                JobType = dto.JobType
            };

            await _jobRepository.AddJobAsync(job);
        }
    }
    }
