-- Drop tables if they exist (order determined by FK constraints)
DROP TABLE IF EXISTS Animal;
DROP TABLE IF EXISTS Reservor;


-- Create reservor table
CREATE TABLE Reservor
(
	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Name VARCHAR(100) NOT NULL,
	ReservedAt DATE NOT NULL
);


-- Create animal table
CREATE TABLE Animal
(
	Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
	Type VARCHAR(100) NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Gender VARCHAR(6) NOT NULL,
	BadHabits VARCHAR(100),
	LastWalk DATE,
	Reservor INT NULL,
    FOREIGN KEY (Reservor) REFERENCES Reservor (Id),
    CHECK (Gender IN ('Male', 'Female')),
    CHECK ((Type = 'Cat' AND BadHabits IS NOT NULL) OR
		       (Type = 'Dog' AND LastWalk IS NOT NULL))
);

