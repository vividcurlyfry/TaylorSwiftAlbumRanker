USE [master]

DROP DATABASE IF EXISTS TaylorSwiftAlbumRanker
CREATE DATABASE TaylorSwiftAlbumRanker

USE [TaylorSwiftAlbumRanker] 

DROP TABLE IF EXISTS Ranking
DROP TABLE IF EXISTS Users
DROP TABLE IF EXISTS Albums
DROP TABLE IF EXISTS Roles
DROP TABLE IF EXISTS RolePermissions

CREATE TABLE RolePermissions(
	RolePermissionID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	PermissionName varchar(150),
	CanPerform BIT
)

CREATE TABLE Roles(
	RoleID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	RoleName varchar(150),
	RolePermissionID int FOREIGN KEY REFERENCES RolePermissions(RolePermissionID)
)


CREATE TABLE Albums(
	AlbumID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	AlbumName varchar(150),
	PictureHyperlink varchar(150) 
)


CREATE TABLE Users(
	UserID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Username varchar(150),
	RoleID int FOREIGN KEY REFERENCES Roles(RoleID)
)


CREATE TABLE Ranking(
	RankingID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	AlbumID int FOREIGN KEY REFERENCES Albums(AlbumID),
	Ranking int,
	UserID int FOREIGN KEY REFERENCES Users(UserID)
)