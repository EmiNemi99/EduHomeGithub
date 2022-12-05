using EduPage.DAL;
using EduPage.Helper;
using EduPage.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduPage.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IWebHostEnvironment _env; 
        public SlidersController(AppDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _db.Sliders.ToListAsync();
            return View(sliders);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if(slider.Photo==null)
            {
                ModelState.AddModelError("Photo", "Mütləq Şəkli daxil edin"); 
                return View();
            }
            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkli seçin");
                return View();
            }
            if (slider.Photo.IsOlderMaxMB())
            {
                ModelState.AddModelError("Photo", "2MB dan çox ola bilməz");
                return View();
            }
            string path = Path.Combine(_env.WebRootPath,"img","slider");
            slider.Image = await slider.Photo.SaveFileAsync(path);
            await _db.SaveChangesAsync();
            await _db.Sliders.AddAsync(slider);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FirstOrDefaultAsync(x=>x.Id==id);
            if (slider == null)
            
             return BadRequest();
            
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,  Slider slider)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider dbSlider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (dbSlider == null)

                return BadRequest();
            if (!ModelState.IsValid)
            {
                return View(dbSlider);
            }
            if (slider.Photo != null)
            {
                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zəhmət olmasa şəkli seçin");
                    return View(dbSlider);
                }
                if (slider.Photo.IsOlderMaxMB())
                {
                    ModelState.AddModelError("Photo", "2MB dan çox ola bilməz");
                    return View(dbSlider);
                }
                string path = Path.Combine(_env.WebRootPath, "img", "slider");
                string fullpath = Path.Combine(path, dbSlider.Image); 
                if (System.IO.File.Exists(fullpath ))
                {
                    System.IO.File.Delete(fullpath);
                }
                dbSlider.Image = await slider.Photo.SaveFileAsync(path); 
            }
            
            dbSlider.Title =  slider.Title;
            dbSlider.Description = slider.Description;
            await _db.Sliders.AddAsync(slider);
            await _db.SaveChangesAsync();
            

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FirstOrDefaultAsync(x => x.Id == id);
            if (slider == null)
            {
                return BadRequest();
            }
            if (slider.IsDeactive)
            {
                slider.IsDeactive = false;
            }
            else
            {
                slider.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
