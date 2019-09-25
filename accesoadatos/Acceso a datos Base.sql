CREATE DATABASE casa_apuestas,
USE DATABASE casa_apuestas,

CREATE TABLE Usuario
(nombre varchar(45) NOT NULL,
apellidos VARCHAR(45)NOT NULL,
email VARCHAR(45) NOT NULL,
edad INT NOT NULL 
PRIMARY KEY (perfil,perfil_usuario )
FOREIGN KEY (perfil,perfilUsuario) );

CREATE TABLE Cuenta
(PRIMARY KEY (tarjeta_credito varchar(45)) NOT NULL,
saldo_actual decimal(2)NOT NULL,
nombre_banco VARCHAR(45) NOT NULL,
perfil_usuario VARCHAR(45) NOT NULL 
FOREIGN KEY (perfil_usuario ) );

CREATE TABLE Hace
(PRIMARY KEY (perfilUsuario VARCHAR(45)) NOT NULL,
tipoApuesta VARCHAR(45) NOT NULL
FOREIGN KEY (tipoApuesta,tipo) );

CREATE TABLE Apuesta
(tipo VARCHAR(45) NOT NULL,
over VARCHAR(45) NOT NULL,
cuota_apuesta decimal(2) NOT NULL,
cuota_over/under decimal(2) NOT NULL,
dinero_apuesta decimal(2) NOT NULL,
dinero_over/under decimal(2) NOT NULL
PRIMARY KEY (tipo,tipoApuesta)
FOREIGN KEY (tipo,Mercado_tipoApuesta) );

CREATE TABLE Mercado
(over/under VARCHAR(45) NOT NULL,
tipo_mercado VARCHAR(45) NOT NULL,
Mercado_cuotaover/under VARCHAR(45) NOT NULL,
id INT,
Mercado_dineroover/under VARCHAR(45) NOT NULL,
Mercado_tipoApuesta VARCHAR(45) NOT NULL
PRIMARY KEY (over/under)
FOREIGN KEY (id, idMercado) );

CREATE TABLE Evento
(equipos VARCHAR(45) NOT NULL,
visitante VARCHAR(45) NOT NULL,
Equipo_local VARCHAR(45) NOT NULL,
idMercado INT NOT NULL,
PRIMARY KEY (equipos) );
