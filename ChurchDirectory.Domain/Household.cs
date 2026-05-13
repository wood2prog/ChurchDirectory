using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchDirectory.Domain
{
    public class Household
    {
        public int Id { get; set; }
        public string HouseholdName { get; set; } = string.Empty;
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipCode { get; set; }
        public string? Notes { get; set; }

        public List<HouseholdMembership> HouseholdMemberships { get; set; } = new();
    }
}
