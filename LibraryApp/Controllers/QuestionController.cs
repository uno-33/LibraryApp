using LibraryBLL.Services;
using LibraryDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApp.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        // GET: Question
        public ActionResult Index()
        {
            return View();
        }

        // POST: Question/Index
        [HttpPost]
        public ActionResult Index(Question question)
        {
            if (ModelState.IsValid)
            {
                var qId = _questionService.Add(question);

                return RedirectToAction("Details", new { id = qId });
            }
            return View(question);
        }

        // GET: Question/Details/5
        public ActionResult Details(int id)
        {
            return View(_questionService.GetById(id));
        }
    }
}
