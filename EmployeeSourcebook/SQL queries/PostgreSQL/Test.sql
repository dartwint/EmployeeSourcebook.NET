CREATE TABLE IF NOT EXISTS "Employees" (
	"Id" serial NOT NULL UNIQUE,
	"Name" varchar(255) NOT NULL,
	"Surname" varchar(255) NOT NULL,
	"Patronymic" varchar(255) NOT NULL,
	"Phone" varchar(255) NOT NULL,
	"PositionId" bigint NOT NULL,
	"DepartmentId" bigint NOT NULL,
	"AddressId" bigint NOT NULL,
	"EmployeeRoleId" bigint NOT NULL,
	"CreatedAt" time without time zone NOT NULL,
	PRIMARY KEY ("Id")
);

CREATE TABLE IF NOT EXISTS "Positions" (
	"Id" serial NOT NULL UNIQUE,
	"Name" varchar(255) NOT NULL,
	PRIMARY KEY ("Id")
);

CREATE TABLE IF NOT EXISTS "Addresses" (
	"Id" serial NOT NULL UNIQUE,
	"PostalAddress" varchar(255) NOT NULL,
	PRIMARY KEY ("Id")
);

CREATE TABLE IF NOT EXISTS "Departments" (
	"Id" serial NOT NULL UNIQUE,
	"Name" varchar(255) NOT NULL,
	PRIMARY KEY ("Id")
);

CREATE TABLE IF NOT EXISTS "EmployeesHierarchy" (
	"AncestorId" bigint NOT NULL,
	"DescendantId" bigint NOT NULL,
	"Depth" bigint NOT NULL,
	PRIMARY KEY ("AncestorId", "DescendantId")
);

CREATE TABLE IF NOT EXISTS "EmployeeRoles" (
	"Id" serial NOT NULL UNIQUE,
	"Name" varchar(255) NOT NULL,
	PRIMARY KEY ("Id")
);

CREATE TABLE IF NOT EXISTS "DepartmentHeads" (
	"DepartmentId" bigint NOT NULL,
	"EmployeeId" bigint NOT NULL UNIQUE,
	PRIMARY KEY ("DepartmentId")
);

ALTER TABLE "Employees" ADD CONSTRAINT "Employees_fk5" FOREIGN KEY ("PositionId") REFERENCES "Positions"("Id");

ALTER TABLE "Employees" ADD CONSTRAINT "Employees_fk6" FOREIGN KEY ("DepartmentId") REFERENCES "Departments"("Id");

ALTER TABLE "Employees" ADD CONSTRAINT "Employees_fk7" FOREIGN KEY ("AddressId") REFERENCES "Addresses"("Id");

ALTER TABLE "Employees" ADD CONSTRAINT "Employees_fk8" FOREIGN KEY ("EmployeeRoleId") REFERENCES "EmployeeRoles"("Id");



ALTER TABLE "EmployeesHierarchy" ADD CONSTRAINT "EmployeesHierarchy_fk0" FOREIGN KEY ("AncestorId") REFERENCES "Employees"("Id");

ALTER TABLE "EmployeesHierarchy" ADD CONSTRAINT "EmployeesHierarchy_fk1" FOREIGN KEY ("DescendantId") REFERENCES "Employees"("Id");

ALTER TABLE "DepartmentHeads" ADD CONSTRAINT "DepartmentHeads_fk0" FOREIGN KEY ("DepartmentId") REFERENCES "Departments"("Id");

ALTER TABLE "DepartmentHeads" ADD CONSTRAINT "DepartmentHeads_fk1" FOREIGN KEY ("EmployeeId") REFERENCES "Employees"("Id");