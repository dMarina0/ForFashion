﻿

using BusinessObjects.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ApplicationUser : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }

        public bool Active { get; set; }

        public UserDetails UserDetails { get; set; }

        //public int DetailsID { get; set; }
        //[ForeignKey("DetailsID")]
        //public virtual UserDetails UserDetails { get; set; }

    }


    //public class UserDetails
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }

    //    public string LastName { get; set; }
    //    public string City { get; set; }
    //    public string Address { get; set; }
    //    public string PhoneNumber { get; set; }
    //    //[ForeignKey("ApplicationUser")]
    //    //public string IdUser { get; set; }
    //    [Required]
    //    public virtual ApplicationUser ApplicationUser { get; set; }

    //}

 
   


}