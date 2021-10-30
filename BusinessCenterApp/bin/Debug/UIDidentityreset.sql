declare @max int
select @max=max(uid) from dbo.tbl_user
if @max IS NULL   --check when max is returned as null
  SET @max = 0
DBCC CHECKIDENT ('dbo.tbl_user', RESEED, @max)