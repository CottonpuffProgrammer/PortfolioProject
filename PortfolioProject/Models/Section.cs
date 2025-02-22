using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models
{
    // Represents a singular section
    public class Section
    {
        // Uniquely identifies a section
        [Key]
        public int SectionId { get; set; }

        // The coding language that a section
        // is from, helps the View Model send correct data
        [Required]
        public string SectionType { get; set; }

        // The internal name of the section, will help provide
        // a working clickable link when displayed on a webpage
        [Required]
        public string SectionName { get; set; }

        // The name of the section that is displayed on
        // a webpage
        [Required]
        public string SectionDisplay { get; set; }
    }
}
