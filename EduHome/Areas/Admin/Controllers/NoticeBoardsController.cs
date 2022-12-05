using EduPage.DAL;
using EduPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduPage.Areas.Admin.Controllers
{ 
    [Area(nameof(Admin))]
    public class NoticeBoardsController : Controller
    {
        private readonly AppDbContext _db;
        public NoticeBoardsController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<NoticeBoard> noticeBoards = await _db.NoticeBoards.ToListAsync();
            return View(noticeBoards);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(NoticeBoard noticeBoard)
        {

            if (ModelState.IsValid)
            {
                return View();
            }

            await _db.NoticeBoards.AddAsync(noticeBoard);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Activity(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            NoticeBoard noticeBoard = await _db.NoticeBoards.FirstOrDefaultAsync(x => x.Id == id);
            if (noticeBoard == null)
            {
                return BadRequest();
            }
            if (noticeBoard.IsDeactive)
            {
                noticeBoard.IsDeactive = false;
            }
            else
            {
                noticeBoard.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int ? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            NoticeBoard noticeBoard = await _db.NoticeBoards.FirstOrDefaultAsync();
            if (noticeBoard==null)
            {
                return BadRequest();
            }
            return View(noticeBoard);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,NoticeBoard noticeBoard)
        {
            if (id == null)
            {
                return NotFound();
            }
            NoticeBoard dbnoticeBoard = await _db.NoticeBoards.FirstOrDefaultAsync();
            if (noticeBoard == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return View(dbnoticeBoard);
            }
            dbnoticeBoard.CreateTime = noticeBoard.CreateTime;
            dbnoticeBoard.Description = noticeBoard.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
