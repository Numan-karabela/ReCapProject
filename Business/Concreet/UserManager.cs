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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void add(User users)
        {
            _userDal.Add(users);
        }

        public void Delete(User users)
        {
            _userDal.Delete(users);
        }

        public List<User> GetAll()
        {
           return _userDal.GetAll();
        }

        public List<User> GetById(int id)
        {
            return _userDal.GetAll(p=>p.Id==id);
        }

        public void update(User users)
        {
            _userDal.Update(users);
        }
    }
}
