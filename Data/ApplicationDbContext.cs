using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurentProjectCore21.Models;
using System;
using System.Collections.Generic;
using System.Text;
using RestaurentProjectCore21.ViewModels;

namespace RestaurentProjectCore21.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<EmployeeVM> employeeVMs { get; set; }
        public DbSet<EmployeeAjax> employeeAjaxes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<RestaurentProjectCore21.ViewModels.EmployeeVM> EmployeeVM { get; set; }
        

    }
}
