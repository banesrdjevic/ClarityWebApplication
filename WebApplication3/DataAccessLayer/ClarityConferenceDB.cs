namespace WebApplication3.DataAccessLayer
{
    using System.Data.Entity;

    public partial class ClarityConferenceDB : DbContext
    {
        public ClarityConferenceDB()
            : base("name=ClarityConferenceDB")
        {
        }

        public virtual DbSet<Attendee> attendees { get; set; }
        public virtual DbSet<Client> clients { get; set; }
        public virtual DbSet<Conference> conferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<Attendee>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<Attendee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.adr_street)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.adr_city)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.adr_state)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.adr_street)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.adr_city)
                .IsUnicode(false);

            modelBuilder.Entity<Conference>()
                .Property(e => e.adr_state)
                .IsUnicode(false);
        }
    }
}
