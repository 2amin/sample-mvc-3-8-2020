alter PROCEDURE dbo.Insertproduct
  @InsertProduct Insertproduct1 readonly 
AS
declare @eror nvarchar(50)
    begin tran
	begin try
	Insert into Product
	Select inp.productname,inp.unitprice,inp.discount,inp.productimage From @InsertProduct inp
	set @eror='products are Inserted'
	commit tran
	end try
	
	begin catch
	rollback tran
	set @eror='Please try again'
	end catch
RETURN 0 