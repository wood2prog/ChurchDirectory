using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchDirectory.Domain
{
    public class HouseholdRole
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool isActive { get; set; }

        public List<HouseholdMembership> HouseholdMemberships { get; set; } = new();
    }
}
