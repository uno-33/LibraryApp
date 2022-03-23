using LibraryApp.ViewModels;
using LibraryBLL.Services;
using LibraryDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryApp.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }
        // GET: Feedback
        public ActionResult Index()
        {
            var viewModel = new FeedbackViewModel
            {
                Feedbacks = _feedbackService.GetAll()
            };
            return View(viewModel);
        }

        // POST: Feedback/Index
        [HttpPost]
        public ActionResult Index(FeedbackViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var feedback = viewModel.NewFeedback;

                feedback.CreationDate = DateTime.Now;
                _feedbackService.Add(feedback);

                return RedirectToAction("Index");
            }
            viewModel.Feedbacks = _feedbackService.GetAll();
            return View(viewModel);
        }

        // GET: Feedback/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_feedbackService.GetById(id));
        }

        // POST: Feedback/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.Id = id;
                _feedbackService.Update(feedback);

                return RedirectToAction("Index");
            }
            return View(feedback);
        }

        // GET: Feedback/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_feedbackService.GetById(id));
        }

        // POST: Feedback/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Feedback feedback)
        {
            try
            {
                _feedbackService.Delete(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(feedback);
            }
        }
    }
}
