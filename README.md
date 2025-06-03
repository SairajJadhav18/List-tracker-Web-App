Author
Sairaj Jadhav
Student Developer  

Created 03-06-2025

Feel free to fork, star, or contribute!

Task Tracker Web App

A simple ASP.NET Core MVC web application that allows users to manage tasks with a clean UI. Users can add tasks, set due dates, assign priorities, mark tasks as completed, and filter tasks by priority — all in the browser.


Features

-  Add new tasks with title, priority, and due date
-  Mark tasks as completed
-  Filter tasks by priority (Low, Medium, High)
-  Sort tasks by due date (ascending)
-  Built with ASP.NET Core MVC and Razor views
-  Styled with Bootstrap 5

---

Technologies Used

- ASP.NET Core MVC (.NET 6+)
- Razor Views
- C# Object-Oriented Programming
- Bootstrap 5 (CDN)
- HTML5 & CSS3
- In-memory data storage (`List<Task>`)



Project Structure

TaskTrackerWeb/
├── Controllers/
│ └── TaskController.cs
├── Models/
│ └── Task.cs
├── Views/
│ └── Task/
│ └── Index.cshtml
├── wwwroot/ (
├── Program.cs
├── launchSettings.json

How to Run Locally

1. Clone the Repository


git clone https://github.com/your-username/TaskTrackerWeb.git
cd TaskTrackerWeb

2. Run the Application
dotnet build
dotnet run

3. Access in Browser
Open http://localhost:5125/Task
(Port may vary — check your console output)

Highlights

Clear MVC structure (Model-View-Controller)

Clean separation of logic and presentation

Responsive design via Bootstrap

Easily extendable (add task editing, database storage, user login, etc.)

Future Enhancements
Save tasks to a file or local database (SQL Server / SQLite)

Add user authentication

Deploy to Azure App Service

Add edit/delete functionality

Export task list to CSV




 
