using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication15.Areas.ProjectManagement.Models;

namespace WebApplication15.Data
{
    public class AppDbContext : IdentityDbContext

    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        
        { 
        
        }

        public DbSet<Project>Projects { get; set; } 
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public DbSet<ProjectComment> ProjectComments { get; set; }
        

    }
}
