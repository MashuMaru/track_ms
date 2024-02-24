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
- Ability to create workout categories with an image.
-   Assigned against the user id.
- Ability to view past exercises based on:
-   Attendance to gym (maybe a calendar view?)
-   Exercise configuration (in a table, displaying the weight, day, tooltip of reps/sets)

#### TECHSTACK:

Frontend: React + Redux State Management
Backend: C# .NET 8, Entity Framework. 
Data Access: Azure SQL *(user data, exercise data), Container storage *(images). 

#### AUTHENTICATION:

Using ASP.NET WebAPI Identity (register user, login user)
- Nuget: Microsoft.AspNetCore.Identity.EntityFrameworkCore

##### Create WebAPI
dotnet new sln