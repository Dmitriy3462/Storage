﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.DAL.Models
{
    public class User
    {
        public string FullName { get; set; }
        public string?Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string ShippingAdress { get; set; }

        // TODO: Реализация покупки клиентом товара              



    }
}
