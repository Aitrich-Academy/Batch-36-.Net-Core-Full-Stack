using System;
using System.Collections.Generic;
using System.Text;
using Exercise3.Model;

namespace Exercise3.Interface
{
    public interface IApplicationRepository
    {
        void AddApplication(Application app);
        List<Application> GetAllApplications();
        List<Application> GetApplicationsByUser(string name);
    }
}
