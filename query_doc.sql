CREATE TABLE Logins (
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    CONSTRAINT PK_Logins PRIMARY KEY (username)
);

INSERT INTO Logins (username,password) VALUES
('Admin','Skills@123');

CREATE TABLE Registration (
    regNo INT NOT Null,
    firstName VARCHAR(50) NOT NULL,
    lastName VARCHAR(50) NOT NULL,
    dateOfBirth DATETIME NOT NULL,
    gender VARCHAR(50) NOT NULL,
    address VARCHAR(50),
    email VARCHAR(50),
    mobilePhone INT,
    homePhone INT,
    parentName VARCHAR(50),
    nic VARCHAR(50),
    contactNo INT,
	CONSTRAINT PK_reg PRIMARY KEY (regNo)
);



