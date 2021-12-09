namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoneJob")]
    public partial class DoneJob
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long JobID { get; set; }

        public long RecordID { get; set; }

        public int? RealQuantity { get; set; }

        [StringLength(20)]
        public string SoLoSanPham { get; set; }

        public long? AppliedProduct { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
