﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalClases.Models
{
    public class DbInitializer
    {
        public static async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            var roles = new List<string>() { "Admin" };

            foreach(var item in roles)
            {
                if(!await RoleManager.RoleExistsAsync(item))
                {
                    await RoleManager.CreateAsync(new IdentityRole(item));
                }
            }
            IdentityUser user = await UserManager.FindByEmailAsync("todosobrejuegos98@gmail.com");
            await UserManager.AddToRoleAsync(user,"Admin");
        }
    }
}
