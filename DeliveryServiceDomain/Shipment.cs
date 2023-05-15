using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class Shipment
    {
        public Shipment()
        {

        }

        public Shipment(int shipmentWeightId, int shipmentId, int customerId, int delivererId)
        {
            ShipmentWeightId = shipmentWeightId;
            ShipmentId = shipmentId;
            CustomerId = customerId;
        }

        public int ShipmentId { get; set; }
        public string ShipmentCode { get; set; }
        public int ShipmentWeightId { get; set; }
        public ShipmentWeight ShipmentWeight { get; set; }
        public string ShipmentContent { get; set; }
        public Address Sending { get; set; } = new Address();
        public Address Receiving { get; set; } = new Address();
        public string ContactPersonName { get; set; }
        public string ContactPersonPhone { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public double Price { get; set; }
        public List<AdditionalServiceShipment> AdditionalServices { get; set; } = new List<AdditionalServiceShipment>();
        public List<StatusShipment> ShipmentStatuses { get; set; } = new List<StatusShipment>();
        public string Note { get; set; }

        public int GetShipmentWeightId()
        {
            return ShipmentWeightId;
        }

        public void SetShipmentWeightId(int id)
        {
            if (id < 0 || id == 0)
            {
                throw new ArgumentOutOfRangeException("Id cannot be lower than or equal to 0!");
            }

            ShipmentWeightId = id;
        }

        public int GetShipmentId()
        {
            return ShipmentId;
        }
        public void SetShipmentId(int id)
        {
            if (id < 0 || id == 0)
            {
                throw new ArgumentOutOfRangeException("Id cannot be lower than or equal to 0!");
            }

            ShipmentId = id;
        }

        public string GetShipmentCode()
        {

            return ShipmentCode;
        }

        public void SetShipmentCode(string code)
        {
            if (code == null)
            {
                throw new ArgumentNullException("Code cannot be null!");
            }

            if (code.Trim().Length == 0 || code == "")
            {
                throw new ArgumentException("Code cannot be empty string!");
            }

            ShipmentCode = code;
        }

        public string GetShipmentContent()
        {
            return ShipmentContent;
        }

        public void SetShipmentContent(string content)
        {
            if (content == null)
            {
                throw new ArgumentNullException("Shipment Content cannot be null!");
            }

            if (content.Trim().Length == 0 || content == "")
            {
                throw new ArgumentException("Shipment Content cannot be empty string!");
            }

            ShipmentContent = content;
        }

        public string GetSendingCity()
        {
            return Sending.City;
        }

        public void SetSendingCity(string sCity)
        {
            if (sCity == null)
            {
                throw new ArgumentNullException("Sending City cannot be null!");
            }

            if (sCity.Trim().Length == 0 || sCity == "")
            {
                throw new ArgumentException("Sending City cannot be empty string!");
            }

            Sending.City = sCity;
        }

        public string GetSendingAddress()
        {
            if (Sending.Street == null)
            {
                throw new NullReferenceException("Sending Address is null!");
            }

            return Sending.Street;
        }

        public void SetSendingAddress(string sAddress)
        {
            if (sAddress == null)
            {
                throw new ArgumentNullException("Sending Address cannot be null!");
            }

            if (sAddress.Trim().Length == 0 || sAddress == "")
            {
                throw new ArgumentException("Sending Address cannot be empty string!");
            }

            Sending.Street = sAddress;
        }

        public string GetSendingPostalCode()
        {
            return Sending.PostalCode;
        }

        public void SetSendingPostalCode(string code)
        {
            if (code == null)
            {
                throw new ArgumentNullException("Code cannot be null!");
            }

            if (code.Trim().Length == 0 || code == "")
            {
                throw new ArgumentException("Code cannot be empty string!");
            }

            Sending.PostalCode = code;
        }

        public string GetReceivingCity()
        {
            if (Receiving.City == null)
            {
                throw new NullReferenceException("Receiving City is null!");
            }

            return Receiving.City;
        }

        public void SetReceivingCity(string rCity)
        {
            if (rCity == null)
            {
                throw new ArgumentNullException("Receiving City cannot be null!");
            }

            if (rCity.Trim().Length == 0 || rCity == "")
            {
                throw new ArgumentException("Receiving City cannot be empty string!");
            }

            Receiving.City = rCity;
        }

        public string GetReceivingAddress()
        {
            if (Receiving.Street == null)
            {
                throw new NullReferenceException("Receiving Address is null!");
            }

            return Receiving.Street;
        }

        public void SetReceivingAddress(string rAddress)
        {
            if (rAddress == null)
            {
                throw new ArgumentNullException("Receiving Address cannot be null!");
            }

            if (rAddress.Trim().Length == 0 || rAddress == "")
            {
                throw new ArgumentException("Receiving Address cannot be empty string!");
            }

            Receiving.Street = rAddress;
        }

        public string GetSReceivingPostalCode()
        {
            if (Receiving.PostalCode == null)
            {
                throw new NullReferenceException("Receiving Postal Code is null!");
            }

            return Receiving.PostalCode;
        }

        public void SetReceivingPostalCode(string code)
        {
            if (code == null)
            {
                throw new ArgumentNullException("Code cannot be null!");
            }

            if (code.Trim().Length == 0 || code == "")
            {
                throw new ArgumentException("Code cannot be empty string!");
            }

            Receiving.PostalCode = code;
        }

        public string GetContactPersonName()
        {
            return ContactPersonName;
        }

        public void SetContactPersonName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name cannot be null!");
            }

            if (name.Trim().Length == 0 || name == "")
            {
                throw new ArgumentException("Name cannot be empty string!");
            }

            ContactPersonName = name;
        }

        public string GetContactPersonPhone()
        {
            return ContactPersonPhone;
        }

        public void SetContactPersonPhone(string phone)
        {
            if (phone == null)
            {
                throw new ArgumentNullException("Phone cannot be null!");
            }

            if (phone.Trim().Length == 0 || phone == "")
            {
                throw new ArgumentException("Phone cannot be empty string!");
            }

            ContactPersonPhone = phone;
        }

        public string GetNote()
        {
            return Note;
        }

        public void SetNote(string note)
        {
            if (note == null)
            {
                throw new ArgumentNullException("Note cannot be null!");
            }

            if (note.Trim().Length == 0 || note == "")
            {
                throw new ArgumentException("Note cannot be empty string!");
            }

            Note = note;
        }

        public int GetCustomerId()
        {
            return CustomerId;
        }

        public void SetCustomerId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id cannot be lower than or equal to 0!");
            }

            CustomerId = id;
        }

        public ShipmentWeight GetShipmentWeight()
        {
            if (ShipmentWeight == null)
            {
                throw new NullReferenceException("Shipment Weight is null!");
            }

            return ShipmentWeight;
        }

        public void SetShipmentWeight(ShipmentWeight sw)
        {
            if (sw == null)
            {
                throw new ArgumentNullException("Shipment Weight cannot be null!");
            }

            ShipmentWeight = sw;
        }

        public Customer GetCustomer()
        {
            if (Customer == null)
            {
                throw new NullReferenceException("Customer is null!");
            }

            return Customer;
        }

        public void SetCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Customer cannot be null!");
            }

            Customer = customer;
        }

        public List<AdditionalServiceShipment> GetAdditionalServices()
        {
            if (AdditionalServices == null)
            {
                throw new NullReferenceException("Additional Services is null!");
            }

            return AdditionalServices;
        }

        public void SetAdditionalServices(List<AdditionalServiceShipment> addss)
        {
            if (addss == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            foreach (AdditionalServiceShipment additionalService in addss)
            {
                if (AdditionalServices.Any(a => a.AdditionalServiceId == additionalService.AdditionalServiceId
                                                && a.ShipmentId == additionalService.ShipmentId))
                {
                    throw new ArgumentException("Additional services list already contains some of the forwarded objects!");
                }
            }

            AdditionalServices.AddRange(addss);
        }

        public List<StatusShipment> GetShipmentStatuses()
        {
            if (ShipmentStatuses == null)
            {
                throw new NullReferenceException("Shipment Statuses is null!");
            }

            return ShipmentStatuses;
        }
        public void SetShipmentStatuses(List<StatusShipment> ss)
        {
            if (ss == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            foreach (StatusShipment statusShipment in ss)
            {
                if (ShipmentStatuses.Any(a => a.ShipmentId == statusShipment.ShipmentId &&
                                               a.StatusId == statusShipment.StatusId))
                {
                    throw new ArgumentException("Status shipments list already contains some of the forwarded objects!");
                }
            }

            ShipmentStatuses.AddRange(ss);
        }

        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be lower than 0!");
            }

            Price = price;
        }

        public override string ToString()
        {
            return $"Shipment with {ShipmentCode} code";
        }
    }
}
