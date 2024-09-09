# CMCSApp
# Contract Monthly Claim System (CMCS)

## Overview

The **Contract Monthly Claim System (CMCS)** is a web-based application designed to streamline the process of submitting and approving monthly claims for independent contractor lecturers. Lecturers can submit claims for work completed, and academic managers and program coordinators can review, approve, or reject these claims. The system is built using the **.NET Core MVC** framework, offering a user-friendly interface for both lecturers and administrative staff.

## Features

### Lecturer
- **Submit Claims**: Lecturers can submit claims for the hours worked on different modules. The form captures personal and claim-specific details such as the module, hours, hourly rate, and program.
- **View Previous Claims**: Lecturers can view previously submitted claims, which include the status (pending, approved, or rejected). Claims with a pending status can be edited, while approved or rejected claims are read-only.
- **Filter/Search Claims**: A filter/search functionality allows lecturers to easily find claims based on module or status.
- **Upload Supporting Documents**: Lecturers can upload optional supporting documents when submitting claims.

### Program Coordinator
- **Review Claims**: Program coordinators can review claims submitted by lecturers, verifying details such as the module taught, hours worked, and rate.
- **Edit or Confirm Claims**: Program coordinators can edit details if necessary or confirm the accuracy of claims before proceeding to approval.
- **Ensure Claim Integrity**: Coordinators are responsible for ensuring that all claim details are correct before they are forwarded for final review or approval.

### Academic Manager
- **Approve/Reject Claims**: Academic managers have the ability to review submitted claims and either approve or reject them. 
- **View Claim Details**: The manager can view all claim-related details, including modules, hours worked, total amounts, and supporting documents.
- **Status Updates**: Managers update the status of each claim (approved, pending, or rejected) after reviewing them.

## System Architecture
The system follows a **Model-View-Controller (MVC)** design pattern:

1. **Model**: Represents the database structure, capturing claim information, user profiles, and system status updates.
2. **View**: The user interface for lecturers, coordinators, and managers to interact with the system. It is designed with user experience in mind, allowing easy submission, review, and management of claims.
3. **Controller**: Manages the interaction between the views and models, handling the business logic of claim submission, review, and approval.

## Installation and Setup

1. **Prerequisites**:
   - .NET Core SDK (Version 6.0 or higher)
   - Visual Studio or any IDE supporting .NET Core projects
   - SQL Server or any compatible database system for storing claim and user data

2. **Steps to Run the Project**:
   - Clone the repository from the source control platform.
   - Open the solution in Visual Studio or your preferred IDE.
   - Restore NuGet packages using the package manager console or through the IDE's restore function.
   - Update the connection string in `appsettings.json` to point to your database server.
   - Run the migrations to set up the database using the Entity Framework Core.
     ```bash
     dotnet ef database update
     ```
   - Build and run the project using the IDE or from the terminal:
     ```bash
     dotnet run
     ```
   - Open the application in your browser using the provided URL (usually `https://localhost:5001`).

## Usage Guide

### 1. Logging In
   - Lecturers, program coordinators, and academic managers can log in with their respective credentials.
   - If you don’t have an account, please contact your system administrator to create one.

### 2. Submitting Claims (Lecturer)
   - Once logged in, click on **Submit Claim** to enter details such as the program, module, hours worked, and hourly rate.
   - Optionally, upload supporting documents for the claim.
   - Click **Submit** to send the claim for review.

### 3. Reviewing Claims (Coordinator)
   - Review claims submitted by lecturers by clicking **View Claims**.
   - You can edit claim details if needed or confirm the accuracy of the claim.

### 4. Approving/Rejecting Claims (Manager)
   - Managers can view claims awaiting approval.
   - Select either **Approved** or **Rejected** from the dropdown to update the status of the claim.

## Project Structure
```
/Controllers
    Contains the controllers that manage the interactions between the views and models.

/Models
    Defines the data structures and relationships for claims, users, and other entities.

/Views
    Contains the Razor view files that define the user interface for lecturers, coordinators, and managers.

/wwwroot
    Static files such as CSS, JS, and images used for the front-end design.

/Migrations
    Contains the database migration files for Entity Framework Core.

/appsettings.json
    Configuration settings such as database connections and environment settings.
```

