using Microsoft.AspNetCore.Mvc;
using WebApplication15.Data;

public class ProjectsController : Controller
{
    private readonly AppDbContext _context;

    public ProjectsController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Search(string searchString)
    {
        var projects = _context.Projects.AsQueryable();

        if (!string.IsNullOrEmpty(searchString))
        {
            projects = projects.Where(p => p.Name.Contains(searchString) || p.Description.Contains(searchString));
        }

        return View(projects.ToList()); // This should be a List<WebApplication15.Models.Project>
    }

}
