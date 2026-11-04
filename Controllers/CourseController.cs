
using Microsoft.AspNetCore.Mvc;
using SkillingAPI.Models;

namespace SkillingAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    
    private static readonly List<Course> courses = new()
    {
        new Course
        {
            Id = 1,
            Title = "Azure Fundamentals",
            Description = "Introduction to Microsoft Azure",
            DurationHours = 5,
            IsPublished = true
        },

        new Course
        {
            Id = 2,
            Title = "C# Programming",
            Description = "Learn C# and .NET development",
            DurationHours = 8,
            IsPublished = true
        },

        new Course
        {
            Id = 3,
            Title = "Introduction to AI",
            Description = "Machine learning fundamentals",
            DurationHours = 6,
            IsPublished = false
        }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Course>> GetCourses()
    {
        return Ok(courses);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Course> GetCourseById(int id)
    {
        var course = courses.FirstOrDefault(c => c.Id == id);
        if (course == null)
        {
            return NotFound();
        }
        return Ok(course);
    }
}


