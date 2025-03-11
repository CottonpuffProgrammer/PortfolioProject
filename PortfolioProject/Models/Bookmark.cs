using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioProject.Models
{
    /// <summary>
    /// Represents a single bookmark
    /// </summary>
    public class Bookmark
    {
        /// <summary>
        /// An auto generated ID for each bookmark to ensure there are no exact duplicates.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookmarkId { get; set; }

        /// <summary>
        /// Used to tie a bookmark to a specific user, effectively a secondary key.
        /// </summary>
        [Required]
        public string UserId { get; set; }
        
        /// <summary>
        /// Determines what coding language a bookmark is from.
        /// </summary>
        [Required]
        public string BookmarkType { get; set; }

        [Required]
        public string BookmarkName { get; set; }

        /// <summary>
        /// Used in very specific places to display text stored in a bookmark.
        /// </summary>
        [Required]
        public string BookmarkDisplay { get; set; }
    }
}
