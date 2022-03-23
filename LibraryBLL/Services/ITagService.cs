using LibraryDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBLL.Services
{
    public interface ITagService
    {
        void Add(Tag tag);
        void Delete(int id);
        IEnumerable<Tag> GetAll();
        Tag GetById(int id);
        void Update(Tag tag);
    }
}
