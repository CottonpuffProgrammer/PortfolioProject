using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Data;
using PortfolioProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Controllers;

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

        // All HTML related webpages can be found below
        public async Task<IActionResult> HTMLIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        public async Task<IActionResult> HTMLElements(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        // All CSS related webpages can be found below
        public IActionResult CSSIndex()
        {
            return View();
        }

        // All Javascript related webpages can be found below
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

            // The following code handles sections sorting

            // Gets all Sections from the database
            // and puts them in lists for sorting
            List<Section> sections = _context.Sections.ToList();

            // Creates a temporary list to keep track of what
            // Sections should be displayed in the webpage
            List<Section> sectionList = new List<Section>();

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

            // Sends the Section list to the view model
            viewModel.Sections = sectionList;

            // The following code handles bookmark sorting

            // If there is a logged in user
            if (user != null)
            {
                // Gets the current user's userId
                string userId = user.Id;

                // Gets all Bookmarks from the database
                // and puts them in lists for sorting
                List<Bookmark> bookmarks = _context.Bookmarks.ToList();

                // Creates a temporary list to keep track of what
                // Bookmarks should be displayed in the webpage
                List<Bookmark> bookmarkList = new List<Bookmark>();


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

                // Sends the Bookmark list to the view model
                viewModel.Bookmarks = bookmarkList;
            }

            // Sends the view model to the webpage
            return viewModel;
        }

        public IActionResult AddTestData()
        {
            // Clears all currently added Sections
            foreach (Section s in _context.Sections)
            {
                _context.Remove(s);
                _context.SaveChanges();
            }

            // The following code adds all Sections to the database for the
            // sake of testing, if this website was deployed to say Azure
            // this would not be needed but due to using a local database
            // this is required to test Section functionality

            // Creates a Section to be added, "a" is used instead of "s" 
            // due to the above foreach function
            Section a = new Section();

            // Adds HTML Introduction section
            a.SectionType = "HTML";
            a.SectionName = "HTMLIndex";
            a.SectionDisplay = "HTML Introduction";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Elements section
            a.SectionType = "HTML";
            a.SectionName = "HTMLElements";
            a.SectionDisplay = "HTML Elements";
            _context.Add(a);
            _context.SaveChanges();

            // Sends you to a page confirming you added test data
            return View();
        }
    }
}