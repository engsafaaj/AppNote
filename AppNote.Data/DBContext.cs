using AppNote.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNote.Data
{
    public class DBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var sqlcon = "Server=DBNOTEDEMO.mssql.somee.com;Encrypt=Ture;TrustServerCertificate=True;MultiSubnetFailover=True;TLS Version=1.2;user id=safaa_SQLLogin_1;pwd=qm51qz2uey;data source=DBNOTEDEMO.mssql.somee.com;persist security info=False;initial catalog=DBNOTEDEMO";
           // optionsBuilder.UseSqlServer(@"Data Source=safaa\SQLEXPRESS,1433; TrustServerCertificate=True; MultiSubnetFailover=True; Initial Catalog=DBNote; User ID=sa; Password=12345");
            optionsBuilder.UseSqlServer(sqlcon);
        }
        public DbSet<Note> MyProperty { get; set; }
    }
}
