using System;
using System.Collections.Generic;


namespace Gaffgc_App.Models
{
    
    public class SecurityAuthoriser
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
    
        public virtual Member Member { get; set; }
    }
}
