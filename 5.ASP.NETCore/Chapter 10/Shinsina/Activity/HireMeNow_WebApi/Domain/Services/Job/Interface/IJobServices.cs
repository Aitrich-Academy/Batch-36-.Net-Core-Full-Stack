using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Helpers;
using Domain.Models;
using Domain.Services.Job.DTOs;

namespace Domain.Services.Job.Interface
{
    public interface IJobServices
    {
        public Task<List<JobPostsDtos>> GetJobs();

        Task<PagedList<SavedJob>> GetAllSavedJobsOfSeeker(Guid jobseekerId, JobListParam param);

    }
}
