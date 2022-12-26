using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationApp.Data.Entities;

namespace DonationApp.Models
{
  public class DonationAttachmentViewModel
    {
        public int Id { get; set; }
        public long? DonationId { get; set; }
        public string Src { get; set; }
    }
}
