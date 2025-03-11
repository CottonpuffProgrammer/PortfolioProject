using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioProject.Models
{
    /// <summary>
    /// Represents a single section
    /// </summary>
    public class Section
    {
        /// <summary>
        /// Uniquely identifies each section with an auto generated ID for each bookmark to ensure there are no exact duplicates.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SectionId { get; set; }

        /// <summary>
        /// Determines what coding language a section is from.
        /// </summary>
        [Required]
        public string SectionType { get; set; }

        [Required]
        public string SectionName { get; set; }

        /// <summary>
        /// Used to display the name of a section on a webpage.
        /// </summary>
        [Required]
        public string SectionDisplay { get; set; }

        /// <summary>
        /// By far the largest part of a section, contains all of a section's raw HTML.
        /// </summary>
        public string ?SectionHTML { get; set; }

    }
}
