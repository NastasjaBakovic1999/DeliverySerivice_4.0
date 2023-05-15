using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class StatusShipment
    {
        public StatusShipment()
        {

        }

        public StatusShipment(int sId, int shId, Status status, Shipment shipment, DateTime dt)
        {
            StatusId = sId;
            ShipmentId = shId;
            Status = status;
            Shipment = shipment;
            StatusTime = dt;
        }

        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; }
        public DateTime StatusTime { get; set; }

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

        public Status GetStatus()
        {

            return Status;
        }

        public void SetStatus(Status status)
        {
            if (status == null)
            {
                throw new ArgumentNullException("Status cannot be null!");
            }

            Status = status;
        }

        public Shipment GetShipment()
        {
            return Shipment;
        }

        public void SetShipment(Shipment shipment)
        {
            if (shipment == null)
            {
                throw new ArgumentNullException("Shipment cannot be null!");
            }

            Shipment = shipment;
        }

        public DateTime GetStatusTime()
        {
            return StatusTime;
        }

        public void SetStatusTime(DateTime dt)
        {
            if (dt > DateTime.Now || dt > DateTime.Today)
            {
                throw new ArgumentOutOfRangeException("Status Time cannot be in the future!");
            }

            StatusTime = dt;
        }
    }
}
