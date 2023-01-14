--select statement
SELECT * FROM DriverLicense;

--Insert statement for DriverLicense
INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-514-778-616-977','2023-12-05','AR');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-985-778-325-647','2026-05-05','NY');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-462-778-616-977','2033-09-04','OR');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-362-123-659-465','2030-02-01','PA');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-146-156-789-468','2020-12-02','AZ');

----
INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-523-745-611-842','2023-12-05','AR');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-367-554-345-647','2021-05-05','NY');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-637-873-147-573','2033-09-04','OR');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-364-133-159-765','2032-02-01','PA');

INSERT INTO DriverLicense(DriverLicenseNumber, DriverLicenseExpDate, DriverLicenseState)
VALUES ('S-156-732-768-468','2022-12-04','AZ');


--select statement
SELECT * FROM CustomerUserAccount;

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Joe Doe','jhf384a/2','JoeDoe@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Mary jane','agsg323','MaryJane@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Raul gonzalez','09safl','raulgonzalez@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('patin3','jhf3asd3','patin3@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('luis segura','jgfdg44a/2','luissegura@hotmail.com');

----

INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Liam32','jh2384a/2','liamO@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Noah34','a456f','Noah34@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('James1#','034dfg','James1#@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Henrys@1','jh34dfg','hery31@hotmail.com');

--Insert statement for CustomerUserAccount
INSERT INTO CustomerUserAccount( Username, Password, Email)
VALUES ('Theodore96','jgghjs4','Henry32@hotmail.com');

--select statement for customer
SELECT * FROM  Customer;

--insert statement for customer
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('luis','segura','1960-05-03','123 jay Street ave','','Bronx','NY','10563','USA',
'8092365663','luissegura@hotmail.com','S-514-778-616-977',
'AB5AC514-C6FE-4868-8E3B-D7DD483E9E93','R');

--insert statement for customer
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('patin','alan','1963-03-03','123 abaco Street ave','','Mahattan','NY','10263','USA',
'8092365663','patin3@hotmail.com','S-985-778-325-647',
'D422A012-F862-4E42-8128-BC47CFE71DEE','R');

--insert statement for customer
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('raul','gonzalez','1957-07-03','123 abbey Street ave','','Brooklyn','NY','11163','USA',
'8092365663','raulgonzalez@hotmail.com','S-462-778-616-977',
'A09A53C6-DEAF-44FC-8046-C42C5797C384','C');

--insert statement for customer
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('Mary','jane','1990-05-03','123 aber Street ave','','Queens','NY','12263','USA',
'8092365663','maryjane@hotmail.com','S-362-123-659-465',
'5C0B66B2-25EB-46E4-AB2F-CADCAF167148','R');

--insert statement for customer
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('Joe','doe','1993-05-03','123 washitong Street ave','','Bronx','NY','10563','USA',
'8092365663','joedoe@hotmail.com','S-123-456-789-468',
'AB5AC514-C6FE-4868-8E3B-D7DD483E9E93','C');

-----------------
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('Barry','Allen','1990-10-08','456 harris court Street ave','','Brooklyn','NY','10261','USA',
'8042365162','barryallen@hotmail.com','S-523-745-611-842',
'A09A53C6-DEAF-44FC-8046-C42C5797C384','R');

INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('Noah','White','1999-10-08','Moyer Loop Street ave','','Albany','NY','10261','USA',
'8042365162','NoahWhite@hotmail.com','S-156-732-768-468',
'7A4AA234-400E-4E6C-844C-C9DDFD9E06C7','R');
---------------
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('William','Park','1970-10-08','Pueblo place Street ave','','Los Angeles','CA','10203','USA',
'8042365162','williampark@hotmail.com','S-364-133-159-765',
'5C0B66B2-25EB-46E4-AB2F-CADCAF167148','C');
---------
INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('emma','Watson','1960-10-08','Quali Street ave','','San diego','CA','11161','USA',
'8042365162','emmawatson@hotmail.com','S-637-873-147-573',
'AB5AC514-C6FE-4868-8E3B-D7DD483E9E93','C');
-----------

INSERT INTO Customer( FirstName, LastName, BirthDate, AddressLine1, AddressLine2, City, StateCode, 
ZipCode, Country, Phone, Email, DriverLicenseNumber, CustomerUserAccountID,Customertype)
VALUES ('Tom','Cruise','1965-10-02','Radford court Street ave','','Miami','FL','13241','USA',
'8042365162','tomcruise@hotmail.com','S-367-554-345-647',
'3DFFB860-5563-4344-8B53-F62BA3BBC473','C');



--select credit card merchant table
SELECT * FROM CreditCardMerchant;

--insert statement for credit card merchant
INSERT INTO CreditCardMerchant( MerchantCode, MerchantName)
VALUES (2,'Cataron');

--insert statement for credit card merchant
INSERT INTO CreditCardMerchant( MerchantCode, MerchantName)
VALUES (5,'Kanan');

--insert statement for credit card merchant
INSERT INTO CreditCardMerchant( MerchantCode, MerchantName)
VALUES (1,'Mercer');

--insert statement for credit card merchant
INSERT INTO CreditCardMerchant( MerchantCode, MerchantName)
VALUES (3,'Draper');

--insert statement for credit card merchant
INSERT INTO CreditCardMerchant( MerchantCode, MerchantName)
VALUES (6,'Lionel');

--select statement for credit card
SELECT * FROM CreditCard;

--insert statement for credit card 
INSERT INTO CreditCard( CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,MerchantCode,ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode,
Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES ('4111111111111111','lui segura','Visa', 1,'2022-12-12','123 abytt street','','Mahattan','AZ','15698','USA',120000,5000,1);

--insert statement for credit card 
INSERT INTO CreditCard( CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,MerchantCode,ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode,
Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES ('5111111111111111','cataron','Visa', 2,'2022-12-12','123 alcade street','','los angeles','ME','15698','USA',520000,10000,0);

--insert statement for credit card 
INSERT INTO CreditCard( CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,MerchantCode,ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode,
Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES ('6111111111111111','Kanan','MasterCard', 5,'2025-12-12','123 fortaleza street','','cotton','MD','15698','USA',120000,15000,1);

--insert statement for credit card 
INSERT INTO CreditCard( CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,MerchantCode,ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode,
Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES ('7111111111111111','Draper','MasterCard', 1,'2024-05-12','123 foxfield street','','Mahattan','OH','15698','USA',780000,35000,0);

--insert statement for credit card 
INSERT INTO CreditCard( CreditCardNumber, CreditCardOwnerName, CreditCardIssuingCompany,MerchantCode,ExpDate, AddressLine1, AddressLine2, City, StateCode, ZipCode,
Country, CreditCardLimit, CreditCardBalance,ActivationStatus)
VALUES ('8111111111111111','Lioner','Visa', 1,'2022-06-22','123 abytt street','','pupil','AZ','15698','USA',120000,5000,1);

--select customer credit card
SELECT * FROM Customer_CreditCard;

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('4111111111111111',111115);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('4111111111111111',111117);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('4111111111111111',111118);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('4111111111111111',111119);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('4111111111111111',111120);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('5111111111111111',111120);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('6111111111111111',111120);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('7111111111111111',111120);

--insert statement for customer credit card
INSERT INTO Customer_CreditCard(CreditCardNumber, CustomerID)
VALUES ('8111111111111111',111120);

--select discount table
SELECT * FROM Discount;

--insert statements for Discount
INSERT INTO Discount(DiscountCode, DiscountCodeDesc)
VALUES ('AAA9970054','AAA Membership Discount - 25% off base rate plus 10% donated for breast cancer research');

--insert statements for Discount
INSERT INTO Discount(DiscountCode, DiscountCodeDesc)
VALUES ('GOV8756921','Government Employee Discount- 30% off base rate');

--insert statements for Discount
INSERT INTO Discount(DiscountCode, DiscountCodeDesc)
VALUES ('STA3415632','State Employee Discount for 25% off base rate');

--insert statements for Discount
INSERT INTO Discount(DiscountCode, DiscountCodeDesc)
VALUES ('VET2055179','Veteran Discount 35% off base rate Plus 10% donation to veterans family fund.');

--insert statements for Discount
INSERT INTO Discount(DiscountCode, DiscountCodeDesc)
VALUES ('VET2055189','Veteran Discount 35% off base rate ');

--select ezplus table
SELECT * FROM EZplus;

--insert statements for EZplus
INSERT INTO EZplus(EZPlusRewardsCode, EZPlusRewardsEarnedPoints)
VALUES ('EZP9009864637', 10000);

--insert statements for EZplus
INSERT INTO EZplus(EZPlusRewardsCode, EZPlusRewardsEarnedPoints)
VALUES ('EZP1000864637', 500);

--insert statements for EZplus
INSERT INTO EZplus(EZPlusRewardsCode, EZPlusRewardsEarnedPoints)
VALUES ('EZP6493238865', 15900);

--insert statements for EZplus
INSERT INTO EZplus(EZPlusRewardsCode, EZPlusRewardsEarnedPoints)
VALUES ('EZP2005135627', 23000);

--insert statements for EZplus
INSERT INTO EZplus(EZPlusRewardsCode, EZPlusRewardsEarnedPoints)
VALUES ('EZP500069845', 90000);

--select company table
SELECT * FROM Company;

--insert statements for company table
INSERT INTO Company(CompanyID, CompanyName, AddressLine1, Addressline2, City, StateCode,
ZipCode, Country, CompanyRepName, ContactPhone,ContactEmail,CorporateDiscountPercentage)
VALUES (1,'IBM', '590 Madison Ave','' ,'Mahattan','NY','10022','USA','john smith','800-426-0616','IBMemail@outlook.com',0.3);

--insert statements for company table
INSERT INTO Company(CompanyID, CompanyName, AddressLine1, Addressline2, City, StateCode,
ZipCode, Country, CompanyRepName, ContactPhone,ContactEmail,CorporateDiscountPercentage)
VALUES (2,'Facebook', '1 Hacker Way','' ,'Menlo park','CA','94025','USA','vera Gomez','826-456-8975','Facebookemail@outlook.com',0.1);

--insert statements for company table
INSERT INTO Company(CompanyID, CompanyName, AddressLine1, Addressline2, City, StateCode,
ZipCode, Country, CompanyRepName, ContactPhone,ContactEmail,CorporateDiscountPercentage)
VALUES (3,'Apple', '1 infinite loop','' ,'Cupertino','CA','95014','USA','lucy james','900-526-0816','Appleemail@outlook.com',0.9);

--insert statements for company table
INSERT INTO Company(CompanyID, CompanyName, AddressLine1, Addressline2, City, StateCode,
ZipCode, Country, CompanyRepName, ContactPhone,ContactEmail,CorporateDiscountPercentage)
VALUES (4,'Microsoft', 'One Microsoft Way','' ,'Redmond','WA','13082','USA','Juan hernandez','920-726-0619','Microsoftemail@outlook.com',0.3);

--insert statements for company table
INSERT INTO Company(CompanyID, CompanyName, AddressLine1, Addressline2, City, StateCode,
ZipCode, Country, CompanyRepName, ContactPhone,ContactEmail,CorporateDiscountPercentage)
VALUES (5,'Netflix', '100 Winchester','' ,'Circle Los Gatos','CA','95032','USA','Pedro henriquez','801-422-0415','Netflixemail@outlook.com',0.5);

--select retailcustomer table
SELECT * FROM RetailCustomer;

--insert statements for retail customer table
INSERT INTO RetailCustomer(CustomerID, DiscountID, EZPlusID)
VALUES (111115,1,1);

--insert statements for retail customer table
INSERT INTO RetailCustomer(CustomerID, DiscountID, EZPlusID)
VALUES (111117,3,2);

--insert statements for retail customer table
INSERT INTO RetailCustomer(CustomerID, DiscountID, EZPlusID)
VALUES (111119,4,3);

--insert statements for retail customer table
INSERT INTO RetailCustomer(CustomerID, DiscountID, EZPlusID)
VALUES (111122,5,4);

--insert statements for retail customer table
INSERT INTO RetailCustomer(CustomerID, DiscountID, EZPlusID)
VALUES (111128,6,5);

--select statement for corporate customer table
SELECT * FROM CorporateCustomer;

--insert statements for CorporateCustomer
INSERT INTO CorporateCustomer(CustomerID, CompanyID)
VALUES (111118,1);

--insert statements for CorporateCustomer
INSERT INTO CorporateCustomer(CustomerID, CompanyID)
VALUES (111120,2);

--insert statements for CorporateCustomer
INSERT INTO CorporateCustomer(CustomerID, CompanyID)
VALUES (111125,3);

--insert statements for CorporateCustomer
INSERT INTO CorporateCustomer(CustomerID, CompanyID)
VALUES (111129,4);

--insert statements for CorporateCustomer
INSERT INTO CorporateCustomer(CustomerID, CompanyID)
VALUES (111130,5);

--Select statement for Creditcard where credircardnumber is 4111111111111111
SELECT CreditCardNumber FROM CreditCard 
WHERE CreditCardNumber ='4111111111111111';

--Select statement for Customer where customertype is R
SELECT CustomerID,FirstName,LastName,CustomerType FROM Customer 
WHERE CustomerType = 'R';

-- Select join
SELECT Customer.CustomerID, Customer.FirstName,Customer.LastName, Customer.CustomerType, CreditCard.CreditCardNumber,
CreditCard.CreditCardOwnerName, CreditCard.CreditCardBalance
FROM CreditCard, Customer, Customer_CreditCard
WHERE Customer_CreditCard.CustomerID = Customer.CustomerID AND CreditCard.CreditCardNumber = Customer_CreditCard.CreditCardNumber 
AND CreditCardBalance >= 5000 AND CustomerType ='R'; 

--Update statement for Credit Card table
UPDATE CreditCard
SET CreditCardOwnerName = 'Elon Musk'
WHERE CreditCardNumber = '5111111111111111'

--Update statement for Customer credit card table
UPDATE Customer_CreditCard
SET CreditCardNumber = '5111111111111111'
WHERE CustomerID = '111115'

--select statement
SELECT * FROM Customer_CreditCard;

--select statement
SELECT * FROM Customer;

--select statement
SELECT * FROM RetailCustomer;

--delete statement
DELETE 
FROM Customer
WHERE CustomerID = 111115;

--select statement
SELECT * FROM CreditCard;

--select statement
SELECT * FROM Customer_CreditCard;

--delete statement
DELETE 
FROM CreditCard
WHERE CreditCardNumber = '4111111111111111';