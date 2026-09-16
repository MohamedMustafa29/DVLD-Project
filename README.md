# DVLD_Project

```markdown
# 🚗 Drivers and Vehicles License Department (DVLD) System

A comprehensive Desktop Application for managing driver and vehicle licensing operations, built with **C# (.NET)** and **SQL Server** using a clean **3-Tier Architecture**.

---

## 🌟 Features

* **Person & User Management:** Complete CRUD operations for handling system users and individual profiles with role-based access.
* **Driver & Vehicle Licensing:** Comprehensive management for issuing, renewing, replacing, and tracking driver licenses.
* **Application Processing:** Workflow management for various license application types and test appointments.
* **Advanced Search & Filtering:** Quick search across records by Person ID, Driver ID, National No., or Full Name with real-time partial matching.
* **Database Integration:** Robust data layer with generic connection settings for seamless local database setup.

---

## 🏗️ Architecture

The solution follows a strict **3-Tier Architecture** pattern to ensure separation of concerns, scalability, and clean code principles:

```text
DVLD-Project/
│
├── DVLD/                # Presentation Layer (WinForms UI)
├── DVLD_Business/       # Business Logic Layer (BLL)
├── DVLD_DataAccess/     # Data Access Layer (DAL)
└── Database/            # SQL Scripts for Schema & Data Initialization

```

---

## 🛠️ Built With

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** Microsoft SQL Server
* **Architecture:** 3-Tier Architecture (UI, Business, Data Access)

---

## 🚀 Getting Started

### Prerequisites

* [Visual Studio 2019/2022](https://visualstudio.microsoft.com/) with .NET Desktop Development workload.
* [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/) & SQL Server Management Studio (SSMS).

### Installation & Setup

1. **Clone the Repository:**
```bash
git clone [https://github.com/MohamedMustafa29/DVLD-Project.git](https://github.com/MohamedMustafa29/DVLD-Project.git)

```


2. **Database Setup:**
* Open SQL Server Management Studio (SSMS).
* Open and execute the script located at `Database/DVLD_Database.sql` to generate the database schema and sample data.


3. **Run the Application:**
* Open `DVLD.sln` in Visual Studio.
* Ensure `DVLD` is set as the **Startup Project**.
* Press `F5` or click **Start** to run the application.



---

## 📝 Connection String Configuration

The default connection string is configured generically to work out-of-the-box with local SQL Server instances:

```csharp
string connectionString = "Server=.;Database=DVLD;Integrated Security=True;TrustServerCertificate=True";

```

---

## 👤 Author

* **Mohamed Mustafa** - [GitHub Profile](https://www.google.com/search?q=https://github.com/MohamedMustafa29)

```

</Elicitations>

```
