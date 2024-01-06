using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TAT.Ecommerce.Domain.Entities

{
    [Table("TAT_Brands")]
    public class TAT_Brand
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }



        [Required(ErrorMessage = "Vui lòng nhập tên")]
        [StringLength(250, ErrorMessage = "{0} up to {1} characters")]
        public string? Name { get; set; }


        public string? BrandNameSearch { get; set; }



        [Display(Name = "Mô tả")]
        public string? Description { get; set; }



        [Display(Name = "Ảnh Thumbnail")]
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = "png,jpg,jpeg,gif")]

        public string? Thumb { get; set; }

        [Display(Name = "Ảnh nền")]
        [DataType(DataType.Upload)]
        [FileExtensions(Extensions = "png,jpg,jpeg,gif")]


        public string? Cover { get; set; }



    }
}
