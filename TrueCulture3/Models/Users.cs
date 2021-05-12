using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrueCulture3.Models
{
    public class Users : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string? ProfilePicture { get; set; }
        
    }
}
