--use GeneralTest01;


--alter table GeneralTest01.dbo.Usuario add userRole varchar(20);
--alter table GeneralTest01.dbo.Usuario add lastLockoutDate datetime;
--alter table GeneralTest01.dbo.Usuario add lastActivityDate datetime;
--alter table GeneralTest01.dbo.Usuario add lastLogindate datetime;
alter table GeneralTest01.dbo.Usuario add creationDate datetime;
alter table GeneralTest01.dbo.Usuario add lastPasswordChangedDate datetime;
alter table GeneralTest01.dbo.Usuario add userName varchar(32) default('');
alter table GeneralTest01.dbo.Usuario add isApproved bit default(0);
alter table GeneralTest01.dbo.Usuario add isLockedOut bit default(0);
alter table GeneralTest01.dbo.Usuario add isOnline bit default(0);
