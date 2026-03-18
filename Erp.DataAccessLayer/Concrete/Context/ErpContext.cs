using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

public class ErpContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-SU16M9I9\\VT_SQL;Database=ERP_EGITIM;Integrated Security=True;TrustServerCertificate=True;");
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<City> Cities { get; set; }

}