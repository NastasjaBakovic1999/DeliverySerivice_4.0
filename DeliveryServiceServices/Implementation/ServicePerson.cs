﻿using AutoMapper;
using DataTransferObjects;
using DeliveryServiceApp.Services.Interfaces;
using DeliveryServiceData.UnitOfWork;
using DeliveryServiceDomain;
using System.Collections.Generic;

namespace DeliveryServiceApp.Services.Implementation
{
    public class ServicePerson : IServicePerson
    {
        private readonly IPersonUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        // test services
        public ServicePerson(IPersonUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public PersonDto FindByID(int id, params int[] ids)
        {
            var person = unitOfWork.Person.FindOneByExpression(p => p.Id == id);
            return mapper.Map<PersonDto>(person);
        }

        public List<PersonDto> GetAll()
        {
            var persons = unitOfWork.Person.GetAll();
            return mapper.Map<List<PersonDto>>(persons);
        }
    }
}
