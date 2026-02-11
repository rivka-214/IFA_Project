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
```

### ▶️ Run the Project

1. **Run the application:**

```bash
ng serve
```
Open in browser:
 http://localhost:4200
---

## 🔗 API Endpoints

### 📌 Get All Users
* **Method:** `GET`
* **Path:** `/api/users`
* **Response:** `200 OK`

### 📌 Get User by ID
* **Method:** `GET`
* **Path:** `/api/users/{id}`
* **Response:** `200 OK` | `404 Not Found`

### 📌 Create User
* **Method:** `POST`
* **Path:** `/api/users`
* **Request Body Example:**

```json
{
  "id": 10,
  "name": "Test User"
}
```
* **Response:** `201 Created` | `400 Bad Request`

---

## 🧠 Technical Concepts Demonstrated 🧠

* **Separation of Concerns:** Component vs Service.
* **Angular HttpClient:** For HTTP communication.
* **Observables:** Asynchronous handling.
* **RESTful Routing:** Standard API design.
* **HTTP Status Codes:** Proper response handling.
* **CORS & JSON:** Configuration in Web API.

---

## 📎 Notes

* 🖇️ **No database is used** — data is stored in memory.
* The project focuses on clarity, structure, and clean communication.

