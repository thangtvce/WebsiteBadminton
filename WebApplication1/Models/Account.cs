﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool Active { get; set; }
        public string FullName { get; set; }
        public int? RoleID { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }
        public virtual Roles Role { get; set; }

    }
}
