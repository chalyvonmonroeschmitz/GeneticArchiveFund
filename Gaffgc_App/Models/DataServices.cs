using Microsoft.AspNet.Identity.EntityFramework;

namespace Gaffgc_App.Models
{

    public class GaffgcDBContext : IdentityDbContext<Member>
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

            modelBuilder.Entity<Member>().ToTable("Member").Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<IdentityUserRole>().ToTable("MemberRole");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("MemberLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("MemberClaim").Property(p => p.Id).HasColumnName("MemberClaimId");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").Property(p => p.Id).HasColumnName("RoleId");

            modelBuilder.Entity<LinkTree>().ToTable("LinkTree").Property(p => p.id).HasColumnName("id");
        }

    }
}