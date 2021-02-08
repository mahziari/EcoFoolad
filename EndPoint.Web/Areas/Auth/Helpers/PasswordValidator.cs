using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Domain.Entities.Identity;

namespace EndPoint.Web.Areas.Auth.Helpers{
    public class PasswordValidator:IPasswordValidator<User>
    {
        // List<string> PasswordList = new List<string>()
        // {
        //     "password","123456789","11111111"
        // };
        
        private readonly IWebHostEnvironment _environment;
        public PasswordValidator(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            string filePath = @"BackEnd/PasswordList.txt";
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