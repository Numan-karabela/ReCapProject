﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreet
{
    public class Rental:IEntity
    {
        public int Id { get; set; }
        public int CarId{ get; set; }
        public int  CustomerId{ get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
