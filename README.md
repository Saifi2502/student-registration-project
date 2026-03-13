# Student Registration System

A **full-stack student registration application** built with **ASP.NET Core Web API** and a responsive frontend (HTML/CSS/JavaScript).

## Features

✅ **Frontend**
- Clean, responsive registration form
- Real-time student list display
- Auto-loads students on page load
- Success/error notifications

✅ **Backend (Web API)**
- `GET /api/students` - Retrieve all registered students
- `POST /api/students` - Register a new student
- CORS enabled for cross-origin requests
- Runs on .NET 10

## Tech Stack

- **Backend:** ASP.NET Core 10.0 Web API
- **Frontend:** HTML5, CSS3, Vanilla JavaScript
- **Runtime:** .NET 10
- **Storage:** In-memory (can be extended to use databases)

## Project Structure

```
student-registration-project/
├── Program.cs                      # API endpoints & CORS setup
├── Models/
│   ├── Student.cs                  # Student model
│   └── CreateStudentRequest.cs     # Request DTO
├── wwwroot/                        # Static frontend files
│   ├── index.html                  # Registration form & student list
│   ├── style.css                   # Styling
│   └── script.js                   # Frontend logic & API calls
└── student-registration-project.csproj  # Project configuration
```

## Running the Application

### Prerequisites
- .NET 10 SDK installed

### Steps

1. Navigate to the project directory:
   ```bash
   cd student-registration-project
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and go to:
   - **Frontend:** `http://localhost:5000/`
   - **API Docs:** `http://localhost:5000/openapi/v1.json` (in development)

## How It Works

1. **User fills the registration form** with student details (first name, last name, email, age)
2. **Form submits to `POST /api/students`** endpoint
3. **Backend creates a Student object** with a unique ID and stores it
4. **Frontend fetches all students** from `GET /api/students`
5. **Student list updates automatically** on the page

## Example Request

```bash
POST http://localhost:5000/api/students
Content-Type: application/json

{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@example.com",
  "age": 20
}
```

## Example Response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@example.com",
  "age": 20
}
```

## Future Enhancements

- 🗄️ Connect to SQL Server / SQLite database
- ✏️ Add edit & delete functionality
- 🔐 Add user authentication
- 📧 Email validation
- 🎨 More advanced UI with a framework (React/Vue)
- 📱 Mobile app support

## License

This project is open source and available under the MIT License.
