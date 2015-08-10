using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data;
using System.Configuration;
using CodedHomes.Models;

namespace CodedHomes.Data
{
    public class DataContext : DbContext 
    {
        public DbSet<Home> Homes { get; set; }
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Este metodo permite retornar la cadena de conexion del aplicativo. 
        /// La configuracion se hace dinamica para compilacion y produccion -  es una recomendacion
        /// </summary>
        //public static string ConnectionStringName
        //{
        //    get {
        //        if (ConfigurationManager.AppSettings["ConnectionStringName"] != null)		
        //	  return ConfigurationManager.AppSettings["ConnectionStringName"].ToString();	      
        //        return "DefaultConnection";
        //    }
        //}

        public DataContext() : base("name=DefaultConnection") //base(nameOrConnectionString: DataContext.ConnectionStringName)
        {  
	  Database.SetInitializer(new Configuration.CustomDatabaseInitializer());
        }

        //public DataContext()  { }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //}

        private void ApplyRules() {
	  foreach (var entry in this.ChangeTracker.Entries().Where(e => e.Entity is IAuditInfo && (e.State == EntityState.Added) || (e.State == EntityState.Modified))){
	      IAuditInfo e = (IAuditInfo)entry.Entity;
	      if (entry.State == EntityState.Added)
		e.CreatedOn = DateTime.Now;
	      e.ModifiedOn = DateTime.Now;
	  }
        }

        public override int SaveChanges()
        {
	  this.ApplyRules();
	  return base.SaveChanges();
        }
    }

}
