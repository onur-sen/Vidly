﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Vidly.Models;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;
namespace Vidly.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string DrivingLicense { get; set; }


        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
    }
}