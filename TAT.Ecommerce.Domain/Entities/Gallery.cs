using TAT.Ecommerce.Domain.Common;
using static TAT.Ecommerce.Domain.Helpers.Enums;

namespace TAT.Ecommerce.Domain.Entities
{
    public class Gallery : BaseEntity
    {

        public string OriginalFileName { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string FileType { get; set; } = string.Empty;
        public string FileSize { get; set; } = string.Empty;
        public EUploadFileStatus? FileStatus { get; set; } = EUploadFileStatus.Active;
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
        public Guid SubCategoryId { get; set; }
        public SubCategory? SubCategory { get; set; }
        public Guid StoreId { get; set; }
        public Store? Store { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }



    }
}
