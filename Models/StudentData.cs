using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesManyToMany.Models
{
    public class StudentData
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public Student Student { get; set; }
    }
}
