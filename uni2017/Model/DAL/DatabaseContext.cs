using Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class DatabaseContext : DbContext
    {

        //default contructor
        public DatabaseContext() : base("DataBase")
        {

        }



        public DbSet<CF> CF { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<G> G { get; set; }
        public DbSet<PC> PC { get; set; }
        public DbSet<Pre> Pre { get; set; }
        public DbSet<Prof> Prof { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Tution> Tution { get; set; }
        public DbSet<TypeU> TypeU { get; set; }






    }
}
