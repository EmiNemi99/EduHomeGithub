using EduPage.DAL;
using EduPage.Models;
using EduPage.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _db.Sliders.Where(x => !x.IsDeactive).ToListAsync();
            List<Course> courses = await _db.Courses.OrderByDescending(x=>x.Id).Take(6).ToListAsync();
            List<Testimonial> testimonials = _db.Testimonials.ToList();
            About about = _db.Abouts.First();
            NoticeVideo noticeVideo = _db.NoticeVideos.First();
            List<Service> services = _db.Services.OrderByDescending(x=>x.Id).Where(x=>!x.IsDeactive).Take(3).ToList();
            List<Event> events = _db.Events.ToList();
            List<Blog> blogs = _db.Blogs.ToList();
            List<NoticeBoard> noticeBoards = _db.NoticeBoards.Where(x => !x.IsDeactive).ToList();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                About= about,
                Services=services,
                Courses=courses,
                Testimonials=testimonials,
                NoticeVideo=noticeVideo,
                Events=events,
                Blogs=blogs,
                NoticeBoards=noticeBoards

                
            };
            return View(homeVM);
        }
        public async Task<IActionResult> LoadMore(int skip)
        {
            List<Course> courses = await _db.Courses.OrderByDescending(x => x.Id).Skip(6).Take(6).ToListAsync();
            return PartialView("_LoadMorePartial", courses);
        }




        public IActionResult Error()
        {
            return View();
        }
    }
}
