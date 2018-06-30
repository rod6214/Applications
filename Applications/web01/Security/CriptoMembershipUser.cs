using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace web01.Security
{
    public class CriptoMembershipUser : MembershipUser
    {
        public CriptoMembershipUser(string userName, 
            string email, string userId) : base("providerName", userName, 
            userId, email, String.Empty, String.Empty, 
            false, false, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {
        }
    }
}