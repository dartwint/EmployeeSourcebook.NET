CREATE TABLE IF NOT EXISTS `Employees` (
	`Id` integer primary key NOT NULL UNIQUE,
	`Name` TEXT NOT NULL,
	`Surname` TEXT NOT NULL,
	`Patronymic` TEXT NOT NULL,
	`Phone` TEXT NOT NULL,
	`PositionId` INTEGER NOT NULL,
	`DepartmentId` INTEGER NOT NULL,
	`AddressId` INTEGER NOT NULL,
	`EmployeeRoleId` INTEGER NOT NULL,
	`CreatedAt` TEXT NOT NULL,
FOREIGN KEY(`PositionId`) REFERENCES `Positions`(`Id`),
FOREIGN KEY(`DepartmentId`) REFERENCES `Departments`(`Id`),
FOREIGN KEY(`AddressId`) REFERENCES `Addresses`(`Id`),
FOREIGN KEY(`EmployeeRoleId`) REFERENCES `EmployeeRoles`(`Id`)
);
CREATE TABLE IF NOT EXISTS `Positions` (
	`Id` integer primary key NOT NULL UNIQUE,
	`Name` TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS `Addresses` (
	`Id` integer primary key NOT NULL UNIQUE,
	`PostalAddress` TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS `Departments` (
	`Id` integer primary key NOT NULL UNIQUE,
	`Name` TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS `EmployeesHierarchy` (
	`AncestorId` INTEGER NOT NULL,
	`DescendantId` INTEGER NOT NULL,
	`Depth` INTEGER NOT NULL,
FOREIGN KEY(`AncestorId`) REFERENCES `Employees`(`Id`),
FOREIGN KEY(`DescendantId`) REFERENCES `Employees`(`Id`)
);
CREATE TABLE IF NOT EXISTS `EmployeeRoles` (
	`Id` integer primary key NOT NULL UNIQUE,
	`Name` TEXT NOT NULL
);
CREATE TABLE IF NOT EXISTS `DepartmentHeads` (
	`DepartmentId` INTEGER NOT NULL,
	`EmployeeId` INTEGER NOT NULL UNIQUE,
FOREIGN KEY(`DepartmentId`) REFERENCES `Departments`(`Id`),
FOREIGN KEY(`EmployeeId`) REFERENCES `Employees`(`Id`)
);