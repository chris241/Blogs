# Blog - Web Api ASP.NET Core 

## Overview

## Features
Feature 1: "CRUD for blog posts"
## Technologies Used
* .NET 8 SDK.
* Postgresql.
* Visual Studio 2022 or Visual Studio Code (optional but recommended for development).
*  Docker Desktop.
*  Serilog (logging error of application)

  
## Getting Started

1. Clone the Repository
* git clone
  
  https://github.com/chris241/Blogs.git

2. Install Dependencies
 * Restore the NuGet packages:
  dotnet restore
  
## How To Run
* Open solution in Visual Studio 2022
* Set .csproj project as Startup Project and build the project.
* Run the application.

   or

* Launch command :  Docker-compose up

## API Documentation
This project uses Swagger for API documentation. Once the application is running, you can access the Swagger UI at:

https://localhost:57855/swagger/index.html
http://localhost:8081/#/events?range=1d

This provides detailed information about all available API endpoints, request/response formats, and authorization requirements.
