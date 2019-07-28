namespace MVCCrud
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logs_Table
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? DirectorId { get; set; }

        public int? Field { get; set; }

        [StringLength(20)]
        public string FromEvent { get; set; }

        [StringLength(20)]
        public string ToEvent { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateAndTime { get; set; }
    }
}
