// See https://aka.ms/new-console-template for more information


using Business.Concreet;
using DataAccess.Concreet.EntityFramework;
using DataAccess.Concreet.InMemory;
using DataAccess.Context;
using Entities.Concreet;



    CarManager carManager = new CarManager(new EFCarDal());
 
Car car1    = new Car();
car1.Id = 2;
 

carManager.delete(car1);

foreach (var car in carManager.GetAlll())
{
    Console.WriteLine(car.Description);

}