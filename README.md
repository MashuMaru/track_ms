# track_ms
Workout tracker 
(Track_MS)

(Inspiration from https://medium.com/@sanderdebr/building-a-workout-tracker-with-react-and-firebase-part-3-custom-calendar-7f13a580b085)

#### OUTLINE:

- Sign in with Authentication, email and password. (Only expecting traffic from two people.)
- Ability to set a workout
-   Number of sets
-   Number of reps
-   Weight
-   Exercise (saveable as a workout category)
- Ability to create workout with an image.
-   Assigned against the user id.
-   Assigned against an excercise category id.
- Ability to create excercise category
-   Cardio (provided)
-   Weights (provided)
- Ability to view past exercises based on:
-   Attendance to gym (maybe a calendar view?)
-   Exercise configuration (in a table, displaying the weight, day, tooltip of reps/sets)
-   Pagination on the table to only retrieve 10 rows/page.
-   Filterable by day/category/workout

#### TECHSTACK:

Frontend: React + Redux State Management
Backend: C# .NET 8, Entity Framework. 
Data Access: Azure SQL *(user data, exercise data), Container storage *(images). 

#### AUTHENTICATION:

Using ASP.NET WebAPI Identity (register user, login user)
- Nuget: Microsoft.AspNetCore.Identity.EntityFrameworkCore

##### Create WebAPI
dotnet new sln
dotnet new webapi -o [NameOfProject].Web -- Controllers, DTO's
dontet new classlib -o [NameOfProject].Services -- Business logic layer
dontet new classlib -o [NameOfProject].Data -- Data access layer

[Dependancies]
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlLite (Development DB -- Later migration to Azure SQL.)
[Migration]
dotnet ef nuget
dotnet tool install --global dotnet-ef --version 8.0.2 (already installed)
dotnet ef migrations add InitialCreate -o Data/Migrations (To create a first migration)
dotnet ef database update (Creates database in SQL Lite)