using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationApp.Models;

namespace DonationApp.Data.Entities
{
    public class DonationAttachment
    {
        public int Id { get; set; }
        public long? DonationId { get; set; }
        public Donation Donation { get; set; }
        public string Src { get; set; }
    }
}
