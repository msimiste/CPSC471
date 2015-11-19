namespace ReverseEng
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sakila.actor")]
    public partial class actor
    {
        //[Key]
        //[Column(TypeName = "usmallint")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int actor_id { get; set; }

        [Required]
        [StringLength(45)]
        public string first_name { get; set; }

        [Required]
        [StringLength(45)]
        public string last_name { get; set; }

        //[Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime last_update { get; set; }
    }
}
