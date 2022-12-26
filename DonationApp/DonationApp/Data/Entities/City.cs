﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationApp.Models;

namespace DonationApp.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEn { get; set; }
    }
}
