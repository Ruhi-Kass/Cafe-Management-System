create database Cafe_management_system
use Cafe_management_system

-----MAKE SOME ATTRIBUTTES UNIQUE ,SO WE DONT ALLOW DUPLICATE ENTRIES,OR USE A TRIGGER TO DO THAT DUMB ASS!!!!

create table userLogin
(
  userid int primary key identity,
  username varchar(20),
  password varbinary(100)
)
create table Employee                                  
(
  employee_id int primary key identity,
  full_name varchar(30),
  DateOfBirth date,
  DateOfHire date,
  PhoneNumber varchar(20),--should be unique
  email varchar(50),
  userid int foreign key references userLogin(userid),
  img varbinary(max),
  position varchar(15)
)

 create table Seating_tables
 (
   table_id int primary key identity,
   table_number int,
   available bit--use trigger to check if available.
 )
create table  customer 
(
 customer_id int primary key identity,
 Customer_name varchar(30),
 table_id int foreign key references Seating_tables(table_id)
)
create table orders
(
  Order_id int primary key identity,
  Customer_id int foreign key references customer(customer_id),
  quantity int,

)
--available MenuItems()
 create table suppliers 
 (
   supplier_id int primary key identity,
   email varchar(50),
   supplier_name varchar(30)
 )
create table MenuItems
(
  MenuItem_id int primary key identity,
  MenuItem_name varchar(30),
  Descriptions varchar(max),
  price decimal,
  Category varchar(10),
  Img varbinary(max)
)

--table created for handling  multiple orders from 1 customer.
create table OrderItem
(
 OrderItemID INT Primary Key identity,          
 OrderID  INT Foreign Key references orders(Order_id),   
 MenuItemID INT Foreign Key references menuitems(MenuItem_id),
 AmountOrdered INT ,                                                        
 )


 create table Ingredients 
(
 IngredientID  INT Primary Key identity,
 sid int foreign key references suppliers(supplier_id),
 IngredientName   VARCHAR(20) ,                    
 AvailableQuantity  DECIMAL,                 
 UnitOfMeasurement  VARCHAR(20)                     
 )--should we add suplier id as fk?
 create table recipe
(
 RecipeID  INT Primary Key identity, 
 MenuItem_id INT FOREIGN KEY REFERENCES MenuItems(MenuItem_id),
 RecipeName VARCHAR(50) ,                    
 Price  DECIMAL                      
 )	--should be added every time with its corresponding menu item!									
 insert into suppliers values('supplier@Gmail.com','merkato')

--table for tracking amount of ingridients because a single recipe could have more than 1 ingredient
create table  [Recipe Ingredients]
(
 RecipeIngredientID INT Primary Key identity,           
 RecipeID INT Foreign Key references Recipes(RecipeId),   
 Ingredient_ID INT Foreign Key references Ingredients(IngredientId),
 Quantity DECIMAL,                                                       
 )

 create table supplier_phonenumbers 
 (
    sid int foreign key references suppliers(supplier_id),
	phone_number varchar(20),
	numberType varchar(15)---office or personal
 )
 create table supplier_address 
 (
    sid int foreign key references suppliers(supplier_id),
	address varchar(100),
	branch_no int
 )



 insert into Seating_tables values(1,1)
 ---dont forget the userlogin table dumb dumb!!!
