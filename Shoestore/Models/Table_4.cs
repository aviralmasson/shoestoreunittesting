namespace Shoestore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_4
    {
        [Key]
        public int footsize { get; set; }

        [Required]
        [StringLength(50)]
        public string models { get; set; }

        public int price { get; set; }

        public int rating { get; set; }
    }
}
