using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobProviderApplication.Interface
{
    public interface IInterviewProvider
    {
        void ScheduleInterview(Interview interview);
        Interview[] GetInterviews();
    }
}
