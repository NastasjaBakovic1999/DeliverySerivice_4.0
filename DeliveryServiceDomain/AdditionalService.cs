using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class AdditionalService
    {
        public AdditionalService()
        {

        }

        public int AdditionalServiceId { get; set; }
        public string AdditionalServiceName { get; set; }
        public double AdditionalServicePrice { get; set; }
        public List<AdditionalServiceShipment> Shipments { get; set; } = new List<AdditionalServiceShipment>();

        public int GetAdditionalServiceId()
        {
            return AdditionalServiceId;
        }

        public void SetAddiitonalServiceId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id cannot be lower than or equal to 0!");
            }

            AdditionalServiceId = id;
        }
        public string GetAdditionalServiceName()
        {
            return AdditionalServiceName;
        }

        public void SetAdditionalServiceName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name cannot be null!");
            }

            if (name.Trim().Length == 0 || name == "")
            {
                throw new ArgumentException("Name cannot be empty string!");
            }

            AdditionalServiceName = name;
        }
        public double GetAdditionalServicePrice()
        {
            return AdditionalServicePrice;
        }

        public void SetAdditionalServicePrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Price cannot be lower than 0!");
            }

            AdditionalServicePrice = price;
        }

        public List<AdditionalServiceShipment> GetShipments()
        {
            if (Shipments == null)
            {
                throw new NullReferenceException("The list is null!");
            }
            if (Shipments.Count == 0)
            {
                throw new Exception("The list is empty!");
            }

            return Shipments;
        }

        public void SetShipments(List<AdditionalServiceShipment> shipments)
        {
            if (shipments == null)
            {
                throw new ArgumentNullException("Shipments cannot be null!");
            }

            if (shipments.Count() == 0)
            {
                throw new ArgumentException("Shipments cannot be empty list!");
            }

            Shipments.AddRange(shipments);
        }
    }
}
