using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreet
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string CompanyName { get; set; }




    }
}
