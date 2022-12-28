using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationApp.Data.Entities;

namespace DonationApp.Models
{
  public class DistrictViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string NameEn { get; set; }
        public int? CityId { get; set; }
        public string CityName { get; set; }
        public string CityNameEn { get; set; }
    }
}
