Create DataBase GestionEmpleados

Create table Persona(
IdPersona INT IDENTITY (1,1) NOT NULL,
Nombre NVARCHAR (50) NOT NULL,
Apellido NVARCHAR (50) NOT NULL,
Estado NVARCHAR (20) NOT NULL,
PRIMARY KEY (IdPersona),
);

Create table Empleado(
IdEmpleado INT IDENTITY (1,1) NOT NULL,
IdPersona INT NOT NULL,
Puesto NVARCHAR NOT NULL,
Salario INT NOT NULL,
FechaContratacion DATETIME NOT NULL,
PRIMARY KEY (IdEmpleado),
FOREIGN KEY (IdPersona) REFERENCES Persona (IdPersona)
);

Select * From Empleado;