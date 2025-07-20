# Contacts Management System

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

> A production-ready contact management system implementing clean 3-tier architecture with C# and SQL Server.

## Architecture

```
┌─────────────────────────────────────────────┐
│    ConsoleApp-PresentationLayer            │  ← User Interface
├─────────────────────────────────────────────┤
│    ContactsBusinessLayer                   │  ← Business Logic
├─────────────────────────────────────────────┤
│    ContactsDataAccessLayer                 │  ← Data Persistence
└─────────────────────────────────────────────┘
```

## Project Structure

```
contacts-management-system/
├── ConsoleApp-PresentationLayer/
│   ├── Program.cs
├── ContactsBusinessLayer/
│   ├── Contacts.cs
├── ContactsDataAccessLayer/
│   ├── ContactsDataAccess.cs
│   ├── Dataacces_Helper.cs

└── README.md
```

## Features

- **Clean Architecture**: Strict separation of concerns
- **SOLID Principles**: Maintainable and extensible codebase
- **Database Integration**: Full CRUD operations with SQL Server
- **Error Handling**: Comprehensive exception management
- **Scalable Design**: Easy to extend and modify

## Tech Stack

| Layer | Technology |
|-------|------------|
| **Presentation** | C# Console Application |
| **Business** | C# Class Library |
| **Data Access** | ADO.NET + SQL Server |
| **Development** | Visual Studio 2022 |

## Quick Start

```bash
# Clone the repository

git clone https://github.com/aboubakr-jelloulat/Dot-Net-Tiered-Architecture.git

# Open in Visual Studio
cd contacts-management-system
start ContactsManagementSystem.sln

# Build and run
dotnet build
dotnet run --project ConsoleApp-PresentationLayer
```

## Dependencies

```
ConsoleApp-PresentationLayer
    │
    └── ContactsBusinessLayer
            │
            └── ContactsDataAccessLayer
```

## Architecture Benefits

| Benefit | Description |
|---------|-------------|
| **Maintainability** | Single responsibility per layer |
| **Testability** | Independent layer testing |
| **Scalability** | Easy feature additions |
| **Flexibility** | Technology-agnostic design |

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit changes (`git commit -m 'Add amazing feature'`)
4. Push to branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request



<div align="center">
  <strong>Built with ❤️ by Software Engineers</strong>
</div>
