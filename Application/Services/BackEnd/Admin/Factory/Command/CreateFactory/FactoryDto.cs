using System.ComponentModel.DataAnnotations;

namespace Application.Services.BackEnd.Admin.Factory.Command.CreateFactory
{
    public class FactoryDto
    {
        public int Id { get; set; }
        
        [Display(Name = "نام کارخانه تولیدی")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        public string Name { get; set; }
    }
}