# Farm Management System

This project was developed as part of a **Database Management Systems** course to simulate the digital transformation of agricultural enterprises and livestock farms. It focuses on maintaining data integrity through a relational structure while providing a role-based user experience.

---

## 🛠 Tech Stack
* **Language:** C# (.NET WinForms)
* **Database:** MSSQL Server
* **Data Access:** Entity Framework
* **Security:** SHA-256 Password Hashing

---

## 🌟 Key Features

### 🔐 Advanced Authorization & Role Management
The system provides a dynamic interface based on user roles (Admin vs. Personnel):
* **Admin:** Full access to all forms, reports, and management panels.
* **Personnel:** Access is restricted to assigned workspaces. A personnel member can be assigned to a minimum of 1 and a maximum of 2 workspaces, demonstrating complex many-to-many relationship management.

### 🛡️ Security & Credential Management
* **Password Hashing:** To ensure data privacy, passwords are never stored as plain text. They are hashed before being sent to the database, preventing unauthorized access even at the DB level.
* **Auto-Generation:** When an admin creates a new employee, the system generates a temporary password using the format `Surname+ID` (e.g., *Wick123456789*).
* **Account Manager:** Users can securely update their credentials through a dedicated management interface.

### 📊 Database Architecture
The project is built on a normalized relational database schema to ensure data consistency and efficient querying.
* **Business Logic:** Implemented through constraints and relational mappings to handle farm-specific operational data.

---

## 🚀 Suggested Accounts for Testing
To explore the full capabilities of the system (including permission restrictions), please use the following credentials:

| Role | User ID (National ID) | Password |
| :--- | :--- | :--- |
| **Admin** | `12345678910` | `123456` |
| **Personnel** | *(Any Personnel ID in DB)* | `Surname+ID` |

---

## 📥 Installation & Setup
1.  Clone the repository:  
    `git clone https://github.com/yourusername/farm-management-system.git`
2.  Execute the provided **SQL script** in your **MSSQL Server** instance.
3.  Update the **Connection String** in the `App.config` file to match your local server environment.
4.  Build and run the project via **Visual Studio**.

---

*This project is a result of an academic study and is intended for demonstration and learning purposes.*
