DROP DATABASE bancoaraci;

CREATE DATABASE bancoaraci;

USE bancoaraci;


CREATE TABLE USUARIO (
	ID_usuario INT PRIMARY KEY NOT NULL identity(1,1),
	Nome varchar(100) NOT NULL,
	email_usuario varchar(200) NOT NULL UNIQUE,
    senha_usuario varchar(70) NOT NULL
);

CREATE TABLE JOGO (
	ID_jogo INT PRIMARY KEY NOT NULL identity(1,1),
	nome_jogo varchar(100) NOT NULL,
	qntd_nivel int NOT NULL,
    pontuacao_nivel int NOT NULL
);

CREATE TABLE USUARIO_JOGO (
	ID_jogo INT NOT NULL,
	ID_usuario INT  NOT NULL,
   ponto_nivel_jogo int NOT NULL,
   primary key (ID_jogo, ID_usuario)
);



ALTER TABLE USUARIO_JOGO ADD CONSTRAINT id_usuario FOREIGN KEY (ID_usuario) REFERENCES USUARIO(ID_usuario);

ALTER TABLE USUARIO_JOGO ADD CONSTRAINT id_jogo FOREIGN KEY (ID_jogo) REFERENCES JOGO(ID_jogo);




insert into JOGO (nome_jogo, qntd_nivel, pontuacao_nivel) values ('Video de introdução', 1, 10);
insert into JOGO (nome_jogo, qntd_nivel, pontuacao_nivel) values ('Audio dos números', 10, 20);
insert into JOGO (nome_jogo, qntd_nivel, pontuacao_nivel) values ('Tiro ao alvo', 10, 30);
insert into JOGO (nome_jogo, qntd_nivel, pontuacao_nivel) values ('Jogo da memória', 1, 40);
insert into JOGO (nome_jogo, qntd_nivel, pontuacao_nivel) values ('Quebra-Cabeça', 1, 50);



	SELECT * FROM USUARIO;
	SELECT * FROM JOGO;
	SELECT * FROM USUARIO_JOGO;




