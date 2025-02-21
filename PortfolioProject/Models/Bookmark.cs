using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models
{
    // Represents a singular bookmark
    public class Bookmark
    {
        // Uniquely identifies each bookmark in the database
        [Key]
        public int BookmarkId { get; set; }

        // The user associated with the bookmark
        [Required]
        public string UserId { get; set; }

        // The internal name of the bookmark, will help provide
        // a working clickable link when displayed on a webpage
        [Required]
        public string BookmarkName { get; set; }

        // The name of the bookmark that is displayed on
        // a webpage
        [Required]
        public string BookmarkDisplay { get; set; }
    }
}
