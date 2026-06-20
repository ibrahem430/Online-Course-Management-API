using OnlineCourseManagementAPI.Models;

namespace OnlineCourseManagementAPI.Response;


public class EnrollmentResponse
{
        public Guid Id {get;set;}
    public Guid StudentId {get;set;}
    public Guid CoursesId{get;set;}
    public DateTime EnrollmentAt{get;set;}


    private EnrollmentResponse()
    {
        
    }

    public static EnrollmentResponse FromModel(Enrollment enrollment)
    {
        if(enrollment==null)
        throw new ArgumentNullException(nameof(enrollment),"error");

        return new EnrollmentResponse
        {
            Id=enrollment.Id,
            StudentId=enrollment.StudentId,
            CoursesId=enrollment.CoursesId,
            EnrollmentAt=enrollment.EnrollmentAt
        };
    }
      public static IEnumerable< EnrollmentResponse> FromModels(IEnumerable <Enrollment> enrollments)
    {
        if(enrollments==null)
        throw new ArgumentNullException(nameof(enrollments),"error");

        return enrollments.Select(FromModel);
    }

    
}