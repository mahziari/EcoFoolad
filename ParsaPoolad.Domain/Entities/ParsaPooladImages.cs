using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace ParsaPoolad.Domain.Entities
{
    public class ParsaPooladImages
    {
        public int ParsaPooladImagesId { get; set; }
        
        [Display(Name = "تصویر")]
        [Required(ErrorMessage = ",وارد کردن {0} اجباری است")]
        [Column(TypeName = "nvarchar(500)")]
        public string ImageName { get; set; }
        
        
        [Display(Name = "عنوان تصویر")]
        [Required(ErrorMessage = "پر کردن فیلد {0} اجباری است")]
        [StringLength(250, ErrorMessage = "تعداد کاراکتر بیش از حد مجاز")]
        [Column(TypeName = "nvarchar(50)")]
        public string ImageTitle { get; set; }
        
     
        public string ImageDescription { get; set; }
        public string ImageType { get; set; }
        
        // [Required(ErrorMessage = "Please select a file.")]
        // [DataType(DataType.Upload)]
        // public IFormFile file { get; set; }
        
    }
}