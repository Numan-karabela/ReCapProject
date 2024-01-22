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

        public void add(Car car)
        {
            _carDal.Add(car);
        }

        public void delete(Car Entity)
        {
            _carDal.Delete(Entity);
        }

        public List<Car> GetAlll()
        {
           return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
           return _carDal.GetAll(p=>p.Id == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public void update(Car Entity)
        {
            _carDal.Update(Entity);
        }
    }
}
