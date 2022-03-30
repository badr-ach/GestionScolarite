create table filieres( 
    id int AUTO_INCREMENT,
    code varchar(10) UNIQUE,
    designation varchar(100),
    PRIMARY KEY (id)
);
create table modules( 
    id int AUTO_INCREMENT,
    code varchar(10) UNIQUE,
    designation varchar(100),
    niveau VARCHAR(10),
    semestre VARCHAR(10),
    code_fil varchar(10),
    primary KEY (id),
    FOREIGN KEY (code_fil) REFERENCES filieres(code)

);
create table matieres(
    id int AUTO_INCREMENT,
    code varchar(10) UNIQUE,
    designation VARCHAR(100),
    VH int,
    code_module varchar(10),
    PRIMARY KEY(id),
    FOREIGN KEY (code_module) REFERENCES modules(code)
);
create table eleves (
    id int AUTO_INCREMENT,
    code VARCHAR(10) UNIQUE,
    nom VARCHAR(50),
    prenom varchar(50),
    niveau varchar(10),
    code_fil varchar(10),
    PRIMARY KEY (id),
    FOREIGN KEY (code_fil) REFERENCES filieres(code)

);
create table notes(
    id int AUTO_INCREMENT,
    code_eleve varchar(10),
    code_mat varchar(10),
    note decimal(9,4),
    PRIMARY KEY(id),
    FOREIGN KEY (code_eleve) REFERENCES eleves(code),
    FOREIGN KEY (code_mat) REFERENCES matieres(code),
    unique(code_eleve, code_mat)
);
create table moyennes(
    id int AUTO_INCREMENT,
    code_eleve varchar(10),
    code_fil varchar(10),
    niveau varchar(10),
    moyenne decimal,
    PRIMARY KEY(id),
    FOREIGN KEY (code_eleve) REFERENCES eleves(code),
    FOREIGN KEY (code_fil) REFERENCES filieres(code) 
);

insert into filieres (code,designation) values ("AP","Année préparatoire");
insert into filieres (code,designation) values ("GINF","Génie informatique");
insert into filieres (code,designation) values ("GIND","Génie industriel");
insert into filieres (code,designation) values ("GSTR","Génie systèmes réseaux et télécomes");
insert into filieres (code,designation) values ("GSEA","Génie éléctronique et automatique");
insert into filieres (code,designation) values ("G3EI","Génie Environement");



insert into modules (code, designation, niveau, semestre, code_fil) values ("AP1mod1", "module 1 AP1", "1", "S1", "AP");
insert into modules (code, designation, niveau, semestre, code_fil) values ("AP1mod2", "module 2 AP1", "1", "S2", "AP");
insert into modules (code, designation, niveau, semestre, code_fil) values ("AP2mod1", "module 1 AP2", "2", "S1", "AP");
insert into modules (code, designation, niveau, semestre, code_fil) values ("AP2mod4", "module 4 AP2", "2", "S2", "AP");
insert into modules (code, designation, niveau, semestre, code_fil) values ("GINF1mod1", "module 1 GINF1", "1", "S1", "GINF");
insert into modules (code, designation, niveau, semestre, code_fil) values ("GINF2mod2", "module 2 GINF2", "2", "S1", "GINF");
insert into modules (code, designation, niveau, semestre, code_fil) values ("GINF2mod3", "module 3 GINF2", "2", "S2", "GINF");
insert into modules (code, designation, niveau, semestre, code_fil) values ("GINF2mod6", "module 6 GINF1", "2", "S1", "GINF");
insert into modules (code, designation, niveau, semestre, code_fil) values ("GIND3MOD1", "module 1 GINFD3", "3", "S1", "GIND");


insert into matieres (code, designation, vh, code_module) values ("AP1mat11", "matiere 1 AP1", "30", "AP1mod1");
insert into matieres (code, designation, vh, code_module) values ("AP1mat12", "matiere 2 AP1", "20", "AP1mod1");
insert into matieres (code, designation, vh, code_module) values ("AP1mat22", "matiere 4 AP1", "40", "AP1mod2");
insert into matieres (code, designation, vh, code_module) values ("GINF1mat11", "matiere 1 GINF1", "10", "GINF1mod1");
insert into matieres (code, designation, vh, code_module) values ("GINF1mat12", "matiere 2 GINF1", "15", "GINF1mod1");
insert into matieres (code, designation, vh, code_module) values ("GINF2mat21", "matiere 3 GINF2", "30", "GINF2mod2");
insert into matieres (code, designation, vh, code_module) values ("GINF2mat22", "matiere 4 GINF2", "50", "GINF2mod2");
insert into matieres (code, designation, vh, code_module) values ("GINF2mat31", "matiere 5 GINF2", "35", "GINF2mod3");
insert into matieres (code, designation, vh, code_module) values ("GINF2mat32", "matiere 6 GINF2", "55", "GINF2mod3");
insert into matieres (code, designation, vh, code_module) values ("GINF2mat61", "matiere 11 GINF2", "25", "GINF2mod6");
insert into matieres (code, designation, vh, code_module) values ("GINF2mat62", "matiere 12 GINF2", "28", "GINF2mod6");
insert into matieres (code, designation, vh, code_module) values ("GIND3mat11", "matiere 1 GIND3", "23", "GIND3MOD1");
insert into matieres (code, designation, vh, code_module) values ("GIND3mat12", "matiere 2 GIND3", "60", "GIND3MOD1");


