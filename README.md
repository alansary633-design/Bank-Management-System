# Bank Management System

A desktop banking application built with **C# (Windows Forms)** and **SQL Server**, implementing a clean 3-tier architecture (UI → Business Logic → Data Access). The system manages bank employees (users), clients, accounts, currency exchange rates, and inter-client money transfers.

## Features

- **Authentication & Role-Based Permissions** — login system with a bitwise permission model (`AddClient`, `DeleteClient`, `UpdateClient`, `Transactions`, `ManageUsers`, `UpdateCurrencies`, or full access), enforced centrally before any sensitive operation runs.
- **Client Management** — full CRUD for client records, each linked to a unique account number, PIN, and balance.
- **User Management** — admins can create employee accounts and assign granular permission sets per user.
- **Money Transfers** — transfer funds between client accounts, with every transaction recorded in a searchable transfer log.
- **Currency Management** — maintain multiple currencies with country, code, and exchange rate, with rates updatable independently.
- **Live Search** — instant, in-memory filtering on the clients and users grids as you type.

## Architecture

The solution is split into three distinct layers, each as its own project:

```
Bank1.1            → Windows Forms UI (Login, Main Menu, Clients, Users, Transactions, Currencies, Transfer Log)
BusinessBank1 /
clsBusinessBank1    → Business logic layer (clsPersons, clsClients, clsUsers, clsCurrencies)
DataBank1 /
clsDataBank1        → Data access layer (raw SQL via ADO.NET / SqlClient)
```

**Object-oriented design:** `clsClients` and `clsUsers` both inherit from a shared `clsPersons` base class, modeling the real-world relationship that a client and a system user are both, fundamentally, a person with contact details — while each adds its own specific data (account/PIN/balance for clients, username/password/permissions for users).

All Forms share a common base form (`frmDesigne`) that provides the live clock, logout control, and the centralized `CheakAccessRights()` permission check used across the app.

## Tech Stack

- **Language:** C# (.NET Framework, Windows Forms)
- **Database:** Microsoft SQL Server
- **Data Access:** ADO.NET (`SqlConnection`, `SqlCommand`, parameterized queries)
- **Pattern:** 3-tier architecture, Object-Oriented Design (inheritance, encapsulation)

## Database

The database schema (`DB1`) consists of five tables: `Persons`, `Users`, `Clients`, `Currencies`, and `Transfers`, connected through foreign keys (e.g. both `Users` and `Clients` reference `Persons`; `Transfers` references `Users` and `Clients` twice — source and destination).

## How to Run

1. Open `Bank1.1.sln` in Visual Studio.
2. Restore/build all three projects (`Bank1.1`, `BusinessBank1`, `DataBank1`).
3. Make sure SQL Server is running locally, and update the connection string in `clsDataSetting.cs` (under the Data Access project) to match your server instance.
4. Run the database setup script to create the `DB1` schema and seed sample data (see `/database` if included, or restore from a `.bak` backup).
5. Set `Bank1.1` as the startup project and run (`F5`).

## Notes

This project was built as part of a self-driven software development learning path, with a focus on applying OOP principles and a clean separation of concerns across UI, business logic, and data access layers.
