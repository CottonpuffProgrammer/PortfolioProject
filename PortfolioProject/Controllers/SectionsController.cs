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
        public IActionResult HTMLIndex()
        {
            return View();
        }
        public IActionResult CSSIndex()
        {
            return View();
        }
        public IActionResult JavascriptIndex()
        {
            return View();
        }
        public IActionResult Test()
        {
            return RedirectToAction("HTMLIndex");
        }
    }
}