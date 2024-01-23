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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public void add(Rental rental)
        {
            _rentalDal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
        }

        public List<Rental> GetAll()
        {
           return _rentalDal.GetAll();
        }

        public List<Rental> GetById(int id)
        {
           return _rentalDal.GetAll(p=>p.Id==id);
        }

        public void update(Rental rental)
        {
            _rentalDal.Update(rental);
        }
    }
}
