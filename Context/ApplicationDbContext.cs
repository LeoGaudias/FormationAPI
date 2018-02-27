using FormationApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FormationApi.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DbSet<Person> Persons { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DbSet<ContactInfoPro> ContactInfoPros { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DbSet<ContactInfoPerso> ContactInfoPersos { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DbSet<Geo> Geos { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DbSet<Skill> Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<ContactInfoPro>().ToTable("ContactInfoPro");
            modelBuilder.Entity<ContactInfoPerso>().ToTable("ContactInfoPerso");
            modelBuilder.Entity<Geo>().ToTable("Geo");
            modelBuilder.Entity<Skill>().ToTable("Skill");
        }
    }
}