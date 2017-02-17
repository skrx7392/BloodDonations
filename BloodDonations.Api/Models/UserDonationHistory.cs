using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonations.Api.Models
{
    public class UserDonationHistory
    {
        public long Id { get; set; }
        public string ApplicationUserId { get; set; }
        public DateTime DonationDate { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
