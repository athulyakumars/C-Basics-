using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback.Infrastructure
{
    public class AuthenticationInfrastructure : IAuthenticationInfrastructure
    {
        public bool StoreInfo()
        {
            System.IO.File.AppendAllText(@"D:\StudyField\FeedbackAPI\test.txt", "Data Stored");
            return true;
        }
    }
}