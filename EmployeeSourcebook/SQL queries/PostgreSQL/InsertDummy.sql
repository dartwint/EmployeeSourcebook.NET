-- Insert Positions
INSERT INTO "Positions" ("Name") VALUES
('Software Engineer'),
('QA Engineer'),
('Project Manager'),
('Team Lead'),
('HR Specialist'),
('Business Analyst');

-- Insert Departments
INSERT INTO "Departments" ("Name") VALUES
('Engineering'),
('Quality Assurance'),
('Human Resources');

-- Insert EmployeeRoles
INSERT INTO "EmployeeRoles" ("Name") VALUES
('employee'),
('manager'),
('department_manager');

-- Insert Addresses
INSERT INTO "Addresses" ("PostalAddress") VALUES
('123 Main St'), ('456 Pine Ave'), ('789 Oak Blvd'),
('111 Elm St'), ('222 Maple Ave'), ('333 Cedar Rd'),
('444 Birch St'), ('555 Spruce Ln'), ('666 Walnut Blvd'),
('777 Poplar Ct'), ('888 Sycamore Dr'), ('999 Redwood Way'),
('101 Ash Dr'), ('202 Chestnut Rd'), ('303 Willow Ln');

-- Insert Employees
INSERT INTO "Employees" ("Name", "Surname", "Patronymic", "Phone", "PositionId", "DepartmentId", "AddressId", "EmployeeRoleId", "CreatedAt") VALUES
-- Department Managers (3)
('Ivan', 'Petrov', 'Sergeevich', '111-111-1111', 4, 1, 1, 3, NOW()),
('Anna', 'Ivanova', 'Vladimirovna', '222-222-2222', 4, 2, 2, 3, NOW()),
('Oleg', 'Sidorov', 'Maksimovich', '333-333-3333', 4, 3, 3, 3, NOW()),
-- Managers (4)
('Nina', 'Kuznetsova', 'Alekseevna', '444-444-4444', 3, 1, 4, 2, NOW()),
('Dmitry', 'Fedorov', 'Pavlovich', '555-555-5555', 3, 2, 5, 2, NOW()),
('Maria', 'Smirnova', 'Ivanovna', '666-666-6666', 3, 1, 6, 2, NOW()),
('Sergey', 'Morozov', 'Yurievich', '777-777-7777', 3, 3, 7, 2, NOW()),
-- Employees (8)
('Olga', 'Lebedeva', 'Andreevna', '888-888-8888', 1, 1, 8, 1, NOW()),
('Andrey', 'Nikolaev', 'Igorevich', '999-999-9999', 1, 1, 9, 1, NOW()),
('Elena', 'Voronina', 'Evgenievna', '101-010-1010', 2, 2, 10, 1, NOW()),
('Roman', 'Pavlov', 'Grigorievich', '202-020-2020', 2, 2, 11, 1, NOW()),
('Vera', 'Karpova', 'Mikhailovna', '303-030-3030', 5, 3, 12, 1, NOW()),
('Yulia', 'Guseva', 'Dmitrievna', '404-040-4040', 6, 3, 13, 1, NOW()),
('Denis', 'Kozlov', 'Antonovich', '505-050-5050', 1, 1, 14, 1, NOW()),
('Irina', 'Medvedeva', 'Nikolayevna', '606-060-6060', 2, 2, 15, 1, NOW());

-- Insert DepartmentHeads (IDs 1,2,3 are department managers)
INSERT INTO "DepartmentHeads" ("DepartmentId", "EmployeeId") VALUES
(1, 1),
(2, 2),
(3, 3);

-- Insert EmployeesHierarchy (only positive depths: subordinates)
-- Manager-subordinate relationships
INSERT INTO "EmployeesHierarchy" ("AncestorId", "DescendantId", "Depth") VALUES
(1, 4, 1), -- Ivan -> Nina
(1, 7, 1), -- Ivan -> Maria
(4, 8, 1), -- Nina -> Olga
(4, 9, 1), -- Nina -> Andrey
(7, 14, 1), -- Maria -> Denis

(2, 5, 1), -- Anna -> Dmitry
(5, 10, 1), -- Dmitry -> Elena
(5, 11, 1), -- Dmitry -> Roman
(2, 15, 1), -- Anna -> Irina

(3, 6, 1), -- Oleg -> Sergey
(6, 12, 1), -- Sergey -> Vera
(6, 13, 1); -- Sergey -> Yulia