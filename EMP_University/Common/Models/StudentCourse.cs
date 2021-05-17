namespace Common.Models
{
    public class StudentCourse
    {
        public int CourseId { get; set; }

        public string StudentId { get; set; }

        public virtual Course Course { get; set; }

        // We skip this, becouse it would brake our "Clean Architecture".
        ////public Student Student { get; set; }
    }
}
