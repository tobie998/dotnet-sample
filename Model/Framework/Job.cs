namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public decimal? UnitPrice { get; set; }

        [StringLength(50)]
        public string DonViKhoan { get; set; }

        public double? HeSoKhoan { get; set; }

        public int? DinhMucKhoan { get; set; }

        public int? DinhMucLaoDong { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
