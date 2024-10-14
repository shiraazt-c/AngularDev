using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EIS.BOL
{
    [Table("Quote")]
    public partial class Quote
    {
        [Key]
        public int QuoteId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string QuoteText { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Author { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(300)]
        public string Info { get; set; }

    }
}
