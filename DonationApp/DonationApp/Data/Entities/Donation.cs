using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationApp.Models;

namespace DonationApp.Data.Entities
{
    public class Donation
    {
        public long Id { get; set; }
        public string Serial { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public int? DistrictId { get; set; }
        public District District { get; set; }
        public string Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int? Status { get; set; }
        public int EnoughFor { get; set; }
        public DateTime PreparedDate { get; set; }
        public string ExtraNotes { get; set; }
        public DateTime? CreatedOn { get; set; }
        public List<DonationAttachment> DonationAttachments { get; set; }
    }
}
