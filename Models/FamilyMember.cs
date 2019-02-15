using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaffgc_App.Models
{

    public class FamilyMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string Relation { get; set; }
        public string Location { get; set; }
        
        public bool hasDNA { get; set; }
        // Nullable Foreign Key
        public virtual Dna dna { get; set; }

        // Can not exist without Member
        [Required]
        public virtual Member member { get; set; }
       
    }
}
