using Common.Models;

using Microsoft.AspNetCore.Identity;

using System.Collections.Generic;

namespace Data.Models
{
    public class Student : IdentityUser
    {
        public Student()
        {
        }

        public Student(string userName) : base(userName)
        {
        }

        public virtual IList<StudentCourse> Courses { get; set; }
    }
}
