using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ParsaPoolad.Domain.Entities.Identity;

namespace EndPoint.Web.Areas.Auth.Helpers{
    public class PasswordValidator:IPasswordValidator<User>
    {
        List<string> PasswordList = new List<string>()
        {
            "password","123456789","11111111"
        };
        

        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            if(PasswordList.Contains(password))
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