using DBProject.DAL;
using DBProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DBProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b=>b.Comments).ToList();
            return View(blogs);
        }
        public IActionResult Detail(int? id)
        {
            if(id == null) return NotFound();
            Blog blog = _context.Blogs.Include(b=>b.Comments).FirstOrDefault(b => b.Id == id);
            if(blog == null) return NotFound();
            return View(blog);
        }
    }
}
