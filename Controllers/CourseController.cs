using basic.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller{

    public IActionResult Index(){
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "Güncel kurs";

        return View(kurs);
    }

    public IActionResult List()
    {
        var kurslar = new List<Course>()
        {
            new Course() {Id=1, Title="aspnetcore", Description="",Image="js.jpg"},
            new Course() {Id=2, Title="javascript", Description="",Image="js.jpg"},
            new Course() {Id=3, Title="python", Description="",Image="python.jpg"},
            new Course() {Id=4, Title="sql server", Description="",Image="Python.jpg"}
        };
        return View(kurslar);
    }
}