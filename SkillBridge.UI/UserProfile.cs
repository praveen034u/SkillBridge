namespace SkillBridge.UI
{
    public class UserProfile
    { 
       public EmployeeProfile EmployeeProfile { get; set; } = new();
       public EmployerProfile EmployerProfile { get; set; } = new();
       public string Role { get; set; }
       public string Id { get; set; } // Unique User ID (Auth0 ID or Database ID)

    }

    public class EmployeeProfile
    {
        public string Id { get; set; } // Unique User ID (Auth0 ID or Database ID)
        public NameModel Name { get; set; } = new();
        public string Email { get; set; } // User Email Address
        public string PhoneNumber { get; set; } // Contact Number (Optional)
        public string Location { get; set; } // User Location (City, Country)
        public List<string> Skills { get; set; } // List of User Skills
        public int ExperienceLevel { get; set; } // Beginner, Intermediate, Expert
        public List<string> Certifications { get; set; } // Certifications
        public List<string> AppliedJobs { get; set; } // List of Job IDs Applied To
        public string ResumeUrl { get; set; } // Link to Resume (Azure Blob Storage)
        public string LinkedInProfile { get; set; } // Contact Number (Optional)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Profile Creation Date

        
    }

    public class EmployerProfile
    {
        public string Id { get; set; } // Unique User ID (Auth0 ID or Database ID)
        public NameModel Name { get; set; } = new();

        public string Email { get; set; } // User Email Address
        public string PhoneNumber { get; set; } // Contact Number (Optional)
        public string Location { get; set; } // User Location (City, Country)

        public string CompanyName { get; set; } // Company Name
        public string CompanyWebsiteUrl { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Profile Creation Date
        public IList<CompanyLocation> CompanyLocations { get; set; }
    }

    public class CompanyLocation
    {
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }

        public string CompanyState { get; set; }
        public string CompanyCountry { get; set; }
    }

    public class NameModel
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}
