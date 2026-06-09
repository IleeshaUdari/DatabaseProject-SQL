CREATE TABLE CLIENT
(
   ClientID       NCHAR     (10) NOT NULL,
   ClientName     NVARCHAR  (50) NULL,
   ContactPerson  NVARCHAR  (50) NULL,
   ContactEmail   NVARCHAR  (50) NULL,
   Address        NVARCHAR  (50) NULL,
   PRIMARY KEY CLUSTERED (ClientID ASC)
);