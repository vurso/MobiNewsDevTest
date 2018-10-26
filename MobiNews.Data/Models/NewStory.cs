namespace MobiNews.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewStory
    {
        [Key]
        public int NewsStoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string NewsStory { get; set; }

        [StringLength(255)]
        public string ImagePath { get; set; }

        public int? SupplierID { get; set; }

        [StringLength(255)]
        public string SupplierStoryRef { get; set; }

        public DateTime AddedDateTime { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
