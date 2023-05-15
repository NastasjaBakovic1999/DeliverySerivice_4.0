using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceDomain
{
    public class AdditionalServiceShipment
    {
        public AdditionalServiceShipment()
        {

        }
        public AdditionalServiceShipment(int idAS, int idS, AdditionalService ads, Shipment s)
        {
            AdditionalServiceId = idAS;
            ShipmentId = idS;
            AdditionalService = ads;
            Shipment = s;
        }

        public int AdditionalServiceId { get; set; }
        public AdditionalService AdditionalService { get; set; }
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; }

        public int GetAdditionalServiceId()
        {
            return AdditionalServiceId;
        }

        public void SetAdditionalServiceId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id cannot be lower than or equal to 0!");
            }

            AdditionalServiceId = id;
        }

        public AdditionalService GetAdditionalService()
        {
            return AdditionalService;
        }

        public void SetAdditionalService(AdditionalService additionalService)
        {
            if (additionalService == null)
            {
                throw new ArgumentNullException("Additional Service cannot be null!");
            }

            AdditionalService = additionalService;
        }

        public int GetShipmentId()
        {
            return ShipmentId;
        }

        public void SetShipmentId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id cannot be lower than or equal to 0!");
            }

            ShipmentId = id;
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

        public override string ToString()
        {
            return $"{Shipment} has {AdditionalService.AdditionalServiceName} additional service";
        }
    }
}
