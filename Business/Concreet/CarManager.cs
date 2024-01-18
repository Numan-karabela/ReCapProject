using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreet.EntityFramework;
using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreet
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal ıcarDal)
        {
            _carDal = ıcarDal;
        }

        public List<Car> GetAlll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
           return _carDal.GetAll(p=>p.BrandId == id);
        }
    }
}
