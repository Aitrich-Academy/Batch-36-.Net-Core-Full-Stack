using Exercise3.Interface;
using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Repository
{
    public class InterviewRepository : IInterviewRepository
    {
        private List<Interview> interviews = new List<Interview>();
        private int count = 1;

        public void AddInterview(Interview interview)
        {
            interview.Id = count++;
            interviews.Add(interview);
        }

        public List<Interview> GetAllInterviews()
        {
            return interviews;
        }
    }
}
