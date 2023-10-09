﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHangManh_Thang.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }

    }
}
