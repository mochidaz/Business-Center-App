declare @max int
select @max=max(id_barang) from dbo.tbl_barang
if @max IS NULL   --check when max is returned as null
  SET @max = 0
DBCC CHECKIDENT ('dbo.tbl_barang', RESEED, @max)