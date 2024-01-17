// See https://aka.ms/new-console-template for more information


using Business.Concreet;
using DataAccess.Concreet.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());



foreach (var car in carManager.GetAlll())
{

    Console.WriteLine(car.Id);
}