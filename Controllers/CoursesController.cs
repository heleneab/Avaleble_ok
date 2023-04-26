using Microsoft.AspNetCore.Mvc;
using test_4.Data;
using test_4.Models;


namespace test_4.Controllers;

public class CoursesController : Controller
{
    // Added private field for the application db context
    private readonly ApplicationDbContext _db;
    
    // Constructor with db context as a parameter
    public CoursesController(ApplicationDbContext db)
    {
        _db = db;
    }

    // GET
    public IActionResult Index()
    {
        // Fetch authors from the database
        var controllers = _db.Courses1.ToList();
        
        // Send the list to the view. The view declares its model as @model IEnumerable<Author> to match.
        return View(controllers);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View(new Courses());
    }
    
    [HttpPost]
    public IActionResult Add(Courses controller)
    {
        if (!ModelState.IsValid)
            return View(controller);

        _db.Courses1.Add(controller);
        _db.SaveChanges();
        
        return RedirectToAction(nameof(Index));
    }
}