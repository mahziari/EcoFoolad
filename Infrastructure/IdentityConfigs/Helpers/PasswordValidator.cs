using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.IdentityConfigs.Helpers{
    public class PasswordValidator:IPasswordValidator<User>
    {
        private readonly IWebHostEnvironment _environment;
        public PasswordValidator(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            string filePath = @"PasswordList.txt";
            var folderPath = Path.Combine(_environment.WebRootPath, filePath);
            List<string> passwordList = File.ReadAllLines(folderPath).ToList();
        
            if(passwordList.Contains(password))
            {
                var result = IdentityResult.Failed(new IdentityError
                {
                    Code = "CommonPassword",
                    Description = "پسورد شما خیلی ساده است! لطفا یک پسورد قوی انتخاب کنید",
                });
                return Task.FromResult(result);
            }
            return Task.FromResult(IdentityResult.Success);
        }
        
    }
}