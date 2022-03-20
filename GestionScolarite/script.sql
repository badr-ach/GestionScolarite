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
    note numeric,
    PRIMARY KEY(id),
    FOREIGN KEY (code_eleve) REFERENCES eleves(code),
    FOREIGN KEY (code_mat) REFERENCES matieres(code)
);
create table moyennes(
    id int AUTO_INCREMENT,
    code_eleve varchar(10),
    code_fil varchar(10),
    niveau varchar(10),
    moyenne NUMERIC,
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


create or replace trigger moyenneAnnee 
after insert or update or delete on notes
for each row
declare
numMatiere int;
numNote int;
codeFiliere varchar(10);
moy int;
niv varchar(10);
begin

select niveau into niv from eleves where code = :new.code_eleve;
select code into codeFiliere from filiere where code in ( select code_fil from eleves where code = :new.code_eleve)
if inserting then
select count(*)  into numMatiere from matieres where code_module in (select code from modules where code_fil = codeFiliere);
select count(*) into numNote from notes where code_eleve = :new.code_eleve;
select sum(note) into moy from note where code_eleve = :new.code_eleve;
if numMatiere = numNote then
    moy = moy / numNote;
    insert into moyennes(code_eleve, code_fil, niveau, moyenne) values(:new.code_eleve, codeFiliere, niv, moy);
elsif deleting