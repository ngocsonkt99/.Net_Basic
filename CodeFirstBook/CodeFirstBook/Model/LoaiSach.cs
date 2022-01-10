using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("LoaiSaches")]
    public class LoaiSach
    {
        public int Id { set; get; }
        
        [Required]
        [Column(TypeName="nvarchar")]
        public string TenLoai { set; get; }

       public virtual ICollection<Sach> Saches { set; get; }
    }
}
