using OnlineCourseManagementAPI.Models;

namespace OnlineCourseManagementAPI.Services;


public class CoursesServices
{
  public List<Courses> courses =
[
    new Courses
    {
        Id = Guid.Parse("2779ee47-10b0-4bd7-8342-404006aa1392"),
        Name = "Math",
        Description = "Mathematics Fundamentals",
        DurationHours = 120
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Physics",
        Description = "Physics Basics",
        DurationHours = 100
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Chemistry",
        Description = "Introduction to Chemistry",
        DurationHours = 90
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Biology",
        Description = "Biology Concepts",
        DurationHours = 80
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Computer Science",
        Description = "Programming and Algorithms",
        DurationHours = 150
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "English",
        Description = "English Language Skills",
        DurationHours = 110
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "History",
        Description = "World History",
        DurationHours = 70
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Geography",
        Description = "Physical and Human Geography",
        DurationHours = 60
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Statistics",
        Description = "Statistics and Data Analysis",
        DurationHours = 95
    },

    new Courses
    {
        Id = Guid.NewGuid(),
        Name = "Artificial Intelligence",
        Description = "AI Fundamentals",
        DurationHours = 140
    }
];


public List<Courses> GetAllCourses()
    {
        
        return courses;
    }


public Courses GetCourseById(Guid Id)
    {
        return courses.LastOrDefault(c=>c.Id==Id);
    }

}