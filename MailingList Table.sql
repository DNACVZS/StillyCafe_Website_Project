USE StillyCafeDB;
GO

IF EXISTS (SELECT 1 FROM sys.tables WHERE name = 'MailingList')
    DROP TABLE MailingList;

CREATE TABLE MailingList (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
	ReferralSource NVARCHAR(300),
    SignupDate DATETIME DEFAULT GETDATE()
);

INSERT INTO MailingList (Name, Email, ReferralSource)
VALUES ('Dana Cava', 'dana@example.com', 'Instagram');

SELECT * FROM MailingList;