using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Xees")]
    public class Xe
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Ten { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Namsx { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Gia { set; get; }


        [Required]
        [Column(TypeName = "nvarchar")]
        public string HinhAnh { set; get; }

        [Required]
        [Column(TypeName = "nvarchar")]
        public string Loai { set; get; }

        public int LoaiXeId { set; get; }

        public virtual LoaiXe LoaiXe { set; get; }

    }
}
