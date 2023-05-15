using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryServiceDomain
{
    public class Customer : Person
    {
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string UserName { get => base.UserName; set => base.UserName = value; }
        public override string Email { get => base.Email; set => base.Email = value; }
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddres(string address)
        {
            if (address == null)
            {
                throw new ArgumentNullException("Address cannot be null!");
            }

            if (address.Trim().Length == 0 || address == "")
            {
                throw new ArgumentException("Address cannot be empty space!");
            }

            Address = address;
        }

        public string GetPostalCode()
        {
            return PostalCode;
        }

        public void SetPostalCode(string postalCode)
        {
            if (postalCode == null)
            {
                throw new ArgumentNullException("Postal Code cannot be null!");
            }

            PostalCode = postalCode;
        }

    }
}
