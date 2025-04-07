# Reactivities

Reactivities is a full-stack web application built as part of a project from the Udemy course **"Complete guide to building a full-stack app with .NET and React"**. This project demonstrates the integration of a .NET 9.0 backend with a React 19 frontend, showcasing modern web development practices.

## Features

- **Backend**:
  - ASP.NET Core 9.0 with Entity Framework Core for database management.
  - SQLite database with migrations for schema management.
  - Identity and authentication using ASP.NET Identity.
  - Middleware for exception handling and validation.
  - RESTful API endpoints for managing activities and user accounts.

- **Frontend**:
  - React 19 with TypeScript for a strongly-typed, modern UI.
  - State management using MobX and React Query.
  - Material-UI for responsive and accessible components.
  - React Router for client-side routing.
  - Integration with LocationIQ for location-based features.
  - Form validation using React Hook Form and Zod.

- **DevOps**:
  - Vite for fast development and build processes.
  - ESLint and TypeScript for code quality and consistency.
  - React Query DevTools for debugging API calls.

## Project Structure

The project is divided into the following main directories:

- **API**: Contains the .NET backend code, including controllers, middleware, and DTOs.
- **Application**: Contains application logic, including CQRS handlers, validators, and mappings.
- **Domain**: Defines the core domain models.
- **Persistence**: Handles database context and migrations.
- **Client**: Contains the React frontend code, including components, hooks, and stores.

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- Node.js (v18 or later)
- SQLite

### Backend Setup

1. Navigate to the `API` directory:
   ```bash
   cd API

2. Restore dependencies:
   ```bash
   Copydotnet restore

3. Apply database migrations:
   ```bash
    Copydotnet ef database update

4. Run the backend:
   ```
   bashCopydotnet run


### Frontend Setup

1. Navigate to the client directory:
   ```bash
   Copycd client

2. Install dependencies:
   ```bash
   Copynpm install

3. Start the development server:
   ```bash
   Copynpm run dev

4. Open your browser and navigate to http://localhost:3000.

## API Endpoints
- Activities:
    - GET /api/activities: Retrieve all activities.
    - GET /api/activities/{id}: Retrieve a specific activity by ID.
    - POST /api/activities: Create a new activity.
    - PUT /api/activities: Update an existing activity.
    - DELETE /api/activities/{id}: Delete an activity.

- Account:
    - POST /api/account/register: Register a new user.
    - POST /api/account/login: Log in a user.
    - GET /api/account/user-info: Retrieve the current user's information.

## Technologies Used
- Backend:
    - ASP.NET Core 9.0
    - Entity Framework Core
    - FluentValidation
    - MediatR
    - AutoMapper

- Frontend:
    - React 19
    - TypeScript
    - MobX
    - React Query
    - Material-UI
    - React Hook Form
    - Zod

- Database:
    - SQLite

## License 
This project is for educational purposes as part of the Udemy course and is not intended for production use.
Acknowledgments
Special thanks to the instructor of the Udemy course for providing guidance and resources to build this project.
Copy