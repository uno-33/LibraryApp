using LibraryBLL.Services;
using LibraryDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApp.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        // GET: Main
        public ActionResult Index()
        {
            return View(_articleService.GetAll());
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View(_articleService.GetById(id));
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                article.CreationDate = DateTime.Now;
                _articleService.Add(article);
                return RedirectToAction("Index");
            }
            return View(article);
        }

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_articleService.GetById(id));
        }

        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Article article)
        {
            if (ModelState.IsValid)
            {
                article.Id = id;
                _articleService.Update(article);
                
                return RedirectToAction("Index");
            }
            return View(article);
        }

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_articleService.GetById(id));
        }

        // POST: Main/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Article article)
        {
            try
            {
                _articleService.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(article);
            }
        }
    }
}
