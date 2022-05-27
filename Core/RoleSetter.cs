using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    public static class RoleSetter
    {
        public static Role SetRole(string role)
        {
            switch (role)
            {
                case "admin":
                    return Role.Admin;
                case "manager":
                    return Role.Manager;
                case "customer advisor":
                    return Role.Advisor;
                default:
                    return Role.None;
            }
        }
    }
}
