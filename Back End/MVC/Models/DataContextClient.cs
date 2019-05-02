namespace MVC.Models
{
    using System.Data.Entity;

    public class DataContextClient:DbContext
    {
        public DataContextClient():base("DefaultConnection")
        {

        }
    }
}