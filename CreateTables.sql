USE [master]

DROP DATABASE IF EXISTS TaylorSwiftAlbumRanker
GO

CREATE DATABASE TaylorSwiftAlbumRanker
GO

USE TaylorSwiftAlbumRanker 
GO

CREATE TABLE PermissionsTable(
	PermissionID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	PermissionName varchar(150),
	PermissionDescription varchar(200)
)

CREATE TABLE RolesTable(
	RoleID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	RoleName varchar(150),
	RoleDescription varchar(200)
)

CREATE TABLE RolePermissionsTable(
	RolePermissionID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	RoleID int FOREIGN KEY REFERENCES RolesTable(RoleID),
	PermissionID int FOREIGN KEY REFERENCES RolesTable(RoleID),
	CanPerform BIT
)

CREATE TABLE AlbumsTable(
	AlbumID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	AlbumName varchar(150),
	PictureHyperlink varchar(150) 
)


CREATE TABLE UsersTable(
	UserID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	Username varchar(150),
	RolePermissionID int FOREIGN KEY REFERENCES RolesTable(RoleID)
)


CREATE TABLE RankingTable(
	RankingID int NOT NULL PRIMARY KEY IDENTITY(1,1),
	AlbumID int FOREIGN KEY REFERENCES AlbumsTable(AlbumID),
	Ranking int,
	UserID int FOREIGN KEY REFERENCES UsersTable(UserID),
	History DATETIME
)

GO