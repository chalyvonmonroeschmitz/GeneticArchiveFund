using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Gaffgc_App.Models
{


    public partial class Member : IdentityUser
    {
       
        public string UserNameOption { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthday { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        public string Country { get; set; }
        public string Discriminator { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string Profession { get; set; }
        public string Profession2 { get; set; }
        public string Language { get; set; }
        public string Religion { get; set; }
        public string Lineage { get; set; }
        public string Location { get; set; }


        public bool dnaConfirmed { get; set; }
        // Nullable Foreign Membership
        public virtual Dna dna { get; set; }

        // One to Many relationship on FamilyMembers
        public virtual ICollection<FamilyMember> familyMembers { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Member> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public void setBirthDay(DateTime date)
        {
            this.Birthday = new DateTime();
            this.Birthday.ToUniversalTime();
        }

    }
}
