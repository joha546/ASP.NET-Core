# ASP.NET Core Custom Middleware Implementation

This project demonstrates how to create and test custom middleware in **ASP.NET Core**. It includes:  
- A **Request Logging Middleware** to log incoming HTTP requests.  
- A **Short-Circuiting Middleware** to intercept specific requests and return custom responses directly.
- Test each Middleware API using Postman and Swagger.

## Features  
1. **Request Logging Middleware**  
   - Logs details of each HTTP request (e.g., method, path, headers).  
   - Helps monitor and debug request traffic.  

2. **Short-Circuiting Middleware**  
   - Intercepts requests to specific paths (e.g., `/short-circuit`).  
   - Responds with a **403 Forbidden** status and a custom message without proceeding further in the pipeline.  

## File Structure  
```
CustomMiddleware/
├── Controllers/                    # Controllers for handling API requests
├── Properties/                     # Project metadata
├── appsettings.Development.json    # Development-specific configurations
├── appsettings.json                # Application configurations
├── CustomMiddleware.csproj         # Project file
├── CustomMiddleware.http           # HTTP file for testing API requests
├── Program.cs                      # Main application entry point
├── RequestLoggingMiddleware.cs     # Middleware to log incoming requests
├── ShortCircuitingMiddleware.cs    # Middleware to short-circuit requests
├── WeatherForecast.cs              # Sample data model



## How to Use  

1. Clone the repository:  
   ```bash
   git clone https://github.com/joha546/ASP.NET-Core/CustomMiddleware.git
   cd CustomeMiddleware
   ```

2. Run the application:  
   ```bash
   dotnet run
   ```

3. Test the middleware using **Postman** or any API client:  
   - Send a request to `/shortcircuit` to test the short-circuiting logic.  
   - Send a request to other endpoints to see request logs in the console.

## API Testing  

### Short-Circuiting Example  
**Request**  
```
GET https://localhost:7259/short-circuit
```

**Response**  
```http
Status Code: 403 Forbidden
Body: "Request was short-circuited!"
```

### Regular Request Example  
**Request**  
```
GET https://localhost:5001/api/values
```

**Response**  
Handled by the appropriate controller.

## Learnings  
- Middleware in ASP.NET Core allows you to handle HTTP requests and responses at a granular level.  
- Short-circuiting is useful for scenarios like request filtering, authentication, or custom error handling.  
- Postman is an effective tool for testing middleware behavior.

## Technologies Used  
- **ASP.NET Core Web API**  
- **Postman** for API testing  
