using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobProviderApplication.Interface
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        Job[] GetJobs();
    }
}
