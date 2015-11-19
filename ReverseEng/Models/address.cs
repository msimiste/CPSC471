namespace ReverseEng
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test.address")]
    public partial class address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int address_id { get; set; }

       // [Column("address", TypeName = "text")]
        [StringLength(65535)]
        public string address1 { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string address2 { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string district { get; set; }

        public int? city_id { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string postal_code { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string phone { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string last_update { get; set; }
    }
}
