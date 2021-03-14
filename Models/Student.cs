using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{

    //tinfo200:[2021-02-22-Diezs-dykstra1] -- has student information for enrollment, such as student id, full name, enrollment date, also holds list of enrolled students.
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
