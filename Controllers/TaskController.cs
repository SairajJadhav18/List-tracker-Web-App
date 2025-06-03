using Microsoft.AspNetCore.Mvc;
using TaskTrackerWeb.Models;
using System.Collections.Generic;
using System.Linq;

namespace TaskTrackerWeb.Controllers
{
    public class TaskController : Controller
    {
        static List<Models.Task> tasks = new List<Models.Task>();
        static int nextId = 1;

        public IActionResult Index(string priorityFilter)
{
    var filteredTasks = tasks;

    // Filter by priority if selected
    if (!string.IsNullOrWhiteSpace(priorityFilter))
    {
        filteredTasks = filteredTasks
            .Where(t => string.Equals(t.Priority, priorityFilter, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // Sort by due date (ascending), nulls last
    filteredTasks = filteredTasks
        .OrderBy(t => t.DueDate ?? DateTime.MaxValue)
        .ToList();

    ViewBag.SelectedPriority = priorityFilter;
    return View(filteredTasks);
}


        [HttpPost]
public IActionResult Add(string title, DateTime? dueDate, string priority)
{
    if (!string.IsNullOrWhiteSpace(title))
    {
        tasks.Add(new Models.Task
        {
            Id = nextId++,
            Title = title,
            IsCompleted = false,
            DueDate = dueDate,
            Priority = priority
        });
    }
    return RedirectToAction("Index");
}


        public IActionResult Complete(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
            }
            return RedirectToAction("Index");
        }
    }
}
