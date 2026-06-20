using OnlineCourseManagementAPI.Models;


namespace OnlineCourseManagementAPI.Services;


public class EnrollmentServices
{
    public EnrollmentServices(StudentServices studentServices ,CoursesServices coursesServices)
    {
        this.courses=coursesServices;
        this.students=studentServices;

        enrollments =
[
    new Enrollment
    {
        Id = Guid.NewGuid(),
        StudentId = students.students[0].Id,
        CoursesId = courses.courses[0].Id,
        EnrollmentAt = new DateTime(2026, 1, 15)
    },

    new Enrollment
    {
        Id = Guid.NewGuid(),
        StudentId = students.students[1].Id,
        CoursesId = courses.courses[1].Id,
        EnrollmentAt = new DateTime(2026, 1, 20)
    }

];
        
    }
    List<Enrollment> enrollments=null;
    private readonly CoursesServices courses;
    private readonly StudentServices students;
    

    
 
}