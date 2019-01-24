using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DBRepo:DbContext
    {
        public DBRepo(): base("Default")
        {

        }
        public DbSet<Demo> DemoTable{ get; set; }


    }

    public class Demo
    {
        public int Id { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }


}