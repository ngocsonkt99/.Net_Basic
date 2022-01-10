using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Saches")]
    public class Sach
    {
        public int Id { get; set; }
      
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Ten { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Gia { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string NoiDung { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string HinhAnh { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Loai { set; get; }

        public int LoaiSachId { set; get; }

        public virtual LoaiSach LoaiSach { set; get; }

    }
}
