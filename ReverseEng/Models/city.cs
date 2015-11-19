namespace ReverseEng.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test.city")]
    public partial class city
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int city_id { get; set; }

        //[Column("city", TypeName = "text")]
        [StringLength(65535)]
        public string city1 { get; set; }

        public int? country_id { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string last_update { get; set; }
    }
}
