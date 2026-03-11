using JobProviderApplication.Interface;
using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobProviderApplication.Interface
{
    public interface IApplicationProvider
    {
        void AddApplication(Application application);
        Application[] GetApplications();
    }
}

