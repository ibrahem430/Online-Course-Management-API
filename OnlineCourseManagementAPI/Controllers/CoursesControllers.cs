using System;
// using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using OnlineCourseManagementAPI.Response;
using OnlineCourseManagementAPI.Services;

namespace OnlineCourseManagementAPI.Controllers;

[Route ("API/Courses")]
public class CoursesControllers(CoursesServices coursesServices): ControllerBase
{

[HttpGet("AllCourses")]
[Produces ("application/json","application/xml")]
    public IActionResult Get()
    {
        var courses=coursesServices.GetAllCourses();

        if (courses == null)
        {
            return NotFound();
        }
        return Ok(CoursesResponse.FormModels(courses));
    }

    [HttpGet("{CourseId:guid}")]
    public IActionResult getById(Guid CourseId)
    {
        var course=coursesServices.GetCourseById(CourseId);
        if (CourseId == null)
        {
            return NotFound();

        }
        return Ok(course);
    }
    
}