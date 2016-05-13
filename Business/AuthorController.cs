using Common.Core.Domain;
using Queries.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AuthorController
    {
        UnitOfWork uow;
        public AuthorController()
        {
            uow = new UnitOfWork(new PlutoContext());
        }

        public Author GetAuthorWithCourses(int id)
        {
            return uow.Authors.GetAuthorWithCourses(id);
        }
    }
}
