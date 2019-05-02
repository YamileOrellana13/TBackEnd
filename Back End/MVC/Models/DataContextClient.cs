namespace MVC.Models
{
    using System.Data.Entity;

    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC.Models.Client> Clients { get; set; }
    }
}