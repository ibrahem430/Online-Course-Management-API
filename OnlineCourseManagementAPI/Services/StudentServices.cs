using OnlineCourseManagementAPI.Models;

namespace OnlineCourseManagementAPI.Services;


public class StudentServices
{
    public List<Student> students =
[
    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Ahmad Ali",
        Email = "ahmad.ali@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Sara Khaled",
        Email = "sara.khaled@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Omar Hassan",
        Email = "omar.hassan@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Lina Samir",
        Email = "lina.samir@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Yousef Ahmad",
        Email = "yousef.ahmad@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Maya Naser",
        Email = "maya.naser@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Khaled Salem",
        Email = "khaled.salem@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Rana Ibrahim",
        Email = "rana.ibrahim@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Tariq Adel",
        Email = "tariq.adel@example.com"
    },

    new Student
    {
        Id = Guid.NewGuid(),
        Name = "Noor Mahmoud",
        Email = "noor.mahmoud@example.com"
    }
];
}