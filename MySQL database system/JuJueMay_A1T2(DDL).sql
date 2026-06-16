Create database if not exists Singa_Database_System;

use Singa_Database_System;

Create table Customers(
CID int auto_increment primary key not null,
SSN int null,
CName varchar(50),
Address varchar(50),
Phone varchar(50)
);

Create table Local_Customers(
CID int,
foreign key (CID) references Customers(CID) on update cascade on delete cascade,
Company_Name varchar(50),
Work_Phone int
);

Create table Foreign_Customers(
CID int,
foreign key (CID) references Customers (CID) on update cascade on delete cascade,
Passport_Number varchar(30),
CountryofOrigin varchar(40)
);

Create table AutoMobile_Type(
Automobile_TypeID int auto_increment primary key not null,
Automobile_TypeName varchar(50),
Daily_rate double,
TotalCars int
);

Create table Car(
CarID int auto_increment primary key not null,
Plate_Number varchar(20) unique,
Model_Number varchar(20),
AutoMobile_TypeID int,
foreign key (Automobile_TypeID) references Automobile_Type(Automobile_TypeID) on update cascade on delete cascade
);


Create table Rental(
Rental_ID int auto_increment primary key,
CID int,
foreign key (CID) references Customers (CID) on update cascade on delete cascade,
CarID int, 
foreign key (CarID) references Car (CarID) on update cascade on delete cascade,
Rental_date date,
Return_date date,
RentalPurpose varchar(40), /* business or leisure*/
DepositStatus varchar(20)   /* deposit or full */
);

Create table Payment(
PaymentID int auto_increment primary key,
Rental_ID int,
foreign key (Rental_ID) references Rental (Rental_ID) on update cascade on delete cascade,
PaymentMode varchar(20), /* credit or cash*/
Amount float,
PDate date
);

/* Inserting data in customer*/
insert into Customers (SSN, CName, Address, Phone) values (123456789,'Mr.Michael', 'Yangon', '0965151606');
insert into Customers (CName, Address, Phone) values ('K.Thee', 'Bangkok', '066224789');
insert into Customers (SSN, CName, Address, Phone) values (855121245,'Miss.Rose', 'Mandalay', '0912005456'), (855121788,'Minny','Yangon', '0988481651');
insert into Customers (CName, Address, Phone) values ('Xiao Li','Beijing','0651914984');
insert into Customers (SSN, CName, Address, Phone) values (455458755,'Ms.Jade','Yangon', '0932314816');
insert into Customers (CName, Address, Phone) values ('Zhao Na','Yunan','0984101565');
insert into Customers (SSN, CName, Address, Phone) values (223345844,'Derek', 'Mandalay', '0955566646');
insert into Customers (CName, Address, Phone) values ('Fukawa','Kyoto','015412154');
insert into Customers (SSN, CName, Address, Phone) values (445566881,'Rachael', 'Yangon', '0915212124');

/* inserting data in Local customer*/
insert into Local_Customers(CID) values (1);
insert into Local_Customers(CID, Company_Name, Work_Phone) values (3,'Rose Frangrance Ltd', 0912005456),(4,'Minn Electronic Ltd', 0988481651),(5,'Jade Jewelery Ltd', 0932314816);
insert into Local_Customers(CID) values (8),(10);

/* inserting data in Foreign Customer*/
insert into Foreign_Customers(CID,Passport_Number,CountryofOrigin) values (2,'TA1234567','Thailand'), (5,'CB9526564','China'),(7,'CY5454544','China'),(9,'JK9988778','Japan');

/*inserting data in Automobile types*/
insert into AutoMobile_Type values(1,'Luxury',150,8),(2,'Mid-size', 100, 10),(3,'Economy', 80, 10);

/*inserting data in Car - luxury*/
insert into Car(Plate_Number, Model_Number, Automobile_TypeID) values 
('LUX001', 'Mercedes S500', 1), ('LUX002', 'BMW 7 Series', 1), ('LUX003', 'Audi A8', 1), 
('LUX004', 'Tesla Model S', 1), ('LUX005', 'Jaguar XJ', 1), ('LUX006', 'Lexus LS500', 1), 
('LUX007', 'Porsche Panamera', 1), ('LUX008', 'Genesis G90', 1);

/*inserting data in Car - mid-size*/
insert into Car(Plate_Number, Model_Number, Automobile_TypeID) values 
('MID001', 'Toyota Camry', 2), ('MID002', 'Honda Accord', 2), ('MID003', 'Nissan Altima', 2),
('MID004', 'Hyundai Sonata', 2), ('MID005', 'Kia Optima', 2), ('MID006', 'Chevrolet Malibu', 2), 
('MID007', 'Volkswagen Jetta', 2), ('MID008', 'Mazda 6', 2), ('MID009', 'Subaru Legacy', 2), 
('MID010', 'Ford Fusion', 2),('MID011', 'Peugeot 508', 2);

/*inserting data in Car - Economy*/
insert into Car(Plate_Number, Model_Number, Automobile_TypeID) values 
('ECO001', 'Toyota Corolla', 3), ('ECO002', 'Honda Civic', 3), ('ECO003', 'Nissan Sentra', 3), 
('ECO004', 'Hyundai Elantra', 3), ('ECO005', 'Kia Rio', 3), ('ECO006', 'Ford Focus', 3), 
('ECO007', 'Chevrolet Spark', 3), ('ECO008', 'Mitsubishi Mirage', 3), ('ECO009', 'Suzuki Swift', 3), 
('ECO010', 'Toyota Yaris', 3),('ECO011', 'Honda Fit', 3);

/*insert data into Rental table*/
insert into Rental(CID, CarID, Rental_date, Return_date, RentalPurpose, DepositStatus) values (1,2,'2025-12-21', '2025-12-28', 'Leisure', 'Deposit'), 
(2,6,'2026-1-16','2026-1-23','Leisure','Full'), (3,10,'2026-1-16','2026-1-23','Business','Full'),(4,13,'2026-1-18','2026-2-17','Business','Full'),
(5,20,'2026-1-20','2026-1-27','Leisure','Deposit'),(6,23,'2026-1-21','2026-2-20','Business','Full'),(7,28,'2026-1-22','2026-2-21','Business','Deposit'),
(8,29,'2026-2-7','2026-2-14','Leisure','Deposit'),(9,18,'2026-2-10','2026-2-17','Leisure','Deposit'),(10,30,'2026-2-12','2026-2-19','Leisure','Deposit');


/*inserting data into Payment table*/
insert into Payment(Rental_ID, PaymentMode, Amount, PDate) values (1,'Cash', 10000, '2025-12-21'),
(2,'Credit',10000,'2026-1-16'),(3,'Credit',15000,'2026-1-19'),(4,'Credit',15000,'2026-1-21'),
(5,'Cash',10000,'2026-1-21'),(6,'Credit',15000,'2026-2-20'),(7,'Credit',10000,'2026-1-22'),
(8,'Cash',5000,'2026-2-8'),(9,'Credit',10000,'2026-2-11'),(10,'Cash',10000,'2026-2-13');






