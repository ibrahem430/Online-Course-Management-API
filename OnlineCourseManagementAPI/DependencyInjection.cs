using OnlineCourseManagementAPI.Models;
using OnlineCourseManagementAPI.Services;

namespace OnlineCourseManagementAPI;


public static class DependencyInjection
{
    public static IServiceCollection Services(this IServiceCollection services)
    {
        services.AddControllers().AddXmlSerializerFormatters();
        services.AddSingleton<EnrollmentServices>();
        services.AddSingleton<CoursesServices>();
        services.AddSingleton<StudentServices>();
        return services;
    }
}