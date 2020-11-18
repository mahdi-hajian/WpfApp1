using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WpfApp1.Models;

namespace WpfApp1.Identity
{
    public class Mcontext: DbContext
    {
        //https://docs.microsoft.com/en-us/dotnet/api/system.configuration.configurationmanager?view=dotnet-plat-ext-5.0
        public Mcontext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["AirCraftSqlServer"].ConnectionString;
            options.UseSqlite("Data Source=blogging.db");
            //options.UseSqlite("Data Source=blogging.db");
        }

        public DbSet<Jumper> Jumpers { get; set; }
    }
}
