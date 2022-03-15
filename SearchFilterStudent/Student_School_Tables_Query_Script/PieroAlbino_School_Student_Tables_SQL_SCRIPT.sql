
/*School table
id (primary key)
name
id_country
*/
create table school(
	id int NOT NULL ,
	name char(50) NOT NULL,
	id_country int ,
	CONSTRAINT school_pk PRIMARY KEY (id),
);

/*
Student table
identity_card (primary key)
names
surnames
date_of_birth
id_school (foreign key from school table)
*/
create table student(
	identity_card int not null ,
	"name" char(30) not null,
	"surnames" char(30) not null,
	date_of_birth datetime not null,
	id_school int not null,
	constraint student_pk primary key (identity_card),
	constraint fk_SchoolID foreign key (id_school) references school(id),
);

/*Fill with Dummy Data*/
insert into school (id, name, id_country) values (1, 'France', 1);
insert into school (id, name, id_country) values (2, 'Philippines', 2);
insert into school (id, name, id_country) values (3, 'China', 3);
insert into school (id, name, id_country) values (4, 'Brazil', 4);
insert into school (id, name, id_country) values (5, 'Mexico', 5);
insert into school (id, name, id_country) values (6, 'Indonesia', 6);
insert into school (id, name, id_country) values (7, 'Russia', 7);
insert into school (id, name, id_country) values (8, 'Indonesia', 8);
insert into school (id, name, id_country) values (9, 'Portugal', 9);
insert into school (id, name, id_country) values (10, 'Poland', 10);


insert into student (identity_card, name, surnames, date_of_birth, id_school) values (1, 'Pénélope', 'Russe', '5/15/2012', 1);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (2, 'Bénédicte', 'Flory', '4/13/2005', 2);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (3, 'Loïc', 'Carillo', '7/26/2002', 3);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (4, 'Dafnée', 'Allerton', '2/24/2022', 4);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (5, 'Lyséa', 'Arkill', '1/10/2002', 5);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (6, 'Béatrice', 'Glowacz', '5/16/2004', 6);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (7, 'Maïly', 'Capron', '11/6/2009', 7);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (8, 'Faîtes', 'Bonhomme', '5/14/2021', 8);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (9, 'Andréa', 'Ghiraldi', '7/28/2019', 9);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (10, 'Laurène', 'Doy', '4/9/2010', 10);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (1, 'Méng', 'Rearie', '7/29/2021', 1);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (2, 'Annotée', 'Fawcitt', '11/2/2010', 3);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (3, 'Maëly', 'Losebie', '7/11/2007', 3);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (4, 'Kù', 'Courteney', '9/8/2014', 3);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (5, 'Björn', 'Iskow', '9/2/2014', 5);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (6, 'Marie-thérèse', 'Longlands', '5/30/2012', 7);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (7, 'Mélodie', 'Pautard', '12/10/2018', 9);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (8, 'Léandre', 'Anscott', '6/28/2003', 8);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (9, 'Gösta', 'Shakle', '7/2/2000', 9);
insert into student (identity_card, name, surnames, date_of_birth, id_school) values (10, 'Camélia', 'Rodenburg', '7/13/2001', 5);