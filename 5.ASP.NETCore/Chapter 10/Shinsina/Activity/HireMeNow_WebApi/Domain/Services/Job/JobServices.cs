using AutoMapper;
using Domain.Helpers;
using Domain.Models;
using Domain.Services.Job.DTOs;
using Domain.Services.Job.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Job
{
    internal class JobServices:IJobServices
    {
        private IJobRepository _jobrepository;
        private IMapper _mapper;

        public JobServices(IJobRepository jobrepository, IMapper mapper)
        {
            _jobrepository = jobrepository;
            _mapper = mapper;
        }
        public async Task<PagedList<SavedJob>> GetAllSavedJobsOfSeeker(Guid jobseekerId, JobListParam param)
        {
            var savedJobs = await _jobrepository.GetAllSavedJobsOfSeeker(jobseekerId, param);
            //var savedjobsDto = _mapper.Map<PagedList<SavedJob>>(savedJobs);
            return savedJobs;
        }


        public async Task<List<JobPostsDtos>> GetJobs()
        {
            var notApplied = await _jobrepository.GetJobs();
            var dtoList = _mapper.Map<List<JobPostsDtos>>(notApplied);
            return dtoList;


        }
    }
}
