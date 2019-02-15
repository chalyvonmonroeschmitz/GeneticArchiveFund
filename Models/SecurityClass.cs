using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaffgc_App.Models
{


    public class SecurityClass : IdentityRole
    {

        public ICollection<Member> members { get; set; }
        // Identity Role has a collection of Users ICollection<Users>        
        public SecurityClass(string roleName) : base(roleName)
        {
            IEnumerator<IdentityUserRole> iter = Users.GetEnumerator();
            while (iter.MoveNext())
            {
                if (iter.Current.RoleId == this.Id)
                    members.Add(GaffgcDBContext.Create().Users.Find(iter.Current.UserId));
            }
        }
    }
}
