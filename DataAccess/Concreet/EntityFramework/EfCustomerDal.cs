using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreet.EntityFramework
{
    public class EfCustomerDal:EfFrameworkRepositoryBase<Customer,CarContext>,ICustomerDal
    {
    }
}
