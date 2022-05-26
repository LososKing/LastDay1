using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WinFormsApp1_LastDay1.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int IdRole { get; set; }
        
    }
}
