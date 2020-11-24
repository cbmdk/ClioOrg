using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clio.Org.Model
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
        public int OrgHeight { get; set; }
        public Title Title { get; set; }
        public string Description { get; set; }
    }

    public enum Title
    {
        CEO = 0,
        Leadership = 1,
        Manager = 2,
        Developer = 7,
    }
}
