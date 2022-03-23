using LibraryDAL.Models;
using LibraryDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryBLL.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IRepository<Feedback> _feedbackRepository;

        public FeedbackService(IRepository<Feedback> repository)
        {
            _feedbackRepository = repository;
        }

        /// <summary>
        /// Adds new feedback to DB
        /// </summary>
        /// <param name="feedback">Feedback to add</param>
        /// <returns>ID of added feedback</returns>
        public void Add(Feedback feedback)
        {
            _feedbackRepository.Add(feedback);
        }

        /// <summary>
        /// Gets all feedbacks from DB
        /// </summary>
        /// <returns>All feedbacks</returns>
        public IEnumerable<Feedback> GetAll()
        {
            return _feedbackRepository.GetAll();
        }

        /// <summary>
        /// Gets one feedback by id
        /// </summary>
        /// <param name="id">Feedback id to find</param>
        /// <returns>Found feedback or null</returns>
        public Feedback GetById(int id)
        {
            return _feedbackRepository.GetById(id);
        }

        /// <summary>
        /// Updates feedback
        /// </summary>
        /// <param name="feedback">Feedback to update</param>
        public void Update(Feedback feedback)
        {
            _feedbackRepository.Update(feedback);
        }

        /// <summary>
        /// Deletes feedback
        /// </summary>
        /// <param name="id">Feedback to delete</param>
        public void Delete(int id)
        {
            _feedbackRepository.Delete(id);
        }
    }
}