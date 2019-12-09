using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Thi_.Net.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        
        public int SubJectId { get; set; }
        public virtual SubJect SubJect { get; set; }
        public int ClassRoomId { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        
        public int Start_Time { get; set; }
        
        public DateTime Exam_Date { get; set; }
        public int Duration { get; set; }
        public ExamStatus Status { get; set; }
        public enum ExamStatus
        {
            Up_Coming = 2, Done = 1, On_Going = 0
        }
       
    }
}