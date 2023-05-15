using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class ShipmentWeight
    {
        public int ShipmentWeightId { get; set; }
        public string ShipmentWeightDescpription { get; set; }
        public double ShipmentWeightPrice { get; set; }
        public List<Shipment> Shipments { get; set; } = new List<Shipment>();

        public int GetShipmentWeightId()
        {
            return ShipmentWeightId;
        }

        public void SetShipmentWeightId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id cannot be lower than or equal to 0!");
            }

            ShipmentWeightId = id;
        }

        public double GetShipmentWeightPrice()
        {
            return ShipmentWeightPrice;
        }

        public void SetShipmentWeightPrice(double price)
        {
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be lower than 0!");
            }

            ShipmentWeightPrice = price;
        }

        public string GetShipmentWeightDescpription()
        {
            return ShipmentWeightDescpription;
        }

        public void SetShipmentWeightDescpription(string desc)
        {
            if (desc == null)
            {
                throw new ArgumentNullException("Shipment Weight Descpription cannot be null!");
            }

            if (desc.Trim().Length == 0 || desc == "")
            {
                throw new ArgumentException("Shipment Weight Descpription cannot be empty string!");
            }

            ShipmentWeightDescpription = desc;
        }

        public List<Shipment> GetShipments()
        {
            if (Shipments == null)
            {
                throw new NullReferenceException("Shipments is null!");
            }

            return Shipments;
        }

        public void SetShipmens(List<Shipment> ss)
        {
            if (ss == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            foreach (Shipment shipment in ss)
            {
                if (Shipments.Any(a => a.ShipmentId == shipment.ShipmentId
                                    && a.CustomerId == shipment.CustomerId))
                {
                    throw new ArgumentException("Shipments list already contains some of the forwarded objects!");
                }
            }

            Shipments = ss;
        }
    }
}
