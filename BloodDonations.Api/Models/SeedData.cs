using BloodDonations.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonations.Api.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService(typeof(ApplicationDbContext)) as ApplicationDbContext;

            List<BloodGroup> bloodGroups = new List<BloodGroup>();
            bloodGroups.Add(new BloodGroup() { Id = 1, BloodType = "A", RhFactor = true });
            bloodGroups.Add(new BloodGroup() { Id = 2, BloodType = "A", RhFactor = false });
            bloodGroups.Add(new BloodGroup() { Id = 3, BloodType = "B", RhFactor = true });
            bloodGroups.Add(new BloodGroup() { Id = 4, BloodType = "B", RhFactor = false });
            bloodGroups.Add(new BloodGroup() { Id = 5, BloodType = "AB", RhFactor = true });
            bloodGroups.Add(new BloodGroup() { Id = 6, BloodType = "AB", RhFactor = false });
            bloodGroups.Add(new BloodGroup() { Id = 7, BloodType = "O", RhFactor = true });
            bloodGroups.Add(new BloodGroup() { Id = 8, BloodType = "O", RhFactor = false });

            if (!context.BloodGroups.Any())
            {
                foreach (var bloodGroup in bloodGroups)
                {
                    context.BloodGroups.Add(bloodGroup);
                }
            }
            context.SaveChangesAsync();
        }
    }
}
