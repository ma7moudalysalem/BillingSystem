using System.Data.Entity;

namespace Bills.DBcontext
{
    public class BillSystemDB : DbContext
    {
        // Your context has been configured to use a 'BillSystemDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Bills.DBcontext.BillSystemDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BillSystemDB' 
        // connection string in the application configuration file.
        public BillSystemDB()
            : base("name=BillSystemDB")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            //modelBuilder.Entity<Company>()
            //    .HasRequired(c => c.company_types)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Type_p> Types { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Invoive_items> Invoive_Items { get; set; }
        public virtual DbSet<Sales_Invoice> Sales_Invoices { get; set; }

    }
}