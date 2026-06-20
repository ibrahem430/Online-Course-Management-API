using OnlineCourseManagementAPI.Models;

namespace OnlineCourseManagementAPI.Response;


public class StudentResponse
{
     public Guid Id {get;set;}
    public string Name {get;set;}

    public string Email{get;set;}

    public StudentResponse (){}

    public static StudentResponse FromModel(Student student)
    {
        if (student == null)
        {
            throw new ArgumentNullException(nameof(student),"error");
        }
        return new StudentResponse
        {
            Id=student.Id,
            Name=student.Name,
            Email=student.Email

        };
    }

       public static IEnumerable< StudentResponse> FromModels(IEnumerable< Student> student)
    {
        if (student == null)
        {
            throw new ArgumentNullException(nameof(student),"error");
        }
        return student.Select(FromModel);
    }
}