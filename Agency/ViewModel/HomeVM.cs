using Agency.Models;

namespace Agency.ViewModel
{
    public class HomeVM
    {
        public Banner Banner { get; set; }
        public List<Service> Services { get; set; }
        public List<About> Abouts { get; set; }
        public List<Team> Teams { get; set; }
        public List<Social> Socials { get; set; }
    }
}
