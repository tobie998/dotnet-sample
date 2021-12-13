namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssignRecord")]
    public partial class AssignRecord
    {
        public long ID { get; set; }

        [Display(Name = "Ngày Thực Hiện Khoán")]
        [DataType(DataType.Date)]
        public DateTime? WorkDate { get; set; }

        [StringLength(3)]
        [Display(Name = "Giờ Bắt Đầu")]
        public string StartTime { get; set; }

        [StringLength(3)]
        [Display(Name = "Giờ Kết Thúc")]
        public string EndTime { get; set; }

        [StringLength(5)]
        [Display(Name = "Ca Làm")]
        public string Shift { get; set; }

        public int? DisplayOrder { get; set; }

        [StringLength(250)]
        public string MetaTitle { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        public string MetaKeyword { get; set; }

        [StringLength(250)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }

        public bool? ShowOnHome { get; set; }
    }
}
