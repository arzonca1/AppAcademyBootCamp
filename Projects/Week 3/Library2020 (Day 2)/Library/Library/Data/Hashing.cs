﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BCrypt.Net; 

namespace Library.Data
{
    public class Hashing
    {
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt(12));
        }

        public static bool BCrypt.Net.BCrypt.ValidatePassword(string password, string correctHash)
        {

        }
    }
}