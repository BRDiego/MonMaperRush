﻿USE MASTER;

CREATE DATABASE MONMAPER;

USE MONMAPER;

CREATE TABLE TB_TRANSFERENCE_KIND (
ID SMALLINT IDENTITY,
NAME VARCHAR(20) NOT NULL,
CONSTRAINT PK_TRANFERENCE_KIND PRIMARY KEY(ID)
);

CREATE TABLE TB_SOURCE (
ID SMALLINT IDENTITY,
[DESCRIPTION] VARCHAR(50),

CONSTRAINT PK_SOURCE PRIMARY KEY(ID) 
);


CREATE TABLE TB_TRANSFERENCE(
ID SMALLINT IDENTITY,
KIND SMALLINT,
[DATE] DATE NOT NULL,
AMOUNT DECIMAL(10,2) NOT NULL,
[SOURCE] SMALLINT NOT NULL,
DETAILS VARCHAR(300),
CREATION DATETIME NOT NULL,
UPDATED DATETIME,
CONSTRAINT PK_TRANSFERENCE PRIMARY KEY (ID),
CONSTRAINT FK_TRANFERENCE_KIND FOREIGN KEY (KIND) REFERENCES TB_TRANSFERENCE_KIND (ID),
CONSTRAINT FK_TRANSFERENCE_SOURCE FOREIGN KEY (SOURCE) REFERENCES TB_SOURCE (ID)
);

CREATE TABLE TB_ENTITIES_CONTROL (
ID SMALLINT IDENTITY,
ENTITY VARCHAR(64) NOT NULL,
CONSTRAINT PK_ENTITIES_CONTROL PRIMARY KEY(ID)
);


CREATE TABLE TB_LOG (
ID INTEGER,
ENTITY SMALLINT,
MOMENT DATETIME NOT NULL,
[DESCRIPTION] VARCHAR(500) NOT NULL,
ACTION CHAR(1) NOT NULL,
SEARCH_BASE VARCHAR(1000),
CONSTRAINT PK_LOG PRIMARY KEY (ID),
CONSTRAINT FK_LOG_ENTITY FOREIGN KEY (ENTITY) REFERENCES TB_ENTITIES_CONTROL (ID)
);

CREATE TABLE TB_PERSON (
ID SMALLINT IDENTITY,
FIRSTNAME VARCHAR(20),
SURNAME VARCHAR(50),

CONSTRAINT PK_PERSON PRIMARY KEY(ID)
);

CREATE TABLE TB_REPOSITORY(
ID SMALLINT IDENTITY,
PERSON SMALLINT,
[NAME] VARCHAR(20),
[DESCRIPTION] VARCHAR(50),
TOTAL_AMOUNT DECIMAL(10,2),

CONSTRAINT PK_REPOSITORY PRIMARY KEY (ID),
CONSTRAINT FK_REPOSITORY_PERSON FOREIGN KEY (PERSON) REFERENCES TB_PERSON (ID)
);


CREATE TABLE TB_USER(
ID SMALLINT IDENTITY,
PERSON SMALLINT,
USERNAME VARCHAR(20),
[PASSWORD] VARCHAR(20),

CONSTRAINT PK_USER PRIMARY KEY (ID),
CONSTRAINT FK_USER_PERSON FOREIGN KEY (PERSON) REFERENCES TB_PERSON (ID)
);

CREATE TABLE TB_LOGIN_QUESTION (
ID SMALLINT IDENTITY,
[USER] SMALLINT,
QUESTION VARCHAR(30),
ANSWER VARCHAR(20),

CONSTRAINT PK_LOGIN_QUESTION PRIMARY KEY (ID),
CONSTRAINT FK_LOGIN_QUESTION_USER FOREIGN KEY ([USER]) REFERENCES TB_USER (ID)
);

CREATE TABLE TB_MONEY_MANAGEMENT (
ID SMALLINT IDENTITY,
[USER] SMALLINT,
PERSON SMALLINT,

CONSTRAINT PK_MONEY_MANAGEMENT PRIMARY KEY (ID),
CONSTRAINT FK_MONEY_MANAGEMENT_USER FOREIGN KEY ([USER]) REFERENCES TB_USER (ID),
CONSTRAINT FK_MONEY_MANAGEMENT_PERSON FOREIGN KEY (PERSON) REFERENCES TB_PERSON (ID)
);