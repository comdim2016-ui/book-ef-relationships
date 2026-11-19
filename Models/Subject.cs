using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesManyToMany.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = null!;
    }
}
