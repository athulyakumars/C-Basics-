using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Infrastructure
{
    public interface IAuthenticationInfrastructure
    {
        bool StoreInfo();
    }
}