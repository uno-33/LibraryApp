using LibraryDAL.Models;
using LibraryDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL.Services
{
    public class TagService : ITagService
    {
        private readonly IRepository<Tag> _tagRepository;
        public TagService(IRepository<Tag> repository)
        {
            _tagRepository = repository;
        }

        /// <summary>
        /// Adds new tag to DB
        /// </summary>
        /// <param name="tag">Tag to add</param>
        /// <returns>ID of added tag</returns>
        public void Add(Tag tag)
        {
            _tagRepository.Add(tag);
        }

        /// <summary>
        /// Deletes tag
        /// </summary>
        /// <param name="id">Tag to delete</param>
        public void Delete(int id)
        {
            _tagRepository.Delete(id);
        }

        /// <summary>
        /// Gets all tags from DB
        /// </summary>
        /// <returns>All tags</returns>
        public IEnumerable<Tag> GetAll()
        {
            return _tagRepository.GetAll();
        }

        /// <summary>
        /// Gets one tag by id
        /// </summary>
        /// <param name="id">Tag id to find</param>
        /// <returns>Found tag or null</returns>
        public Tag GetById(int id)
        {
            return _tagRepository.GetById(id);
        }

        /// <summary>
        /// Updates tag
        /// </summary>
        /// <param name="tag">Tag to update</param>
        public void Update(Tag tag)
        {
            _tagRepository.Update(tag);
        }
    }
}
