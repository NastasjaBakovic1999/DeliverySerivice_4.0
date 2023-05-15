using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class Person : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName(string fName)
        {
            if (fName == null)
            {
                throw new ArgumentNullException("First Name cannot be null!");
            }

            if (fName.Trim().Length == 0 || fName == "")
            {
                throw new ArgumentException("First Name cannot be empty space!");
            }

            FirstName = fName;
        }

        public string GetLastName()
        {
            return LastName;
        }

        public void SetLastName(string lName)
        {
            if (lName == null)
            {
                throw new ArgumentNullException("Last Name cannot be null!");
            }

            if (lName.Trim().Length == 0 || lName == "")
            {
                throw new ArgumentException("Last Name cannot be empty space!");
            }

            LastName = lName;
        }
    }
}
