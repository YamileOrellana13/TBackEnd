﻿namespace API.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API.Models.Product> Products { get; set; }
    }
}