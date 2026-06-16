/*1*/
select at.Automobile_TypeName, c.CarID, c.Plate_Number, c.Model_Number
from AutoMobile_Type at
join Car c on at.Automobile_TypeID = c.AutoMobile_TypeID
left join Rental r on c.CarID = r.CarID
and '2026-02-18' between r.Rental_date and r.Return_date
where r.CarID is null
order by c.CarID, at.Automobile_TypeName, c.Model_Number ;

/*2*/
select at.Automobile_TypeName, 
COUNT(c.CarID) as Cars_In_House from Car c 
join AutoMobile_Type at on c.AutoMobile_TypeID = at.Automobile_TypeID 
where c.CarID not in ( select r.CarID from Rental r 
where '2026-01-21' between r.Rental_date and r.Return_date ) 
group by at.Automobile_TypeName;


/*3*/
select count(*) as Luxury_Rents 
from Rental r 
join Car c on r.CarID = c.CarID 
where c.Automobile_TypeID = 1 and r.Rental_date 
between '2025-12-01' and '2026-02-01';

/*4*/
select cu.CName, f.Passport_Number, f.CountryofOrigin, r.Rental_ID, r.CarID, r.Rental_date, r.Return_date, r.RentalPurpose 
from Foreign_Customers f 
join Customers cu on f.CID = cu.CID 
join Rental r on cu.CID = r.CID 
where r.Rental_date 
between '2026-01-15' and '2026-02-15';

/*5*/
select count(distinct at.Automobile_TypeName) as Rented_CarTypes 
from Rental r 
join Car c on r.CarID = c.CarID 
join Automobile_Type at on c.Automobile_TypeID = at.Automobile_TypeID;

/*6*/
select Automobile_TypeName 
from Automobile_Type 
where Automobile_TypeID = ( select c.Automobile_TypeID 
from Rental r 
join Car c on r.CarID = c.CarID 
group by c.Automobile_TypeID 
order by count(*) desc limit 1 );

/*7*/
select PDate, 
sum(Amount) as TotalRevenue 
from Payment 
where PDate = '2026-01-21';
