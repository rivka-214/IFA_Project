# User Management Mini App  
Angular + .NET Framework Web API 2

## 📌 Project Overview

This project is a simple end-to-end application built with:

- **Client:** Angular
- **Server:** C# Web API 2 (.NET Framework 4.8)
- **Data:** In-memory mock data (no database)

The application displays a list of users and loads users from the server via HTTP communication.

---

## 🏗 Architecture Overview

### Client (Angular)

- `User` interface (TypeScript model)
- `UserListComponent` – displays mock users and server users
- `UserService` – responsible for HTTP communication
- Uses `HttpClient` and `Observable` for async data handling

### Server (.NET Web API 2)

- `User` model (POCO)
- `UsersController`
  - `GET /api/users` – returns mock user list
  - `GET /api/users/{id}` – returns user by id
  - `POST /api/users` – accepts new user and returns appropriate HTTP status
- CORS enabled for Angular communication
- JSON responses formatted as camelCase

---

## 🚀 How to Run the Project

### 1️⃣ Run the Server

1. Open the **Server** solution in Visual Studio.
2. Set the project as Startup Project.
3. Run the project (IIS Express).
4. Note the server URL (for example: `http://localhost:XXXX`).

The API base route:

http://localhost:4200/api/users


---

### 2️⃣ Run the Angular Client

1. Navigate to the Angular project folder.
2. Install dependencies:

```bash
npm install
Run the project:

ng serve
Open in browser:

http://localhost:4200
🔗 API Endpoints
GET All Users
GET /api/users
Response: 200 OK

GET User by ID
GET /api/users/{id}
Response:

200 OK

404 Not Found

POST Create User
POST /api/users
Request Body example:

{
  "id": 10,
  "name": "Test User"
}
Response:

201 Created

400 Bad Request

🧠 Technical Concepts Demonstrated
Separation of Concerns (Component vs Service)

HTTP communication using Angular HttpClient

Observables and asynchronous handling

RESTful routing

Proper HTTP status codes

CORS configuration

JSON formatting configuration in Web API

📎 Notes
No database is used — data is stored in memory.

The project focuses on clarity, structure, and clean communication between client and server.

