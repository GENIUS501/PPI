﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Entidades
{
    public class Helper
    {
     //  internal class Helper
      // {
           public static string EncodePassword(string originalPassword)
           {
               SHA1 sha1 = new SHA1CryptoServiceProvider();

               byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
               byte[] hash = sha1.ComputeHash(inputBytes);

               return Convert.ToBase64String(hash);
           }
       //}
    }
}
