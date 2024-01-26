// See https://aka.ms/new-console-template for more information


using Business.Concreet;
using DataAccess.Concreet.EntityFramework;
using DataAccess.Concreet.InMemory;
using DataAccess.Context;
using Entities.Concreet;
using System.Reflection;

    CarManager carManager = new CarManager(new EFCarDal());
    CustomerManager  carss = new CustomerManager(new EfCustomerDal());
    UserManager userr= new UserManager(new EfUserDal());



//User user = new User()
//{
//      Email = "numan@gmail.com", FirsName = "Numan", LastName = "Karabela", Password = "asda"
//};

//userr.add(user);


//Customer customer = new Customer()
//{
//    CompanyName="numan",UserId=1
//};


//carss.add(customer);



foreach (var item in userr.GetAll())
{
    Console.WriteLine(item.FirsName);
} 