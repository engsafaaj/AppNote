using AppNote.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Maui.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNote.Data
{
    public class DBContext:DbContext
    {
        // Add Tables
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filename =Path.Combine(path, "AppDBNote.db");

            optionsBuilder.UseSqlite("FileName="+filename);
        }
    }
}
