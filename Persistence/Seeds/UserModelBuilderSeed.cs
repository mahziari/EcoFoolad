﻿using System;
using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Seeds
{
    public static class UserModelBuilderSeed
    {
        public static void UserSeed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = "5a64e206-d6c0-4386-923f-5104f173e01c",
                    CrmUsersId = 61,
                    FirstName ="حسین" ,
                    LastName = "کرجی",
                    IsActive = true,
                    Address ="تهران" ,
                    UserName ="09129283406" ,
                    NormalizedUserName = "09129283406",
                    EmailConfirmed = false,
                    PasswordHash = "AQAAAAEAACcQAAAAEPbSX2kOSigd6t402PCkp70rA2gX/1xlFFBZJ8pgJxtwKbY2eZ5Tp2qHOrecBHXCQw==",
                    SecurityStamp = "IXN7VEICHYB72KXHBCULEPXFHNZ5U6FS",
                    ConcurrencyStamp = "5927a97d-ea14-4449-9efa-7d5ab4b957e5" ,
                    PhoneNumber = "09129283405",
                    PhoneNumberConfirmed =true ,
                    TwoFactorEnabled = false,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    DataCreated =DateTime.Now ,
                    RequestToBeOwner = false,
                }
            );
        }
    }
}