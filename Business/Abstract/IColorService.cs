using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
        public  interface  IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int id);
        void add(Color color);
        void Delete(Color color);
        void update(Color color);
    }
}
