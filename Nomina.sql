-- Sistema de administración de nómina
USE PayrollDB

-- Roles
-- //Posibles roles:
--				________________
--				|			   |
--				|1. SUPER_ADMIN|
--				|2. ADMIN      |
--				|3. HR         |
--				|4. ACCOUNTANT |
--				|______________|
--
-- //El empleado NO tiene usuario/rol, porque nunca utilizará el sistema.
-- // Los roles estan en JERARQUÍA, NO pueden ser insertados en otro orden.

CREATE TABLE Roles(
	R_ID INT IDENTITY(1,1) PRIMARY KEY,

	R_Name NVARCHAR(100) NOT NULL,
	R_Description NVARCHAR(100) NOT NULL,

	R_IsActive BIT NOT NULL DEFAULT 1,

	R_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);

-- //Datos fijos del sistema
INSERT INTO Roles (R_Name, R_Description)
VALUES
('SUPER_ADMIN', 'Full system access'),
('ADMIN', 'System administrator'),
('HR', 'Human Resources'),
('ACCOUNTANT', 'Payroll accountant');

-- Users
CREATE TABLE Users(
	U_ID INT IDENTITY(1,1) PRIMARY KEY,
	U_R_ID INT NOT NULL, -- //Llave foránea a tabla: "Roles"

	U_FirstName NVARCHAR(100) NULL,
	U_MiddleName NVARCHAR(100) NULL,
	U_LastName NVARCHAR(100) NULL,
	U_Username NVARCHAR(255) NOT NULL,
	U_PswrdHash NVARCHAR(100) NOT NULL,

	U_IsActive BIT NOT NULL DEFAULT 1,

	U_CreatedBy INT NULL,
	U_UpdatedBy INT NULL,

	U_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    U_UpdatedAt DATETIME2 NULL,
    U_LastLoginAt DATETIME2 NULL,

	CONSTRAINT UQ_Users_Username -- //Username único
        UNIQUE (U_Username),

    CONSTRAINT FK_Users_Roles -- //Asignar rol del usuario
        FOREIGN KEY (U_R_ID)
        REFERENCES Roles(R_ID),

    CONSTRAINT FK_Users_CreatedBy -- //Quién creó al usuario
        FOREIGN KEY (U_CreatedBy)
        REFERENCES Users(U_ID),

	CONSTRAINT FK_Users_UpdatedBy -- //Quién actualizó al usuario
        FOREIGN KEY (U_UpdatedBy)
        REFERENCES Users(U_ID)
);
SELECT * FROM Users
TRUNCATE TABLE Users

