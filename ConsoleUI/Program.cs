// See https://aka.ms/new-console-template for more information


using Business.Concreet;
using DataAccess.Concreet.EntityFramework;
using DataAccess.Concreet.InMemory;

CarManager carManager = new CarManager(new EFCarDal());


foreach (var car in carManager.GetAlll())
{

    Console.WriteLine(car.DailyPrice);
}


 