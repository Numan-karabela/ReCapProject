﻿using Entities.Concreet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
     public  interface ICarService
    {
        List<Car> GetAlll(); 
        List<Car> GetById(int id);
        

    }
}
