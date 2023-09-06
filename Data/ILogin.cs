using ClassMembershipApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembershipApplication.Data
{
    public interface ILogin
    {
       User Login(string emailAddress, string password);
    }
}
