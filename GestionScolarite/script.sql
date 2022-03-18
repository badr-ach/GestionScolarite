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