using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
using HospitalProjectHSN.Models;
using System.ComponentModel.DataAnnotations;

namespace HospitalProjectHSN.Data
{
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        //if a doctor (admin) logged in 
        public virtual Doctors Doctor { get; set; }
        //if a patient (user) logged in
        public virtual Patients Patient { get; set; }
    }
    public class hospital_context : IdentityDbContext<ApplicationUser>
    {
        public hospital_context() : base("name:hospital_context")
        {
        }

        public static hospital_context Create()
        {
            return new hospital_context();
        }
        public System.Data.Entity.DbSet<HospitalProjectHSN.Models.Appointments> Appointments { get; set; }
        public System.Data.Entity.DbSet<HospitalProjectHSN.Models.Departments> Departments { get; set; }
        public System.Data.Entity.DbSet<HospitalProjectHSN.Models.Doctors> Doctors { get; set; }
        public System.Data.Entity.DbSet<HospitalProjectHSN.Models.Patients> Patients { get; set; }
    }

}