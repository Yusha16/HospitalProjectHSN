using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalProjectHSN.Models
{
    public class Appointments
    {
        [Key]
        public int appointmentId { get; set; }
        public DateTime appointmentDate { get; set; }
        public int appointmentReferenceNumebr { get; set; }
        //Representing the One doctor (One doctor to many appointment)
        public int doctorId { get; set; }
        [ForeignKey("doctorId")]
        public virtual Doctors Doctor { get; set; }
        //Representing the One patient (One patient to many appointment)
        public int patientId { get; set; }
        [ForeignKey("patientId")]
        public virtual Patients Patient { get; set; }
    }
}