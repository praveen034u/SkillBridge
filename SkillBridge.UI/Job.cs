using System.Collections.Generic;
using System;

namespace SkillBridge.UI
{
    public class Job
    {
        public string Id { get; set; }

        public string EmployerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MinExperience { get; set; }

        public List<string> Skills { get; set; } = new();
       
        public string Location { get; set; }

        public string Company { get; set; } //employer name

        public string JobType { get; set; }
        public decimal Salary { get; set; }
        public string PostedByUserId { get; set; }
        public DateTime PostedDate { get; set; } //created date
        public bool IsActive { get; set; } = true;

    }


    public class JobRecommendation
    {
        public Job Job { get; set; }
        public int MatchingScore { get; set; } // Score in percentage (e.g., 85 means 85%)
        public bool HasApplied { get; set; } // Indicates if the user has applied for the job
    }

}
