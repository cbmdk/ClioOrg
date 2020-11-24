using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clio.Org.Model;

namespace Clio.Org.Data
{
    public class TestData
    {
        public static void AddTestData(OrganizationContext context)
        {
            var structure = new List<Organization>();
            structure.Add(new Organization
            {
                Id = 10,
                Name = "Jesper CEO",
                Title = Title.CEO,
                OrgHeight = 0,
                Description = "CEO",
                Parent = 0
            });
            structure.Add(new Organization
            {
                Id = 1,
                Name = "Rikke HR",
                Title = Title.Manager,
                OrgHeight = 1,
                Description = "HR",
                Parent = 10
            });
            structure.Add(new Organization
            {
                Id = 2,
                Name = "Michael CFO",
                Title = Title.Manager,
                OrgHeight = 1,
                Description = "Finance",
                Parent = 10
            });
            structure.Add(new Organization
            {
                Id = 3,
                Name = "Bo CTO",
                Title = Title.Manager,
                OrgHeight = 1,
                Description = "Tech",
                Parent = 10
            });
            structure.Add(new Organization
            {
                Id = 4,
                Name = "Peter K Handest",
                Title = Title.Manager,
                OrgHeight = 2,
                Description = "Tech",
                Parent = 3
            });
            structure.Add(new Organization
            {
                Id = 5,
                Name = "Thomas Effersøe",
                Title = Title.Developer,
                OrgHeight = 3,
                Description = "Laravel",
                Parent = 4
            });
            structure.Add(new Organization
            {
                Id = 6,
                Name = "Elena Canete",
                Title = Title.Developer,
                OrgHeight = 3,
                Description = "Laravel",
                Parent = 4
            });
            foreach (var organization in structure)
            {
                context.Organization.Add(organization);

            }
            context.SaveChanges();
        }
    }
}
