namespace OnlineCourseManagementAPI.Models;

public class Enrollment
{
    public Guid Id {get;set;}
    public Guid StudentId {get;set;}
    public Guid CoursesId{get;set;}
    public DateTime EnrollmentAt{get;set;}
    
}