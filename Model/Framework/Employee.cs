namespace Model.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public long ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        public long? TeamID { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [StringLength(250)]
        public string Position { get; set; }

        public bool? Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string HomeTown { get; set; }

        public decimal? ContractWage { get; set; }

        public decimal? InsuranceWage { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
