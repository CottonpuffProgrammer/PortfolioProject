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

        [HttpGet]
        public async Task<IActionResult> HTMLIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML", "HTML");
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> HTMLIndex(SectionsBookmarksViewModel viewModel, string sectionName)
        {
            ViewBag.SectionName = sectionName;
            viewModel = await CreateViewModel("HTML", sectionName);
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> CSSIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS", "CSS");
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CSSIndex(SectionsBookmarksViewModel viewModel, string sectionName)
        {
            ViewBag.SectionName = sectionName;
            viewModel = await CreateViewModel("CSS", sectionName);
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> JavascriptIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript", "Javascript");
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> JavascriptIndex(SectionsBookmarksViewModel viewModel, string sectionName)
        {
            ViewBag.SectionName = sectionName;
            viewModel = await CreateViewModel("Javascript", sectionName);
            return View(viewModel);
        }

        // "type" refers to the coding language, such as "HTML", "CSS", or "Javascript"
        public async Task<SectionsBookmarksViewModel> CreateViewModel(string type, string sectionName)
        {

            // Makes a string from the parameter to be used in sorting
            string sectionType = type;

            // Makes a View Model to pass Sections and Bookmarks to a page for viewing
            SectionsBookmarksViewModel viewModel = new SectionsBookmarksViewModel();

            // Grabs the required section from the database based on what section the 
            // user clicked on the website
            Section section = _context.Sections.FirstOrDefault(s => s.SectionName == sectionName);

            // Make the inputted section the one to display
            viewModel.SectionToDisplay = section;


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
    }
}