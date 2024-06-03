# User Management Backend API

This backend API is built using ASP.NET Core Web API and MongoDB to support CRUD operations for managing user data. It provides endpoints for fetching, creating, updating, and deleting user details stored in a MongoDB database.

## Features

- **Get Users**: Retrieve a list of all users.
- **Get User by ID**: Retrieve a specific user by their unique ID.
- **Create User**: Add a new user to the database.
- **Update User**: Modify an existing user's information.
- **Delete User**: Remove a user from the database.

## How to Run

### Prerequisites

- .NET Core SDK installed on your machine.
- Access to a MongoDB instance.

### Clone the Repository

```bash
git clone https://github.com/your-username/your-repository.git
```

After that Open the project in Microsoft Visual Studio 2022 and then Run it.
Go to Program.cs add the the server Link in CORS for the frontend, also check careful on which port your Dot net api is hosting and use that Port while creating frontend.

For Front-End - https://github.com/geekyharsh01/user-crud-app
