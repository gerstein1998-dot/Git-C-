create PROC P_Item_By_Above_Price (@price int)
as
Select * from TBItem where Price >= @price
Go
