using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("LoaiXees")]
    public class LoaiXe
    {
        public int Id { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenLoai { set; get; }

        public virtual ICollection<Xe> Xees { set; get; }
    }
}
