using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Thi_.Net.Models
{
    public class Thi_NetContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Thi_NetContext() : base("name=Thi_NetContext")
        {
        }

        public System.Data.Entity.DbSet<Thi_.Net.Models.Exam> Exams { get; set; }

        public System.Data.Entity.DbSet<Thi_.Net.Models.Faculty> Faculties { get; set; }

        public System.Data.Entity.DbSet<Thi_.Net.Models.SubJect> SubJects { get; set; }

        public System.Data.Entity.DbSet<Thi_.Net.Models.ClassRoom> ClassRooms { get; set; }
    }
}
