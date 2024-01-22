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
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color)
        {
            _color = color;
        }

        public void add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            _color.Delete(color);
        }

        public List<Color> GetAll()
        {
          return  _color.GetAll();
        }

        public List<Color> GetById(int id)
        {
           return _color.GetAll(p=>p.Id==id);
        }

        public void update(Color color)
        {
            _color.Update(color);
        }
    }
}
