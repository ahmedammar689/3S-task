using Domain1.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1.Data;
public class AppIdentityDbContextSeed
{
    public static async Task SeedAsync(UserManager<AppUser> _userManager)
    {
        if (_userManager.Users.Count()==0)
        {
            var user = new AppUser
            {
                FirstName = "Ahmed",
                MiddleName = "Ammar",
                LastName = "Ali",
                UserName = "ahmed",
                Email = "ahmedammar@gmail.com",
            
                MobileNumber = "123456789",
             


            };
            await _userManager.CreateAsync(user, "P@ssw0rd");
        }
    }
}