-- Employees
CREATE TABLE Employees (
    E_ID INT IDENTITY(1,1) PRIMARY KEY,

    E_EmployeeNumber NVARCHAR(20) NOT NULL UNIQUE, -- //No. De empleado

    E_FirstName NVARCHAR(100) NOT NULL,
    E_MiddleName NVARCHAR(100) NULL,
    E_LastName NVARCHAR(100) NOT NULL,

    E_BirthDate DATE NOT NULL,
	E_Gender NVARCHAR(20) NOT NULL,
	E_Photo NVARCHAR(255) NULL,

    E_CURP CHAR(18) NOT NULL UNIQUE,
    E_RFC CHAR(13) NOT NULL UNIQUE,
    E_SSN CHAR(11) NOT NULL UNIQUE, -- //No. Seguro social

    E_Street NVARCHAR(150) NOT NULL,
    E_ExteriorNumber NVARCHAR(15) NOT NULL,
    E_InteriorNumber NVARCHAR(15) NULL,
    E_Neighborhood NVARCHAR(100) NOT NULL,
    E_City NVARCHAR(100) NOT NULL,
    E_State NVARCHAR(100) NOT NULL,
    E_PostalCode CHAR(5) NOT NULL,

    E_Email NVARCHAR(255) NULL,
    E_PhoneNumber NVARCHAR(20) NOT NULL,
    E_AlternatePhoneNumber NVARCHAR(20) NULL,

    E_DepartmentID INT NOT NULL,
    E_PositionId INT NOT NULL,

    E_BankID INT NOT NULL, -- //Datos bancarios para "depositar"
    E_AccountNumber NVARCHAR(20) NOT NULL,
    E_CLABE CHAR(18) NOT NULL,

    E_HireDate DATE NOT NULL,
    E_BaseSalary DECIMAL(12,2) NOT NULL,

    E_IsActive BIT NOT NULL DEFAULT 1,

    E_CreatedBy INT NOT NULL,
    E_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    E_UpdatedBy INT NULL,
    E_UpdatedAt DATETIME2 NULL,

    CONSTRAINT FK_Employees_Departments -- //Departamento al que pertenece
        FOREIGN KEY (E_DepartmentID)
        REFERENCES Departments(D_ID),

    CONSTRAINT FK_Employees_Positions -- //Puesto al que pertenece
        FOREIGN KEY (E_PositionID)
        REFERENCES Positions(P_ID),

    CONSTRAINT FK_Employees_Banks -- //Banco al que pertenece
        FOREIGN KEY (E_BankID)
        REFERENCES Banks(B_ID),

    CONSTRAINT FK_Employees_CreatedBy -- //Quién creó al usuario
        FOREIGN KEY (E_CreatedBy)
        REFERENCES Users(U_ID),

    CONSTRAINT FK_Employees_UpdatedBy -- //Quién actualizó al usuario
        FOREIGN KEY (E_UpdatedBy)
        REFERENCES Users(U_ID)
);

-- Banks
CREATE TABLE Banks (
    B_ID INT IDENTITY(1,1) PRIMARY KEY,

    B_Name NVARCHAR(100) NOT NULL,
    -- B_ShortName NVARCHAR(20) NULL,
    B_BankCode NVARCHAR(10) NULL, -- //Identificador del banco

    B_IsActive BIT NOT NULL DEFAULT 1,

    B_CreatedBy INT NOT NULL,
    B_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    B_UpdatedBy INT NULL,
    B_UpdatedAt DATETIME2 NULL,

    CONSTRAINT UQ_Banks_Name -- // Nombre único del banco
        UNIQUE (B_Name),

    CONSTRAINT FK_Banks_CreatedBy -- //Quién creó el banco
        FOREIGN KEY (B_CreatedBy)
        REFERENCES Users(U_ID),

    CONSTRAINT FK_Banks_UpdatedBy -- //Quién actualizó el banco
        FOREIGN KEY (B_UpdatedBy)
        REFERENCES Users(U_ID)
);

-- Departments
CREATE TABLE Departments(
    D_ID INT IDENTITY(1,1) PRIMARY KEY,

	D_Code NVARCHAR(20) NOT NULL,
    D_Name NVARCHAR(255) NOT NULL,
	P_Description NVARCHAR(255) NOT NULL,

    D_IsActive BIT NOT NULL DEFAULT 1,

    D_CreatedBy INT NOT NULL,
    D_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    D_UpdatedBy INT NULL,
    D_UpdatedAt DATETIME2 NULL

	CONSTRAINT UQ_Departments_Name -- //Nombre único para el departamento
        UNIQUE (D_Name),

    CONSTRAINT FK_Departments_CreatedBy -- //Quién creó el departamento
        FOREIGN KEY (D_CreatedBy)
        REFERENCES Users(U_ID),

    CONSTRAINT FK_Departments_UpdatedBy -- //Quién actualizó el departamento
        FOREIGN KEY (D_UpdatedBy)
        REFERENCES Users(U_ID)
);

