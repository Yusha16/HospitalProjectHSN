using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalProjectHSN.Models
{
    public class Departments
    {
        [Key]
        public int departmentId { get; set; }
        public string departmentName { get; set; }
    }
}