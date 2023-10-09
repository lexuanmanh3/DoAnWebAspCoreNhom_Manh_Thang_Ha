using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHangManh_Thang.Models
{
    public class MauSac
    {
        [Key]
        public int IdMauSac { get; set; }
        [Required]
        public string TenMau { get; set; }
    }
}
