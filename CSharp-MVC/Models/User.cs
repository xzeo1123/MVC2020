﻿namespace CSharp_MVC.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}
