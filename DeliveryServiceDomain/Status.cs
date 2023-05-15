using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class Status
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public List<StatusShipment> Shipments { get; set; } = new List<StatusShipment>();

        public int GetStatusId()
        {
            return StatusId;
        }

        public void SetStatusId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException("Id cannot be lower than or equal to 0!");
            }

            StatusId = id;
        }

        public string GetStatusName()
        {
            return StatusName;
        }

        public void SetStatusName(string status)
        {
            if (status == null)
            {
                throw new ArgumentNullException("Status Name cannot be null!");
            }

            if (status.Trim().Length == 0 || status == "")
            {
                throw new ArgumentException("Status Name cannot be empty string!");
            }

            StatusName = status;
        }

        public List<StatusShipment> GetShipments()
        {
            if (Shipments == null)
            {
                throw new NullReferenceException("Shipment Statuses is null!");
            }

            return Shipments;
        }

        public void SetShipments(List<StatusShipment> ss)
        {
            if (ss == null)
            {
                throw new ArgumentNullException("Argument cannot be null!");
            }

            foreach (StatusShipment statusShipment in ss)
            {
                if (Shipments.Any(a => a.ShipmentId == statusShipment.ShipmentId &&
                                        a.StatusId == statusShipment.StatusId))
                {
                    throw new ArgumentException("Status shipments list already contains some of the forwarded objects!");
                }
            }

            Shipments.AddRange(ss);
        }
    }
}
