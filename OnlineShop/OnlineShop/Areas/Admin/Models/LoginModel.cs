﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Moi nhap user name")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Moi nhap password")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }
    }
}