----create triger to validate age.
----trigger to deduct amount when order is placed.
--trigger to check availabilty of table when customer reserves.



go
CREATE or alter TRIGGER deductIngredient--deducts amount of ingredient buy amount neede for order
ON orderitem
FOR INSERT
AS
BEGIN
    DECLARE @recipeid int=(select orderid from inserted)
	Declare @IngId int=(select Ingredient_ID from [Recipe Ingredients])
    DECLARE @amountordered int=(select amountordered from inserted)
	DECLARE @Quantity int=(select quantity from [Recipe Ingredients] where RecipeID=@recipeid )
    Declare @availableamount int=(select AvailableQuantity from Ingredients where IngredientID=@IngId)
	update Ingredients
	set AvailableQuantity=(AvailableQuantity)-(@Quantity*@amountordered)
  END 
GO

go
CREATE or alter  TRIGGER trAgeCheck
ON Employee
for INSERT
AS
BEGIN
    DECLARE @date DATE = (select dateofbirth FROM inserted)
	declare @age int=(select DATEDIFF(YEAR,@date,GETDATE()))
    IF (@age<18)
     BEGIN
        throw 50001, 'employee is under 18 years of age', 1;
     END
  END 
GO