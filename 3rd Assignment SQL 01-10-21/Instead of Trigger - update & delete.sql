create table employee(id int primary key,name varchar(10),gender varchar(10),deptid int );
insert into employee values(1,'karan','male',3);
insert into employee values(2,'manoj','male',2);
insert into employee values(3,'ganesh','male',1);

create table department(deptid int primary key,deptname varchar (10));
insert into department values(1,'IT');
insert into department values(2,'HR');
insert into department values(3,'Admin');

select *from employee;
select *from department;

CREATE VIEW EmployeeDetails
AS select id, name, gender, deptname from employee
join department on employee.deptid = department.deptid

select *from EmployeeDetails;

create trigger tri_EmployeeDetails_InsteadOfUpdate
on EmployeeDetails
instead of update
as
Begin
     -- if employee ID is updated
    if(Update(id))
    Begin
   Raiserror('id cannot be changed',16,1)
Return
End

-- if deptname is updated
if(Update(deptname))
Begin
   Declare @deptId int

select @deptid = deptid
from department
join inserted
on inserted.deptname = department.deptname

if(@deptid is NULL)
Begin
    Raiserror('Invalid Department Name',16,1)
Return
End

Update employee set deptid = @deptId
from inserted
join employee
on employee.id = inserted.id
End
End

-- update value in EmployeeDetails table (Garbage Value)
update EmployeeDetails set name = 'karan', deptname = 'ITabcd' where id =1

-- update value in EmployeeDetails table (Correct Value)
update EmployeeDetails set deptname = 'IT' where id =2


create trigger tri_EmployeeDetails_InsteadOfDelete
on EmployeeDetails
instead of delete
as
Begin
        Delete employee
from employee
join deleted
on employee.id = deleted.id
End

delete from EmployeeDetails where id IN (1,2)
select * from EmployeeDetails