﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHangManh_Thang.Models
{
    public class DanhMucSP
    {
        [Key]
        public string IdDanhMucSP { get; set; }
        [Required]
        public string TenDanhMucSP { get; set; }
    }
}
