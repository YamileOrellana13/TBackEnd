﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    using System.Data.Entity;

    public class DataContextSale:DbContext
    {
        public DataContextSale():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API.Models.Sale> Sales { get; set; }
    }
}