using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaffgc_App.Models
{
    public class Dna
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string storageID { get; set; }

        public string barCode { get; set; }        
        public string location { get; set; }
        public bool hasMatch { get; set; }
        public bool belongsToMember { get; set; }
        public string dnaSequence { get; set; }

    }
}
