create database MovieDetails

use MovieDetails

create table movie(Id int identity primary key,
					Name varchar(100) not null,
					MovieType Varchar(100) not null,
					MovieDesc varchar(max) not null);

create table MovieShowTime(Id int identity primary key,
							MovieId int references movie(Id),
							StartTime varchar(20) not null,
							ShowDate date not null)



insert into movie values('Avenger', 'Action', 'MCU');
insert into movie values('Ratsasana', 'Thriller', 'Tamil movie');
insert into movie values('KGF', 'Action', 'Kannada movie');
insert into movie values('Shershah', 'Patriotic', 'Biopic');
insert into movie values('Avenger 2', 'Action', 'MCU');
insert into movie values('Doctor Strange', 'Action', 'MCU');
insert into movie values('Hera Pheri', 'Comedy', 'Hindi');


insert into MovieShowTime values(3, '5pm','2019-12-26');
insert into MovieShowTime values(2, '1:30 pm','2019-08-12');
insert into MovieShowTime values(6, '8 pm','2017-08-03');
insert into MovieShowTime values(4, '5 pm','2021-10-01');
insert into MovieShowTime values(5, '10 pm','2013-11-20');


select * from movie
select * from MovieShowTime

