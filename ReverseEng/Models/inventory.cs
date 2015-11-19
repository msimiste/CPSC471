namespace ReverseEng.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("test.inventory")]
    public partial class inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inventory_id { get; set; }

        public int? film_id { get; set; }

        public int? store_id { get; set; }

        //[Column(TypeName = "text")]
        [StringLength(65535)]
        public string last_update { get; set; }
    }
}
