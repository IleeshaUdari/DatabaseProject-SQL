CREATE TABLE STAFF_TYPE
(
   Staff_TypeID     NCHAR     (10) NOT NULL,
   Staff_TypeName   NVARCHAR  (50) NULL,
   Description      NVARCHAR  (50) NULL,
   PRIMARY KEY CLUSTERED (Staff_TypeID  ASC),
);