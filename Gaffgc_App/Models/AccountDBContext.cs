using Microsoft.AspNet.Identity.EntityFramework;

namespace Gaffgc_App.Models
{

    public class GaffgcDBContext : IdentityDbContext<User>
    {

        public virtual LinkTree linktree { get; set; }


        public GaffgcDBContext()
            : base("DefaultConnection")
        {

        }

        public static GaffgcDBContext Create()
        {
            return new GaffgcDBContext();
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("User").Property(p => p.Id).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim").Property(p => p.Id).HasColumnName("UserClaimId");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").Property(p => p.Id).HasColumnName("RoleId");

            modelBuilder.Entity<LinkTree>().ToTable("LinkTree").Property(p => p.id).HasColumnName("id");

        }
    }
}