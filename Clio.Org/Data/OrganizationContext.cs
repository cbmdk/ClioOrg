using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Clio.Org.Model;
using Microsoft.EntityFrameworkCore;

namespace Clio.Org.Data
{
    public class OrganizationContext :DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Organization> Organization { get; set; }


    }
}