-- Positions
CREATE TABLE Positions(
    P_ID INT IDENTITY(1,1) PRIMARY KEY,

    P_DepartmentID INT NOT NULL,

	P_Code NVARCHAR(20) NOT NULL,
    P_Name NVARCHAR(255) NOT NULL,
	P_Description NVARCHAR(255) NULL,

    P_IsActive BIT NOT NULL DEFAULT 1,

    P_CreatedBy INT NOT NULL,
    P_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    P_UpdatedBy INT NULL,
    P_UpdatedAt DATETIME2 NULL,

	CONSTRAINT UQ_Positions_Department_Name -- //Indice compuesto, pueden apuntar al mismo registro (puesto) 1:N
        UNIQUE (P_DepartmentID, P_Name),

    CONSTRAINT FK_Positions_Departments -- //Departamento al que pertenece el puesto
        FOREIGN KEY (P_DepartmentId)
        REFERENCES Departments(D_ID),

    CONSTRAINT FK_Positions_CreatedBy -- //Quién creó el puesto
        FOREIGN KEY (P_CreatedBy)
        REFERENCES Users(U_ID),

    CONSTRAINT FK_Positions_UpdatedBy -- //Quién actualizó el puesto
        FOREIGN KEY (P_UpdatedBy)
        REFERENCES Users(U_ID)
);

-- Perceptions
CREATE TABLE Perceptions(
    PERC_ID INT IDENTITY(1,1) PRIMARY KEY,

    PERC_Code NVARCHAR(20) NOT NULL,
    PERC_Name NVARCHAR(100) NOT NULL,
    PERC_Description NVARCHAR(255) NULL,

    -- PERC_IsTaxable BIT NOT NULL DEFAULT 1,

    PERC_IsSystem BIT NOT NULL DEFAULT 0, -- //Es del sistema? (0: No se borra, 1: Se puede borrar)
	PERC_IsEditable BIT NOT NULL DEFAULT 1, -- //Es editable?
	PERC_IsActive BIT NOT NULL DEFAULT 1, -- //Está activo?

    PERC_CreatedBy INT NOT NULL,
    PERC_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    PERC_UpdatedBy INT NULL,
    PERC_UpdatedAt DATETIME2 NULL,

    CONSTRAINT UQ_Perceptions_Code
        UNIQUE(PERC_Code),

    CONSTRAINT UQ_Perceptions_Name
        UNIQUE(PERC_Name),

    CONSTRAINT FK_Perceptions_CreatedBy
        FOREIGN KEY(PERC_CreatedBy)
        REFERENCES Users(U_ID),

    CONSTRAINT FK_Perceptions_UpdatedBy
        FOREIGN KEY(PERC_UpdatedBy)
        REFERENCES Users(U_ID)
);

-- Deductions
CREATE TABLE Deductions(
    DED_ID INT IDENTITY(1,1) PRIMARY KEY,

    DED_Code NVARCHAR(20) NOT NULL,
    DED_Name NVARCHAR(100) NOT NULL,
    DED_Description NVARCHAR(255) NULL,

    -- DED_IsMandatory BIT NOT NULL DEFAULT 0, -- //Es un impuesto obligatorio?

    DED_IsSystem BIT NOT NULL DEFAULT 0, -- //Es del sistema? (0: No se borra, 1: Se puede borrar)
	DED_IsEditable BIT NOT NULL DEFAULT 1, -- //Es editable?
	DED_IsActive BIT NOT NULL DEFAULT 1, -- //Está activo?

    DED_CreatedBy INT NOT NULL,
    DED_CreatedAt DATETIME2 NOT NULL DEFAULT SYSDATETIME(),

    DED_UpdatedBy INT NULL,
    DED_UpdatedAt DATETIME2 NULL,

    CONSTRAINT UQ_Deductions_Code
        UNIQUE(DED_Code),

    CONSTRAINT UQ_Deductions_Name
        UNIQUE(DED_Name),

    CONSTRAINT FK_Deductions_CreatedBy
        FOREIGN KEY(DED_CreatedBy)
        REFERENCES Users(U_ID),

    CONSTRAINT FK_Deductions_UpdatedBy
        FOREIGN KEY(DED_UpdatedBy)
        REFERENCES Users(U_ID)
);