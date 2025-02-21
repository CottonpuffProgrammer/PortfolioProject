using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Data;
using PortfolioProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace PortfolioProject.Controllers
{
    public class SectionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _userManager;

        public SectionsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> HTMLIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }
        public IActionResult CSSIndex()
        {
            return View();
        }
        public IActionResult JavascriptIndex()
        {
            return View();
        }

        // "type" refers to the coding language, such as "HTML", "CSS", or "Javascript"
        public async Task<SectionsBookmarksViewModel> CreateViewModel(string type)
        {
            // Makes a string from the parameter to be used in sorting
            string sectionType = type;

            // Makes a View Model to pass Sections and Bookmarks to a page for viewing
            SectionsBookmarksViewModel viewModel = new SectionsBookmarksViewModel();

            // Gets current user and their userId
            IdentityUser user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                string userId = user.Id;

                // Gets all Sections and Bookmarks from the database
                // and puts them in lists for sorting
                List<Section> sections = _context.Sections.ToList();
                List<Bookmark> bookmarks = _context.Bookmarks.ToList();

                // Creates a temporary list to keep track of what
                // should be displayed in the webpage
                List<Section> sectionList = new List<Section>();
                List<Bookmark> bookmarkList = new List<Bookmark>();

                // The following code is for section and bookmark processing, both are extremely similar

                // Checks what sections are needed for display 
                // based on the sectionType
                foreach (Section s in sections)
                {
                    if (sectionType == s.SectionType)
                    {
                        // Adds the section to the list that will be
                        // sent to the webpage for display
                        sectionList.Add(s);
                    }
                }

                // Checks the userId of the currently logged in 
                // user, and compares it to the userId of each 
                // bookmark to see what belongs to the user
                foreach (Bookmark b in bookmarks)
                {
                    if (userId == b.UserId)
                    {
                        // Adds the bookmark to the list that will be
                        // sent to the webpage for display
                        bookmarkList.Add(b);
                    }
                }

                // Sends both lists to the view model
                viewModel.Sections = sectionList;
                viewModel.Bookmarks = bookmarkList;

                // Sends the view model to the webpage
                return viewModel;
            }
            else
            {
                // Generic error, this should never happen
                return null;
            }
        }
    }
}