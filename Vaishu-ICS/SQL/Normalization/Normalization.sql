CREATE TABLE Client (clientNo VARCHAR(10) PRIMARY KEY,Cname VARCHAR(50))
CREATE TABLE Property (propertyNo VARCHAR(10) PRIMARY KEY,paddress VARCHAR(100))
CREATE TABLE Owner (ownerno VARCHAR(10) PRIMARY KEY,Oname VARCHAR(50))
CREATE TABLE Rent (clientNo VARCHAR(10),propertyNo VARCHAR(10),rentstart DATE,rentfinish DATE,rent INT, ownerno VARCHAR(10),
    FOREIGN KEY (clientNo) REFERENCES Client(clientNo),
    FOREIGN KEY (propertyNo) REFERENCES Property(propertyNo),
    FOREIGN KEY (ownerno) REFERENCES Owner(ownerno))

INSERT INTO Client (clientNo, Cname)VALUES ('CR76', 'Johnkay'),('CR56', 'Alinestewart')
INSERT INTO Property (propertyNo, paddress)VALUES ('PG4', '6lawrence St.Glasgow'),('PG16', '5Novar Dr,Glasgow'),('PG36', '2Manor Rd, Glasgow')
INSERT INTO Owner (ownerno, Oname)VALUES('C040', 'TinaMurphy'),('C093', 'TonyShaw')
INSERT INTO Rent (clientNo, propertyNo, rentstart, rentfinish, rent, ownerno)VALUES('CR76', 'PG4', '2000-07-01', '2001-08-31', 350, 'C040'),
('CR76', 'PG16', '2002-09-01', '2002-09-01', 450, 'C093'),('CR56', 'PG4', '1999-09-01', '2000-06-10', 350, 'C040'),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370, 'C093'),('CR56', 'PG16', '2002-11-01', '2003-08-01', 450, 'C093')

SELECT * FROM Client
SELECT * FROM Property
SELECT * FROM Owner
SELECT * FROM Rent