using Business.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Program
    {
        private readonly IUnitOfWork unitofWork;
        static void Main(string[] args)
        {
            
            var courses= unitofWork.Courses.GetAll();
        }
    }
}
