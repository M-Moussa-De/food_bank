using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DonationApp.Models
{
    public class DonationViewModel
    {
        public long Id { get; set; }
        public string Serial { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public string CityNameEn { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameEn { get; set; }
        public string Address { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int EnoughFor { get; set; }
        public DateTime PreparedDate { get; set; }
        public string ExtraNotes { get; set; }
        public int? Status { get; set; }
        public DateTime? CreatedOn { get; set; }

        [JsonIgnore]
        public List<IFormFile> Files { get; set; }
        public List<DonationAttachmentViewModel> DonationAttachmentViewModels { get; set; }
    }
}