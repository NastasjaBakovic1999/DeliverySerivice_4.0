﻿using DeliveryServiceDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServiceData
{
    public interface IRepositoryPerson : IRepository<Person>
    {
        public void Add(Person person);
        public void Delete(Person person);
    }
}
