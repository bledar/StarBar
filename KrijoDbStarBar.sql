create database StarBar
Data Source=BLEDI-PC;Initial Catalog=StarBar;User ID=AdminStarBar;Password=StarBar123


CREATE TABLE Perdorues
(
ID int NOT NULL IDENTITY(1,1),
Emri varchar(255) not null,
Kodi varchar(255) not null,
Niveli int not null,
PRIMARY KEY (ID)
)

INSERT INTO Perdorues(Emri , Kodi,Niveli)
		VALUES('admin' , '123',1)
		
		
SELECT * FROM Perdorues WHERE Emri like 'Administrator' AND Kodi like '123456';

GRANT SELECT ON Perdorues TO [AdminStarBar]