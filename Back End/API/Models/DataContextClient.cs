namespace API.Models
{
    using System.Data.Entity;

    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API.Models.Client> Clients { get; set; }
    }
}