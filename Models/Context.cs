using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Thi_.Net.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class Context : DbContext
    {
        public Context() : base("name=MyContext")
        {

        }
        public DbSet<Exam> Exams { get; set; }
        public System.Data.Entity.DbSet<Thi_.Net.Models.Faculty> Faculties { get; set; }

        public System.Data.Entity.DbSet<Thi_.Net.Models.SubJect> SubJects { get; set; }

        public System.Data.Entity.DbSet<Thi_.Net.Models.ClassRoom> ClassRooms { get; set; }
    }
}