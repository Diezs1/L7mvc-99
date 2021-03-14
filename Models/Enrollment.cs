namespace ContosoUniversity.Models
{
    //tinfo200:[2021-02-22-Diezs-dykstra1] -- gets and stores student information from student.cs

    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}