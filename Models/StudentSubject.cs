using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesManyToMany.Models
{
    internal class StudentSubject
    {
        public int StudentId{get;set; }
        public int SubjectId { get; set; }
        public DateTime Enrolled { get; set; }
        public int Status { get; set; }
    }
}
