using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProject.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Grade { get; set; }
    }
}