using DataAccess.Abstract;
using Entities.Concreet;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreet.EntityFramework
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car Entity)
        {
            using(CarContext context=new CarContext())
            {
                var addedEntity=context.Entry(Entity);
                addedEntity.State= EntityState.Added;
                context.SaveChanges();


            }
        }

        public void Delete(Car Entity)
        {
            using (CarContext context = new CarContext())
            {
                var deleteEntity = context.Entry(Entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();


            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (CarContext context = new CarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            
            using(CarContext context = new CarContext())
            {
                return filter==null ? context.Set<Car>().ToList():context.Set<Car>().Where(filter).ToList();
            }


        }

        public void Update(Car Entity)
        {
            using (CarContext context = new CarContext())
            {
                var updateEntity = context.Entry(Entity);
                updateEntity.State = EntityState.Modified;
                
                context.SaveChanges();


            }
        }
    }
}
