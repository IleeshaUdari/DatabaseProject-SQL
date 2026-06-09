CREATE TABLE PRODUCTION
(
   Pro_ID         NCHAR(10) NOT NULL,
   ClientID       NCHAR(10) NULL,
   Title          NVARCHAR(50) NULL,
   StartDate      DATE NULL, 
   EndDate        DATE NULL,
   Description    NVARCHAR(50) NULL, 
   PRIMARY KEY CLUSTERED (Pro_ID ASC),
   CONSTRAINT FK1 FOREIGN KEY (ClientID) REFERENCES CLIENT(ClientID) 
);
