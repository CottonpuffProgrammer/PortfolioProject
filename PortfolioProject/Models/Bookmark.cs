using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models
{
    /// <summary>
    /// Represents a singular bookmark
    /// </summary>
    public class Bookmark
    {
        /// <summary>
        /// Uniquely identifies each bookmark in the database
        /// </summary>
        [Key]
        public int BookmarkId { get; set; }

        /// <summary>
        /// The user associated with the bookmark
        /// </summary>
        [Required]
        public string UserId { get; set; }

        /// <summary>
        /// The internal name of the bookmark, will help provide
        /// a working clickable link when displayed on a webpage
        /// </summary>
        [Required]
        public string BookmarkName { get; set; }

        /// <summary>
        /// The name of the bookmark that is displayed on
        /// a webpage
        /// </summary>
        [Required]
        public string BookmarkDisplay { get; set; }
    }
}
