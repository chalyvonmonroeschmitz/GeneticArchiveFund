using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Linq;

namespace Gaffgc_App.Models
{

    // Overrides for IdentityDbContext<TUser> Asp Identity for context roles
    public class GaffgcDBContext : IdentityDbContext<Member>
    {
        // Collection of Roles and IdentityUserRoles have been provided by IdentityDbContext
        public override IDbSet<Member> Users { get; set; }
        public IDbSet<Dna> DnaStore { get; set; }
        public IDbSet<FamilyMember> Families { get; set; }
        // inherit and override from IdentityUserRoles
        public IDbSet<SecurityClass> SecurityClasses { get; set; }
        public IDbSet<SecurityMember> SecurityMembers { get; set; }

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

            modelBuilder.Entity<Member>().ToTable("Member").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<Dna>().ToTable("Dna").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<IdentityRole>().ToTable("SecurityClass").Property(p => p.Id).HasColumnName("RoleId");
            modelBuilder.Entity<IdentityUserRole>().ToTable("SecurityMembership").Property(p => p.UserId).HasColumnName("UserId");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("SecurityAuthoriser");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("SecurityClaim").Property(p => p.Id).HasColumnName("SecurityClaimId");
            modelBuilder.Entity<LinkTree>().ToTable("LinkTree").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<FamilyMember>().ToTable("FamilyMember").Property(p => p.Id).HasColumnName("Id");
            modelBuilder.Entity<FamilyTree>().ToTable("FamilyTree").Property(p => p.Id).HasColumnName("Id");
            
        }

        public IQueryable<FamilyMember> GetFamilies(string memberId)
        {
            return Families.Where(p => p.Id == memberId);
        }

        public IQueryable<Dna> GetMemberMatch(string memberID)
        {
            return DnaStore.Where(p => p.hasMatch == true && p.Id == memberID);
        }

        public IQueryable<Dna> GetDnaLinks(string dnaID)
        {
            return DnaStore.Where(p => p.hasMatch == true && p.Id == dnaID);
        }
    }
}