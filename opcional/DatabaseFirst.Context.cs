

namespace opcional
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class databaseFirstEntities1 : DbContext
    {
        public databaseFirstEntities1()
            : base("name=databaseFirstEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Funcionarios> Funcionarios { get; set; }
    }
}
