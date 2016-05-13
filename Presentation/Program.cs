
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Business.AuthorController ac = new Business.AuthorController();
            var author = ac.GetAuthorWithCourses(1);
            
        }
    }
}
