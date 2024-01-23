using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetById(int id);
        void add(Customer customers);
        void Delete(Customer customers);
        void update(Customer customers);
    }
}
