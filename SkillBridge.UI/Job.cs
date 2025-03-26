using System.Collections.Generic;
using System;

namespace SkillBridge.UI
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> RequiredSkills { get; set; } = new();
        public string CompanyName { get; set; } //employer name
        public string Location { get; set; }
        public string EmploymentType { get; set; }
        public decimal Salary { get; set; }
        public string PostedByUserId { get; set; }
        public DateTime PostedDate { get; set; } //created date
        public bool IsActive { get; set; } = true;

    }

}
