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

        public async Task<IActionResult> HTMLAttributes(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        public async Task<IActionResult> HTMLStyles(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        public async Task<IActionResult> HTMLComments(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        public async Task<IActionResult> HTMLLinks(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        public async Task<IActionResult> HTMLLists(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        public async Task<IActionResult> HTMLDivs(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("HTML");
            return View(viewModel);
        }

        // All CSS related webpages can be found below
        public async Task<IActionResult> CSSIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSSyntax(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSSelectors(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSComments(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSBackgrounds(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSBorders(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSMargins(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        public async Task<IActionResult> CSSHeightWidth(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("CSS");
            return View(viewModel);
        }

        // All Javascript related webpages can be found below
        public async Task<IActionResult> JavascriptIndex(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptPlacement(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptStatements(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptSyntax(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptVariables(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptLet(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptOperators(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
        }

        public async Task<IActionResult> JavascriptFunctions(SectionsBookmarksViewModel viewModel)
        {
            viewModel = await CreateViewModel("Javascript");
            return View(viewModel);
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

        // A temporary test method for adding data to test 
        // section functionality, is meant to be long due to its purpose
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

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Attributes section
            a.SectionType = "HTML";
            a.SectionName = "HTMLAttributes";
            a.SectionDisplay = "HTML Attributes";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Styles section
            a.SectionType = "HTML";
            a.SectionName = "HTMLStyles";
            a.SectionDisplay = "HTML Styles";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Comments section
            a.SectionType = "HTML";
            a.SectionName = "HTMLComments";
            a.SectionDisplay = "HTML Comments";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Links section
            a.SectionType = "HTML";
            a.SectionName = "HTMLLinks";
            a.SectionDisplay = "HTML Links";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Lists section
            a.SectionType = "HTML";
            a.SectionName = "HTMLLists";
            a.SectionDisplay = "HTML Lists";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds HTML Divs section
            a.SectionType = "HTML";
            a.SectionName = "HTMLDivs";
            a.SectionDisplay = "HTML Divs";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Introduction section
            a.SectionType = "CSS";
            a.SectionName = "CSSIndex";
            a.SectionDisplay = "CSS Introduction";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Syntax section
            a.SectionType = "CSS";
            a.SectionName = "CSSSyntax";
            a.SectionDisplay = "CSS Syntax";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Selectors section
            a.SectionType = "CSS";
            a.SectionName = "CSSSelectors";
            a.SectionDisplay = "CSS Selectors";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Comments section
            a.SectionType = "CSS";
            a.SectionName = "CSSComments";
            a.SectionDisplay = "CSS Comments";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Backgrounds section
            a.SectionType = "CSS";
            a.SectionName = "CSSBackgrounds";
            a.SectionDisplay = "CSS Backgrounds";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Borders section
            a.SectionType = "CSS";
            a.SectionName = "CSSBorders";
            a.SectionDisplay = "CSS Borders";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS Margins section
            a.SectionType = "CSS";
            a.SectionName = "CSSMargins";
            a.SectionDisplay = "CSS Margins";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds CSS HeightWidth section
            a.SectionType = "CSS";
            a.SectionName = "CSSHeightWidth";
            a.SectionDisplay = "CSS Height/Width";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Introduction section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptIndex";
            a.SectionDisplay = "Javascript Introduction";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Placement section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptPlacement";
            a.SectionDisplay = "Javascript Placement";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Statements section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptStatements";
            a.SectionDisplay = "Javascript Statements";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Syntax section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptSyntax";
            a.SectionDisplay = "Javascript Syntax";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Variables section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptVariables";
            a.SectionDisplay = "Javascript Variables";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Let section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptLet";
            a.SectionDisplay = "Javascript Let";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Operators section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptOperators";
            a.SectionDisplay = "Javascript Operators";
            _context.Add(a);
            _context.SaveChanges();

            // Clears the section to prevent an error
            a = new Section();

            // Adds Javascript Functions section
            a.SectionType = "Javascript";
            a.SectionName = "JavascriptFunctions";
            a.SectionDisplay = "Javascript Functions";
            _context.Add(a);
            _context.SaveChanges();

            // Sends you to a page confirming you added test data
            return View();
        }
    }
}