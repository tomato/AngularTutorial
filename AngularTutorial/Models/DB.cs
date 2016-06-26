namespace AngularTutorial.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DB : DbContext
    {
        
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Sprint> Sprints { get; set; }
    }

    
}