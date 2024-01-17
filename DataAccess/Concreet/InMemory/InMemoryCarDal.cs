﻿using DataAccess.Abstract;
using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreet.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() {Id=1,BrandId=1,ColorId=1, DailyPrice=1,Description="BMW",ModelYear=2000},
                new Car() {Id=2,BrandId=2,ColorId=2, DailyPrice=2,Description="AUİD",ModelYear=2002},
                new Car() {Id=3,BrandId=3,ColorId=3, DailyPrice=3,Description="Mc",ModelYear=2003},
                new Car() {Id=4,BrandId=4,ColorId=4, DailyPrice=4,Description="BMW",ModelYear=2004},
                new Car() {Id=5,BrandId=5,ColorId=5, DailyPrice=5,Description="BMW",ModelYear=2005},


            };
        }
        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car delete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(delete);
        }

        public List<Car> Getall()
        {
            return _cars;
        }

        public void GetById(int id)
        {
            Car car = _cars.FirstOrDefault(p=>p.Id==id);
            
        }

        public void Update(Car car)
        {
            Car update = _cars.SingleOrDefault(p => p.Id == car.Id);
            update.BrandId= car.BrandId;
            update.ColorId= car.ColorId;
            update.DailyPrice= car.DailyPrice;
            update.Description= car.Description;
            update.ModelYear= car.ModelYear;
             


        }
    }
}