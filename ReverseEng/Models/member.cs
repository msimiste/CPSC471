namespace ReverseEng
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test.member")]
    public partial class member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int memberID { get; set; }

        [StringLength(45)]
        public string firstName { get; set; }

        [StringLength(45)]
        public string lastName { get; set; }

        [StringLength(8)]
        public string postalCode { get; set; }

        [StringLength(15)]
        public string phoneNumber { get; set; }
    }
}