insert into eleves (code, nom, prenom, niveau, code_fil) values ("E1", "NOM1", "PRENOM1", '1', "AP");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E2", "NOM2", "PRENOM2", '1', "AP");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E3", "NOM3", "PRENOM3", '1', "AP");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E4", "NOM4", "PRENOM4", '2', "AP");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E5", "NOM5", "PRENOM5", '1', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E6", "NOM6", "PRENOM6", '1', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E7", "NOM7", "PRENOM7", '2', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E8", "NOM8", "PRENOM8", '2', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E9", "NOM9", "PRENOM9", '2', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E10", "NOM10", "PRENOM10", '2', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E11", "NOM11", "PRENOM11", '2', "GINF");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E12", "NOM12", "PRENOM12", '3', "GIND");
insert into eleves (code, nom, prenom, niveau, code_fil) values ("E13", "NOM13", "PRENOM13", '3', "GIND");



insert into notes (code_eleve, code_mat, note) values ('E7', 'GINF2mat21', 12.4);
insert into notes (code_eleve, code_mat, note) values ('E7', 'GINF2mat22', 15.76);
insert into notes (code_eleve, code_mat, note) values ('E7', 'GINF2mat31', 10);
insert into notes (code_eleve, code_mat, note) values ('E7', 'GINF2mat32', 3.4);
insert into notes (code_eleve, code_mat, note) values ('E7', 'GINF2mat61', 19.5);



delimiter //            
create trigger moyenneInsert
after insert on notes
for each row
begin

declare numMatiere int;
declare numNote int;
declare codeFiliere varchar(10);
declare moy decimal(9,2);
declare niv varchar(10);

select niveau, code_fil into niv, codeFiliere from eleves where code = new.code_eleve;
select count(*)  into numMatiere from matieres where code_module in (select code from modules where code_fil = codeFiliere AND niveau = niv);
select count(*) into numNote from notes where code_eleve = new.code_eleve;

if ( numMatiere = numNote ) then
    select AVG(note) into moy from noteS where code_eleve = new.code_eleve;
    insert into moyennes(code_eleve, code_fil, niveau, moyenne) values(new.code_eleve, codeFiliere, niv, moy);
end if; 
end //
delimiter ;

delimiter //
create trigger moyenneUpdate
after update on notes
for each row
begin
declare codeFiliere varchar(10);    
declare moy decimal(9,2);
declare niv varchar(10);
select niveau, code_fil into niv, codeFiliere from eleves where code = new.code_eleve;
select AVG(note) into moy from notes where code_eleve = new.code_eleve;
update moyennes set moyenne = moy where code_eleve = new.code_eleve and niveau = niv and code_fil = codeFiliere;
end //

delimiter ;

delimiter //

create trigger moyenneDelete
after delete on notes
for each row
begin
declare codeFiliere varchar(10);
declare niv varchar(10);
select niveau, code_fil into niv, codeFiliere from eleves where code = new.code_eleve;
delete from moyennes where code_eleve = old.code_eleve and niveau = niv and code_fil = codeFiliere;
end //

delimiter ;


delimiter //
DELIMITER |
CREATE PROCEDURE InsertNote
(
    IN code_eleve varchar(100),
    IN code_mat varchar(100),
    IN note numeric
)
BEGIN
    Insert into notes(code_eleve,code_mat,note) values (code_eleve,code_mat,note);
END|

DELIMITER ;


DELIMITER |
CREATE PROCEDURE UpdateNote
(
	IN id int,
    IN code_eleve varchar(100),
    IN code_mat varchar(100),
    IN note numeric
)
BEGIN
    Update notes set note=note where code_eleve=code_eleve and code_mat=code_mat and id=id;
END|

DELIMITER ;


DELIMITER |
CREATE PROCEDURE DeleteNote
(
	IN id int
)
BEGIN
    Delete from notes where id = id;
END|

DELIMITER ;

