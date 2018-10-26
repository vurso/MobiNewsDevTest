namespace MobiNews.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            NewStories = new HashSet<NewStory>();
        }

        public int SupplierID { get; set; }

        [Required]
        [StringLength(256)]
        public string SupplierName { get; set; }

        [Required]
        [StringLength(512)]
        public string NotificationURL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStory> NewStories { get; set; }
    }
}
