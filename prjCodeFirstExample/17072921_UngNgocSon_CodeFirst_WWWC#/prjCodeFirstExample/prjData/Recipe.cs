using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace prjData
{
    [Table("Recipes")]
    public class Recipe
    {
        [Key]
        public int repID { get; set; }
        [Required]
        [Column(TypeName ="nvarchar")]
        [StringLength(50)]
        public string Title { get; set; }
        
        [Column(TypeName = "nvarchar")]
        [StringLength(250)]
        public String Content { get; set; }
     
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
