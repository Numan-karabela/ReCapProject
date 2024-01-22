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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void add(Brand brand)
        {
            _brandDal.Add(brand);
        }
        public void update(Brand brand)
        {
            _brandDal.Update(brand);
        }
        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
         
        public List<Brand> GetAll()
        {
          return _brandDal.GetAll();
        }

        public List<Brand> GetById(int id)
        {
           return _brandDal.GetAll(p=>p.Id==id);
        }

      
    }
}
