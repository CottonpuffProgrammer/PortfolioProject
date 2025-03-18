using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Data;
using PortfolioProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Controllers;
using static System.Collections.Specialized.BitVector32;

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

        /// <summary>
        /// When the page is first visited, generates a view model to send section and bookmark data to display.
        /// </summary>
        /// <param name="viewModel">The view model containing all data required to display the page correctly.</param>
        /// <returns>Returns a webpage view with a view model attached.</returns>
        [HttpGet]
        public async Task<IActionResult> HTMLIndex(string sectionName, SectionsBookmarksViewModel viewModel)
        {
            if (sectionName != null)
            {
                viewModel = await CreateViewModel("HTML", sectionName);
            }
            else
            {
                viewModel = await CreateViewModel("HTML", "HTML");
            }
            return View(viewModel);
        }

        /// <summary>
        /// When a section on the page is clicked, this will update view model data to properly display the selected section.
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="sectionName"></param>
        /// <returns>Returns a webpage view with a view model attached.</returns>
        [HttpPost]
        public async Task<IActionResult> HTMLIndex(SectionsBookmarksViewModel viewModel, string sectionName)
        {
            ViewBag.SectionName = sectionName;
            viewModel = await CreateViewModel("HTML", sectionName);
            return View(viewModel);
        }

        /// <summary>
        /// When the page is first visited, generates a view model to send section and bookmark data to display.
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns>Returns a webpage view with a view model attached.</returns>
        [HttpGet]
        public async Task<IActionResult> CSSIndex(string sectionName, SectionsBookmarksViewModel viewModel)
        {
            if (sectionName != null)
            {
                viewModel = await CreateViewModel("CSS", sectionName);
            }
            else
            {
                viewModel = await CreateViewModel("CSS", "CSS");
            }
            return View(viewModel);
        }

        /// <summary>
        /// When a section on the page is clicked, this will update view model data to properly display the selected section.
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="sectionName"></param>
        /// <returns>Returns a webpage view with a view model attached.</returns>
        [HttpPost]
        public async Task<IActionResult> CSSIndex(SectionsBookmarksViewModel viewModel, string sectionName)
        {
            ViewBag.SectionName = sectionName;
            viewModel = await CreateViewModel("CSS", sectionName);
            return View(viewModel);
        }

        /// <summary>
        /// When the page is first visited, generates a view model to send section and bookmark data to display.
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns>Returns a webpage view with a view model attached.</returns>
        [HttpGet]
        public async Task<IActionResult> JavascriptIndex(string sectionName, SectionsBookmarksViewModel viewModel)
        {
            if (sectionName != null)
            {
                viewModel = await CreateViewModel("Javascript", sectionName);
            }
            else
            {
                viewModel = await CreateViewModel("Javascript", "Javascript");
            }
            return View(viewModel);
        }

        /// <summary>
        /// When a section on the page is clicked, this will update view model data to properly display the selected section.
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="sectionName"></param>
        /// <returns>Returns a webpage view with a view model attached.</returns>
        [HttpPost]
        public async Task<IActionResult> JavascriptIndex(SectionsBookmarksViewModel viewModel, string sectionName)
        {
            ViewBag.SectionName = sectionName;
            viewModel = await CreateViewModel("Javascript", sectionName);
            return View(viewModel);
        }

        /// <summary>
        /// This method helps generate a bookmark to be added to the currently logged in user's bookmarks.
        /// </summary>
        /// <param name="bookmarkName">Determines what sections will be used to create a bookmark.</param>
        /// <returns>Returns the user to the URL they were at when adding a bookmark.</returns>
        [HttpPost]
        public async Task<IActionResult> AddBookmark (string bookmarkName)
        {
            // Retrieves the section that the bookmark will be made from by the section name passed in "bookmarkName"
            Models.Section section = await _context.Sections
                        .Where(n => n.SectionName == bookmarkName)
                        .FirstOrDefaultAsync();

            IdentityUser user = await _userManager.GetUserAsync(User);

            string userId = user.Id;

            Bookmark bookmarkToAdd = new Bookmark();

            bookmarkToAdd.UserId = userId;

            bookmarkToAdd.BookmarkType = section.SectionType;

            bookmarkToAdd.BookmarkName = section.SectionName;

            bookmarkToAdd.BookmarkDisplay = section.SectionDisplay;

            _context.Bookmarks.Add(bookmarkToAdd);

            await _context.SaveChangesAsync();

            string redirectIndex = "";

            // Chooses the Index to be redirected to, a simple if statement will work
            // as there are only 3 Index pages to choose from
            if (bookmarkToAdd.BookmarkType == "HTML")
            {
                redirectIndex = "HTMLIndex";
            }
            else if (bookmarkToAdd.BookmarkType == "CSS")
            {
                redirectIndex = "CSSIndex";
            }
            else if (bookmarkToAdd.BookmarkType == "Javascript")
            {
                redirectIndex = "JavascriptIndex";
            }

            SectionsBookmarksViewModel viewModel = await CreateViewModel(bookmarkToAdd.BookmarkType, bookmarkToAdd.BookmarkName);

            return RedirectToAction(redirectIndex, "Sections", new { viewModel, sectionName = bookmarkToAdd.BookmarkName });
        }

        /// <summary>
        /// This method helps identify a bookmark to be removed from the currently logged in user's bookmarks.
        /// </summary>
        /// <param name="bookmarkName">Determines what sections will be used to find a bookmark to be deleted.</param>
        /// <returns>Returns the user to the URL they were at when deleting a bookmark.</returns>
        [HttpPost]
        public async Task<IActionResult> DeleteBookmark(string bookmarkName)
        {
            IdentityUser user = await _userManager.GetUserAsync(User);

            string userId = user.Id;

            // Retrieves the bookmark to be deleted by both the name and userId of the bookmark
            Bookmark? bookmarkToDelete = await _context.Bookmarks
                        .Where(n => n.BookmarkName == bookmarkName && n.UserId == userId)
                        .FirstOrDefaultAsync();

            _context.Bookmarks.Remove(bookmarkToDelete);

            await _context.SaveChangesAsync();

            string redirectIndex = "";

            // Chooses the Index to be redirected to, a simple if statement will work
            // as there are only 3 Index pages to choose from
            if (bookmarkToDelete.BookmarkType == "HTML")
            {
                redirectIndex = "HTMLIndex";
            }
            else if (bookmarkToDelete.BookmarkType == "CSS")
            {
                redirectIndex = "CSSIndex";
            }
            else if (bookmarkToDelete.BookmarkType == "Javascript")
            {
                redirectIndex = "JavascriptIndex";
            }

            SectionsBookmarksViewModel viewModel = await CreateViewModel(bookmarkToDelete.BookmarkType, bookmarkToDelete.BookmarkName);

            return RedirectToAction(redirectIndex, "Sections", new { viewModel, sectionName = bookmarkToDelete.BookmarkName });
        }

        /// <summary>
        /// Creates a view model containing all sections from a specific coding language, along with a specific section to be displayed 
        /// in the main content section of a webpage.
        /// </summary>
        /// <param name="type">Determines what sections will be displayed based on their coding language (example would be HTML).</param>
        /// <param name="sectionName">Determines what section will be displayed in the main content of the webpage based on a section's name.</param>
        /// <returns>Returns a view model ready to be displayed on a webpage.</returns>
        public async Task<SectionsBookmarksViewModel> CreateViewModel(string type, string sectionName)
        {

            string sectionType = type;

            SectionsBookmarksViewModel viewModel = new SectionsBookmarksViewModel();

            // Grabs the required section from the database based on what section the user clicked on the website
            Models.Section section = _context.Sections.FirstOrDefault(s => s.SectionName == sectionName);

            viewModel.SectionToDisplay = section;

            IdentityUser user = await _userManager.GetUserAsync(User);

            List<Models.Section> sections = _context.Sections.ToList();

            List<Models.Section> sectionList = new List<Models.Section>();

            foreach (Models.Section s in sections)
            {
                if (sectionType == s.SectionType)
                {
                    sectionList.Add(s);
                }
            }

            viewModel.Sections = sectionList;

            if (user != null)
            {
                string userId = user.Id;

                List<Bookmark> bookmarks = _context.Bookmarks.ToList();

                List<Bookmark> bookmarkList = new List<Bookmark>();


                // Checks the userId of the currently logged in user, and compares it to the userId of each bookmark to see what belongs to the user
                foreach (Bookmark b in bookmarks)
                {
                    if (userId == b.UserId)
                    {
                        bookmarkList.Add(b);
                    }
                }

                viewModel.Bookmarks = bookmarkList;
            }

            return viewModel;
        }
    }
}