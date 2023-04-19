using DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DeliveryServiceApp.Services.Interfaces
{
    public interface IServiceAddionalServiceShipment : IService<AdditionalServiceShipmentDto>
    {
        //test
        public void Add(AdditionalServiceShipmentDto additionalServiceShipment);
    }
}
