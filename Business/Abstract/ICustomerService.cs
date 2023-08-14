﻿using Entities;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
        Customer GetById(int id);
    }
}
