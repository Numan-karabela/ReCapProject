using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreet
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customer;

        public CustomerManager(ICustomerDal customer)
        {
            _customer = customer;
        }

        public void add(Customer customers)
        {
            _customer.Add(customers);
        }

        public void Delete(Customer customers)
        {
            _customer.Delete(customers);
        }

        public List<Customer> GetAll()
        {
           return _customer.GetAll();
        }

        public List<Customer> GetById(int id)
        {
          return  _customer.GetAll(p=>p.Id==id);
        }

        public void update(Customer customers)
        {
            _customer.Update(customers);
        }
    }
}
