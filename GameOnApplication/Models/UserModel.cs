﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameOnApplication.Models
{
    public class UserModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string contactnum { get; set; }
        public int id { get; set; }
    }
}