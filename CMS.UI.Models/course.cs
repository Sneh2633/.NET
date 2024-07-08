using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CMS.UI.Models
{
    internal class Course
    {
        private string? courseId;

        public string CourseId { get { return courseId; }
            set{ courseId = "c1"; } }

        public string CourseName { get; }

        public override string ToString()
        {
            return $"Id: {courseId}, Course Name: {CourseName}";
        }

    }
}
