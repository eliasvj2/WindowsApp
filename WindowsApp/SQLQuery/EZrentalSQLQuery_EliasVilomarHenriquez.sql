-- Create database

CREATE DATABASE EZ_rental_DB;
--select database
Use EzrentalDB;

--create DriverLicense Table
CREATE TABLE DriverLicense
(
	DriverLicenseNumber			VARCHAR(25)			PRIMARY KEY,
	DriverLicenseExpDate		DATE				NOT NULL,
	DriverLicenseState			CHAR(2)				NOT NULL
);

--create CustomerUserAccount Table
CREATE TABLE CustomerUserAccount
(
	CustomerUserAccountID		UNIQUEIDENTIFIER	PRIMARY KEY,
	Username					VARCHAR(50)			NOT NULL,
	Password					VARCHAR(30)			NOT NULL,
	Email						VARCHAR(50)			UNIQUE
);

--Create Customer Table
CREATE TABLE Customer
(
	CustomerID					INT Identity(111111,1)	PRIMARY KEY,
	FirstName					VARCHAR(50)				NOT NULL,
	LastName					VARCHAR(50)				NOT NULL,
	BirthDate					DATE					NOT NULL,
	AddressLine1				VARCHAR(50)				NOT NULL,
	AddressLine2				VARCHAR(50)				NULL,
	City						VARCHAR(30)				NOT NULL,
	StateCode					CHAR(2)					NOT NULL,
	ZipCode						VARCHAR(10)				NOT NULL,
	Country						VARCHAR(100)			NOT NULL,
	Phone						VARCHAR(20)				NOT NULL,
	Email						VARCHAR(100)			UNIQUE,
	DriverLicenseNumber			VARCHAR(25)				UNIQUE NOT NULL,
	CustomerUserAccountID		UNIQUEIDENTIFIER		NULL,
	CustomerType				BIT						NOT NULL,

	CONSTRAINT fk_DriverLicense_Customer
	FOREIGN KEY(DriverLicenseNumber)
	REFERENCES DriverLicense (DriverLicenseNumber)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_CustomerUserAccount_Customer
	FOREIGN KEY(CustomerUserAccountID)
	REFERENCES CustomerUserAccount (CustomerUserAccountID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Create CreditCardMerchant table
CREATE TABLE CreditCardMerchant
(
	MerchantCode				TINYINT	CHECK(MerchantCode between 1 and 15)	PRIMARY KEY,
	MerchantName				VARCHAR(26)											NOT NULL
);

--create creditcard table
CREATE TABLE CreditCard
(
	CreditCardNumber			CHAR(16)			PRIMARY KEY,
	CreditCardOwnerName			VARCHAR(13)			NOT NULL,
	CreditCardIssuingCompany	VARCHAR(15)			NOT NULL,
	MerchantCode				TINYINT CHECK(MerchantCode between 1 and 15)	NULL,
	ExpDate						DATE				NOT NULL,
	AddressLine1				VARCHAR(50)			NOT NULL,
	AddressLine2				VARCHAR(50)			NULL,
	City						VARCHAR(30)			NOT NULL,
	StateCode					CHAR(2)				NOT NULL,
	ZipCode						VARCHAR(10)			NOT NULL,
	Country						VARCHAR(100)		NOT NULL,
	CreditCardLimit				INT					NOT NULL,
	CreditCardBalance			INT					NOT NULL,
	ActivationStatus			BIT					NOT NULL,

	CONSTRAINT fk_CreditCardMerchant_CreditCard
	FOREIGN KEY (MerchantCode)
	REFERENCES CreditCardMerchant(MerchantCode)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Create table Customer_CreditCard
CREATE TABLE Customer_CreditCard
(
	CreditCardNumber			CHAR(16)			NOT NULL,
	CustomerID					INT					NOT NULL,

	CONSTRAINT pk_Customer_CreditCard
	PRIMARY KEY(CreditCardNumber, CustomerID),

	CONSTRAINT fk_Customer_CC_CustomerID
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_Customer_CC_CreditCardNumber
	FOREIGN KEY (CreditCardNumber)
	REFERENCES CreditCard(CreditCardNumber)
	ON DELETE CASCADE ON UPDATE CASCADE,
);

--create Discount table
CREATE TABLE Discount
(
	DiscountID				INT			PRIMARY KEY,
	DiscountCode			CHAR(10)	UNIQUE NOT NULL,
	DiscountCodeDesc		VARCHAR(150)	NOT NULL
);

--Create EZpluz table
CREATE TABLE EZplus
(
	EZPlusID				INT IDENTITY	PRIMARY KEY,
	EZPlusRewardsCode		CHAR(13)		UNIQUE NULL,
	EZPlusRewardsEarnedPoints	INT			NULL
);

--Create RetailCustomer table
CREATE TABLE RetailCustomer
(
	CustomerID				INT				PRIMARY KEY,
	DiscountID				INT				NULL,
	EZPlusID				INT				NULL,

	CONSTRAINT fk_CustomerID
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_Discount_RetailCustomer
	FOREIGN KEY (DiscountID)
	REFERENCES Discount (DiscountID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_EZPlus_RetailCustomer
	FOREIGN KEY (EZPlusID)
	REFERENCES EZPlus(EZPlusID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

--Create company table
CREATE TABLE Company
(
	CompanyID				SMALLINT CHECK(CompanyID between 1 and 20000) PRIMARY KEY,
	CompanyName				VARCHAR(50)		UNIQUE NOT NULL,
	AddressLine1			VARCHAR(50)		NOT NULL,
	AddressLine2			VARCHAR(50)		NULL,
	City					VARCHAR(30)		NOT NULL,
	StateCode				CHAR(2)			NOT NULL,
	ZipCode					VARCHAR(10)		NOT NULL,
	Country					VARCHAR(100)	NOT NULL,
	CompanyRepName			VARCHAR(50)		NOT NULL,
	ContactPhone			VARCHAR(20)		NOT NULL,
	ContactEmail			VARCHAR(100)	NOT NULL,
	CorporateDiscountPercentage Decimal(3,2) NOT NULL
);

--create CorporateCustomer table
CREATE TABLE CorporateCustomer
(
	CustomerID				INT			PRIMARY KEY,
	CompanyID				SMALLINT CHECK(CompanyID between 1 and 20000) NOT NULL,

	CONSTRAINT fk_CustomerID_st_CorporateCustomer
	FOREIGN KEY (CustomerID)
	REFERENCES Customer(CustomerID)
	ON DELETE CASCADE ON UPDATE CASCADE,

	CONSTRAINT fk_Company_CorporateCustomer
	FOREIGN KEY (CompanyID)
	REFERENCES Company(CompanyID)
	ON DELETE CASCADE ON UPDATE CASCADE
);

-- Create US State
CREATE TABLE USState
(
	StateID			TINYINT		CHECK(StateID between 1 and 60) PRIMARY KEY,
	StateCode2Char	CHAR(60)	UNIQUE NOT NULL,
	StateName		VARCHAR(80)	NOT NULL
);

--Create Country table
CREATE TABLE Country
(
	CountryID		TINYINT		CHECK(CountryID between 1 and 200)	PRIMARY KEY,
	CountryCode2Char	CHAR(2)	UNIQUE NOT NULL,
	CountryCode3Char	CHAR(3)	UNIQUE NOT NULL,
	CountryName			VARCHAR(100)	NOT NULL
);