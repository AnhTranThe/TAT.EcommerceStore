using System.ComponentModel.DataAnnotations;
using TAT.Ecommerce.Domain.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    public class TAT_UploadFile
    {
        [Key]
        [Display(Name = "ID")]

        public int Id { get; set; }

        [Display(Name = "File Name")]
        public string? FileName { get; set; }





        [Display(Name = "File Path")]
        public string? FilePath { get; set; }


        [Display(Name = "Status")]
        public EUploadFileStatus? FileStatus { get; set; }


        [Display(Name = "Status Description")]
        public string? FileStatusDesc { get; set; }


        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateDate { get; set; } = DateTime.Now;


        public string? AccountId { get; set; }


        public virtual TTA_Account? Account { get; set; }


        public bool SelectedMainImg { get; set; } = false;

        public int? ProductId { set; get; }

        public virtual TTA_Product? tTA_Product { set; get; }
        public int? PostId { set; get; }

        public virtual TTA_Post? tTA_Post { set; get; }
        public int? BrandId { set; get; }

        public virtual TTA_Brand? tTA_Brand { set; get; }
        public int? CategoryId { set; get; }

        public virtual TTA_Category? tTA_Category { set; get; }

        public int? SubCategoryId { set; get; }

        public virtual TTA_SubCategory? tTA_SubCategory { set; get; }




    }
}
