using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class Deliverer : Person
    {
        public DateTime DateOfEmployment { get; set; }
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string UserName { get => base.UserName; set => base.UserName = value; }
        public override string Email { get => base.Email; set => base.Email = value; }
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        public DateTime GetDateOfEmployment()
        {
            return DateOfEmployment;
        }

        public void SetDateOfEmployment(DateTime doe)
        {
            if (doe > DateTime.Now || doe > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException("Date Of Employment cannot be in the future!");
            }

            DateOfEmployment = doe;
        }
    }
}
