# WorkDesk – Employee Management System

WorkDesk is a full-stack Employee Management System developed using **C#, .NET 8, ASP.NET Core Web API, WinForms, SQL Server, Worker Service, VBA and xUnit**.

The project demonstrates how a desktop application can communicate with a backend Web API, how the backend interacts with SQL Server, how a background service monitors database activity, and how Excel VBA can be used for reporting.

---

## 🚀 Project Overview

WorkDesk provides an employee management workflow with:

- Employee CRUD operations
- WinForms desktop client
- ASP.NET Core Web API
- SQL Server database integration
- Background Worker Service
- Excel VBA reporting
- Unit and Integration Testing
- Layered application structure
- REST API communication
- Parameterized SQL queries

---

## 🏗️ Architecture

```text
                    ┌─────────────────────┐
                    │      User           │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │ WorkDesk.Client     │
                    │ C# WinForms         │
                    └──────────┬──────────┘
                               │ HTTP
                               ▼
                    ┌─────────────────────┐
                    │ WorkDesk.API       │
                    │ ASP.NET Core Web API│
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │ EmployeeController  │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │ EmployeeService     │
                    └──────────┬──────────┘
                               │
                               ▼
                    ┌─────────────────────┐
                    │ SQL Server          │
                    │ WorkDeskDB          │
                    └─────────────────────┘


          ┌───────────────────────────────┐
          │ WorkDesk.Service              │
          │ Background Worker Service     │
          └───────────────┬───────────────┘
                          │
                          ▼
                    SQL Server
                          │
                          ▼
                Employee Count Monitoring


          ┌───────────────────────────────┐
          │ Excel VBA                     │
          │ ADO SQL Integration            │
          └───────────────┬───────────────┘
                          │
                          ▼
                    SQL Server
