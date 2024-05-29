---------------------------------------------------------------------------
-- Checks if the database exists, if yes drops it
---------------------------------------------------------------------------
BEGIN
	IF EXISTS (SELECT * FROM master.sys.databases WHERE name = 'AccentureChallenge')
		BEGIN
			ALTER DATABASE AccentureChallenge SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
			USE master
			DROP DATABASE AccentureChallenge
		END
END
---------------------------------------------------------------------------
-- Creates the database
---------------------------------------------------------------------------
CREATE DATABASE AccentureChallenge
GO
USE AccentureChallenge
GO
---------------------------------------------------------------------------
-- Creates the tables
---------------------------------------------------------------------------
CREATE TABLE CUSTOMERS ( 
	ID INT IDENTITY(1,1) NOT NULL,
	FULL_NAME VARCHAR(50) NOT NULL,
	EMAIL VARCHAR(50) NOT NULL,
	CREATED_DATE DATETIME NOT NULL DEFAULT (GETDATE()),

	CONSTRAINT PK_CUSTOMERS PRIMARY KEY CLUSTERED (ID)
)

CREATE TABLE ORDERS ( 
	ID INT IDENTITY(1,1) NOT NULL,
	CUSTOMER_ID INT NOT NULL,
	ORDER_DATE DATETIME NOT NULL DEFAULT (GETDATE()),
	TOTAL_AMOUNT DECIMAL(10,2) NOT NULL DEFAULT (0),

	CONSTRAINT PK_ORDERS PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT FK_ORDER_CUSTOMER FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMERS (ID),
)

CREATE TABLE PRODUCTS ( 
	ID INT IDENTITY(1,1) NOT NULL,
	FULL_NAME VARCHAR(50) NOT NULL,
	CATEGORY VARCHAR(50) NOT NULL,

	CONSTRAINT PK_PRODUCTS PRIMARY KEY CLUSTERED (ID)
)

CREATE TABLE ORDER_ITEMS ( 
	ID INT IDENTITY(1,1) NOT NULL,
	ORDER_ID INT NOT NULL,
	PRODUCT_ID INT NOT NULL,
	QUANTITY INT NOT NULL,
	PRICE DECIMAL(10,2) NOT NULL,

	CONSTRAINT PK_ORDER_ITEMS PRIMARY KEY CLUSTERED (ID),
	CONSTRAINT FK_ORDER_ITEMS_ORDERS FOREIGN KEY (ORDER_ID) REFERENCES ORDERS (ID),
	CONSTRAINT FK_ORDER_ITEMS_PRODUCTS FOREIGN KEY (PRODUCT_ID) REFERENCES PRODUCTS (ID),
)