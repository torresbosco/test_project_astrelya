# Simple Web API Project

This project is a simple RESTful Web API built using C#. It provides a basic implementation for managing Todo items.

## Project Structure

```
SimpleWebApi
├── Controllers
│   └── TodoController.cs
├── Models
│   └── TodoItem.cs
├── Program.cs
├── Startup.cs
├── appsettings.json
└── README.md
```

## Features

- **TodoController**: Handles HTTP requests related to Todo items.
  - `GetTodos`: Retrieve all Todo items.
  - `GetTodo`: Retrieve a specific Todo item by ID.
  - `CreateTodo`: Create a new Todo item.
  - `UpdateTodo`: Update an existing Todo item.
  - `DeleteTodo`: Delete a Todo item.

- **TodoItem Model**: Represents a Todo item with the following properties:
  - `Id` (int): Unique identifier for the Todo item.
  - `Title` (string): Title of the Todo item.
  - `IsCompleted` (bool): Status indicating if the Todo item is completed.
  - `CreatedAt` (DateTime): Timestamp of when the Todo item was created.

## Setup

1. Clone the repository or download the project files.
2. Open the project in your preferred IDE.
3. Restore the dependencies.
4. Run the application.

## Usage

Once the application is running, you can interact with the API using tools like Postman or curl. The API endpoints allow you to manage Todo items effectively.

## License

This project is licensed under the MIT License.