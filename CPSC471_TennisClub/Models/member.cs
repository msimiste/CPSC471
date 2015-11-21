namespace CPSC471_TennisClub.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("mydb.member")]
    public partial class member
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int memberID { get; set; }

        [StringLength(45)]
        public string rating { get; set; }

        [StringLength(45)]
        public string phonenumber { get; set; }

        [StringLength(45)]
        public string firstname { get; set; }

        [StringLength(45)]
        public string middlename { get; set; }

        [StringLength(45)]
        public string lastname { get; set; }

        //[Column(TypeName = "date")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime? renewaldate { get; set; }

        [StringLength(45)]
        public string streetname { get; set; }

        [StringLength(45)]
        public string streetnum { get; set; }

        //[Column(TypeName = "date")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime? datejoined { get; set; }

        [StringLength(10)]
        public string postalCode { get; set; }

        [StringLength(45)]
        public string city { get; set; }
    }
}
