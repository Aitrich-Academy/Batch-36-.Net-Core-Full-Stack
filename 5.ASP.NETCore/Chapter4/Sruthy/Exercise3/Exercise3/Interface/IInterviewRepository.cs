using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Interface
{
    public interface IInterviewRepository
    {
        void AddInterview(Interview interview);
        List<Interview> GetAllInterviews();
    }
}
