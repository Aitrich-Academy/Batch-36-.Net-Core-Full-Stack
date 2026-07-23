using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Helpers;
using Domain.Models;
using System.Threading.Tasks;

namespace Domain.Services.Job.Interface
{
    public interface IJobRepository
    {
        Task<List<JobPost>> GetJobs();
        Task<PagedList<SavedJob>> GetAllSavedJobsOfSeeker(Guid jobseekerId, JobListParam param);
    }
}
