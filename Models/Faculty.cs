using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thi_.Net.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}