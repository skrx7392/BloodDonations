using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonations.Api.Models
{
    public class DonorDetails
    {
        [ForeignKey("AspNetUsers")]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        [ForeignKey("BloodGroups")]
        public int BloodId { get; set; }

        public virtual BloodGroup BloodGroup { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
