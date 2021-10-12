create database office
use office

create table project(projectNumber int identity(1001,1) primary key,name varchar(30),startDate date)

create table department(departmentNumber int identity(2001,1) primary key,name varchar(30))
						
create table employee(employeeNumber int identity(3001,1) primary key,job_Title varchar(30) not null,
						lastName varchar(30),firstName varchar(30) not null,
						gender varchar(10) not null,birthday date not null,
						hiredate date not null,
						departmentNumber int references department(departmentNumber),
						projectNumber int references project(projectNumber))

insert into project values('Project1','2021-08-17')
insert into project values('Project2','2021-08-07')

insert into department values('Department1')
insert into department values('Department2')

insert into employee values('Job1','LastName1','FirstName1','Male','2000-06-04','2021-05-12',2001,1001)
select * from department
select * from project
select * from employee
