using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Model
{
    public class Interview
    {
        public int Id { get; set; }
        public string CompanyName {  get; set; }
        public string JobPost {  get; set; }
        public  DateOnly interviewDate {  get; set; }
        public string InterviewType {  get; set; }
        public TimeOnly interviewTime { get; set; }

    }
}
