using Domain.Models;
using Domain.Services.Admin.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Admin.Interface
{
    public interface IAdminServices
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();
        public Task<List<JobProviderCompany>> GetCompanies();
        public Task<List<JobPost>> GetJobs(string JobLitle);
        public Task<List<JobProviderCompany>> SearchCompanies(string name);

        Task<bool> AddSkillAsync(SkillDTO skill);

        Task<Location> AddLocation(Location location);
        public Task<List<Location>> GetLocations();
        public Task<List<JobPost>> GetJobs();

        //public int GetJobProviderCount();
        Task<int> GetJobProviderCount();
        public int GetJobCount();
        Task<bool> RemoveSkillAsync(Guid skillId);


        public void DeleteById(Guid id);
        public void DeleteByLocationId(Guid id);

         //public List<JobPost> GetJobs(JobListParams param);

    }
}
