namespace PortfolioProject.Models
{
    /// <summary>
    /// Used to send a set of objects to 
    /// webpages for display
    /// </summary>
    public class ViewPhotosViewModel
    {
        /// <summary>
        /// Contains a list of Section objects to 
        /// be sent to a view, these will be 
        /// organized in the SectionsController
        /// </summary>
        public List<Section>? Sections { get; set; }

        /// <summary>
        /// Contains a list of Bookmark objects to 
        /// be sent to a view, these will be 
        /// organized in the SectionsController
        /// </summary>
        public List<Bookmark>? Bookmarks { get; set; }
    }
}
