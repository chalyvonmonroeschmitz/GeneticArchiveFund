using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaffgc_App.Models
{

    public class FamilyTree
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        [ForeignKey("Id")] // can not exist without Member
        public Member member { get; set; }
        
        // One to Many Relation on FamilyMember
        public ICollection<FamilyMember> Tree { get; set; }

        public bool addFamily(string familyMemberId)
        {
            GaffgcDBContext db = new GaffgcDBContext();
            FamilyMember family = db.Families.Find(familyMemberId);
            if(familyMemberId != null)
            {
                Tree.Add(family);
                return true;
            }else
            {
                return false;
            }
        }
    }
}
