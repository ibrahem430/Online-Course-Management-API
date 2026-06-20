using OnlineCourseManagementAPI.Models;

namespace OnlineCourseManagementAPI.Response;


public class CoursesResponse
{
     public Guid Id {get;set;}
    public string Name{get;set;}
     
     public string Description {get;set;}
     public int DurationHours {get;set;}


     private CoursesResponse(){}


     public static CoursesResponse FormModel(Courses courses)
    {
        if (courses == null)
        {
            throw new ArgumentNullException(nameof(courses),"error");
        }
        return new CoursesResponse
        {
            Id=courses.Id,
            Name=courses.Name,
            Description=courses.Description,
            DurationHours=courses.DurationHours
        };
    }

     public static IEnumerable<CoursesResponse> FormModels(IEnumerable<Courses>  courses)
    {
        if (courses == null)
        {
            throw new ArgumentNullException(nameof(courses),"error");
        }
        return  courses.Select(FormModel);
    }
}

