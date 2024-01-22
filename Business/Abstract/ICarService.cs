using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public  interface ICarService
    {
        List<Car> GetAlll(); 
        List<Car> GetById(int id);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void add(Car car);
        void delete(Car Entity);
        void update(Car Entity);
        

    }
}
