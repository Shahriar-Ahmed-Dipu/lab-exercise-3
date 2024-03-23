using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebApplication15.Data; // Ensure this is using the correct namespace
using WebApplication15.Areas.ProjectManagement.Models; // Ensure models are using the correct namespace

public class TasksController : Controller
{
    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Search(string searchString)
    {
        // If searchString is not null or empty, search in ProjectTasks
        var tasks = !string.IsNullOrEmpty(searchString) ?
                    _context.ProjectTasks.Where(t => t.Title.Contains(searchString) || t.Description.Contains(searchString)).ToList() :
                    _context.ProjectTasks.ToList(); // If searchString is empty, return all ProjectTasks

        return View(tasks); // Make sure you have a corresponding view named 'Search' in the Views/Tasks folder
    }
}
