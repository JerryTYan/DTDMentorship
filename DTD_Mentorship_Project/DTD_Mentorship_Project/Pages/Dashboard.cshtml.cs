using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DTD_Mentorship_Project.Pages
{
    public class Mentee
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public string? Area { get; set; }
        public string? Image { get; set; }
    }
    public class DashboardModel : PageModel
    {
        private readonly ILogger<DashboardModel> _logger;

        // Define properties here
        public string Name { get; set; }
        public string District { get; set; }
        public List<Mentee> CurrentMentees { get; set; }
        public string AboutMe { get; set; }

        public DashboardModel(ILogger<DashboardModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // Initialize properties here
            Name = "John Doe";
            District = "District 1";
            CurrentMentees = new List<Mentee>
       {
           new Mentee { Name = "Mentee 1" },
           new Mentee { Name = "Mentee 2" },
           // Add more mentees here
       };
            AboutMe = "About me...";
        }
    }
}
