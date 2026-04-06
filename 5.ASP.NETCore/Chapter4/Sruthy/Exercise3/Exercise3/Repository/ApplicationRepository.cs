using Exercise3.Interface;
using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace Exercise3.Repository
{
    public class ApplicationRepository : IApplicationRepository
    {
        private static int count = 1;
        private static List<Exercise3.Model.Application> applications = new List<Exercise3.Model.Application>();

        public void AddApplication(Exercise3.Model.Application app)
        {
            app.Id = count++;
            applications.Add(app);
        }

        public List<Exercise3.Model.Application> GetAllApplications()
        {
            return applications;
        }

        
        public List<Exercise3.Model.Application> GetApplicationsByUser(string email)
        {
            return applications.FindAll(a => a.ApplicantEmail == email);
        }
    }
}
