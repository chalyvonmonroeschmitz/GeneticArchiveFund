using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gaffgc_App.Models
{

    public class SecurityMember : IdentityUserRole
    {
        override
        public string RoleId
        { get; set; }
        override
        public string UserId
        { get; set; }

        public SecurityMember()
        {            
        }

        public SecurityMember(string roleId, string userId)
        {
            RoleId = roleId;
            UserId = userId;
        }

    }
}
