namespace WFAPersonelTakibi.Dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WFAPersonelTakibi.Model;

    public class ProjectContext__ : DbContext
    {
       
        public ProjectContext__()
            : base("name=ProjectContext()")
        {
           
        }
        public  virtual DbSet<Employee> Employees { get; set; }

    }

     
    
}