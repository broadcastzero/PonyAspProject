using System.Data.Entity;
using PonyApplication.DAL.Models;

namespace PonyApplication.DAL.Data
{
    public class EfDataContext : DbContext
    {
         public EfDataContext()
             : base("DB")
         { }

         public IDbSet<Pony> Ponies { get; set; }
    }
}