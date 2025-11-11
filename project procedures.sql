
use Cafe_management_system
go
--procedure for inserting into employee table
create or alter procedure udpInsertEmployee
@name varchar(30),
@dob date,
@Phone_no bigint,
@email varchar(50),
@uid int,
@img varbinary(max),
@pos varchar(15)
as  
begin
   insert into Employee values(@name,@dob,GETDATE(),@Phone_no,@email,@uid,@img,@pos)
end
go


go
--procedure for inserting into employee table
create or alter procedure  dbo.udpInsertIngredient 
@Ingname varchar(30),
@supplier_name varchar(30),
@availableAmount int,
@UnitOfMeasurement  VARCHAR(20)
as  
begin
declare @sid int=(select dbo.udfReturnSupplierId(@supplier_name))
   insert into Ingredients values(@sid,@Ingname,@availableAmount,@UnitOfMeasurement)
end
go

go--procedure for inserting into recipeingredients table
create or alter procedure udpInsertRecipeIngredients
@Recipename varchar(30),
@Ingname varchar(30),
@amount int
as  
begin
declare @id int=(select dbo.udfReturnRecId(@Recipename))--foreign key id of recipe.
declare @Ingid int=(select dbo.udfReturnIngId(@ingname))--foreign key id of ingredient.

   insert into [Recipe Ingredients] (RecipeID,Ingredient_ID,Quantity)values(@id,@Ingid,@amount)
end
go  
go--procedure for inserting into Recipe table
CREATE OR ALTER PROCEDURE udpInsertRecipe
    @product_name varchar(30),
    @Recipe_name varchar(50),
    @price decimal
AS
BEGIN
    declare @id int=dbo.udfReturn(@Recipe_name)
    INSERT INTO Recipes (MenuItem_id, RecipeName, Price)
    VALUES (@id, @Recipe_name, @price)

END
GO

go--function to return recipeid
create function dbo.udfReturnRecId(@Recipename varchar(20))
returns int
as
begin
	declare @id int=(select RecipeID from Recipes where RecipeName=@Recipename)
	return @id
end
go

go---returns id of supplier for adding into products table.
create or alter function dbo.udfReturn(@name varchar(30))
returns int
as
begin
  declare @id int=(select MenuItems.MenuItem_id from MenuItems where MenuItems.MenuItem_name=@name)
  return @id
end
go

GO--function that returns ingredient id.

CREATE FUNCTION dbo.udfReturnIngId(@Ingname varchar(30))
RETURNS int
AS
BEGIN
  DECLARE @id int = (SELECT IngredientID FROM Ingredients WHERE IngredientName = @Ingname)
  RETURN @id
END
GO

GO--function that returns supplier id.
CREATE FUNCTION dbo.udfReturnSupplierId(@supplier_name varchar(30))
RETURNS int
AS
BEGIN
  DECLARE @id int = (SELECT supplier_id FROM suppliers WHERE supplier_name = @supplier_name)
  RETURN @id
END
GO


 go--procedure for removing customer.
 create procedure udpDeleteCustomer
 @attribute varchar(10),
 @value varchar(30)
 as
 begin
   if(@attribute='Customer_id' or @attribute='table_id')
		delete from customer where @attribute= convert(int,@value)
   else
     delete from customer where @attribute= @value
 end
 go

---maybe create functions to calculate price of orders?
