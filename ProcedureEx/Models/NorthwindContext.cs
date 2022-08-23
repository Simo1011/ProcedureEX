using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
namespace ProcedureEx.Models
{
    public partial class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
        }

        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<Customer> Customers { get; set; } = null!;


        public IQueryable<Customer> SearchCustomers(string contactName)
        {
            SqlParameter pContactName = new SqlParameter("@ContactName", contactName);
            return this.Customers.FromSqlRaw("EXECUTE Customers_SearchCustomers @ContactName", pContactName);
        }



    }
}
